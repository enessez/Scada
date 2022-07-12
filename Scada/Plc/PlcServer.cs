using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using Label = System.Windows.Forms.Label;

namespace Scada
{
    public class PlcServer : Component
    {
        //Constructor
        public PlcServer()
        {
            BaglantiDurumuChangeEvetHandler += PlcServer_BaglantiDurumuChangeEvetHandler;
        }


        #region Private Methods
        //private Methods
        private void PlcValuesChange(object sender, EventArgs e)
        {
            Plc = new Plc(CpuType, Ip, Port, Rack, Slot);
        }
        private void GuvenlikTagThreadStart()
        {
            Thread.Sleep(500);
            Stopwatch sw = new Stopwatch();
            while (!ServerAborting)
            {
                try
                {
                    if (!Mut.WaitOne())
                        return;
                    sw.Restart();
                    if (!Plc.IsConnected)
                    {
                        Bagli = false;
                        Plc.OpenAsync().Wait(2000);
                        Bagli = Plc.IsConnected;
                    }
                    else
                    {
                        var task1489 = Plc.ReadAsync(DataTipi, Db, BaslangicByteAdresi, VarType.Int, 1);
                        task1489.Wait(3000);
                        if (!task1489.IsCompleted)
                        {
                            Bagli = false;
                            Plc.Close();
                        }
                        else Bagli = (Int16)task1489.Result == (Int16)Sifre;
                    }
                }
                catch (Exception ex)
                {
                    Bagli = false;
                    Plc.Close();
                    if (ex.InnerException is SocketException exInner)
                    {
                        if (exInner.ErrorCode == 10065) Thread.Sleep(2031);
                    }
                }
                finally
                {
                    sw.Stop();
                    int BeklenmesiGerekenSure = this.TaramaSuresi - (int)sw.ElapsedMilliseconds;
                    Mut.ReleaseMutex();
                    Thread.Sleep(BeklenmesiGerekenSure < 10 ? 100 : BeklenmesiGerekenSure);
                }
            }
        }

        private Task TagOku(TagList taglist)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(800);
                Stopwatch sw = new Stopwatch();
                int zaman = taglist.Time;
                while (!ServerAborting)
                {
                    try
                    {
                        this.Mut.WaitOne();
                        sw.Reset();
                        sw.Start();
                        if (!taglist.EnableTimer || !this.Bagli)
                            continue;
                        ListeDegerOku(taglist.Tags
                            .Where(T => T.Readable && (T.FormGozukmeseDeOku || T.ContainerFormVisible)).ToList());
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        sw.Stop();
                        Mut.ReleaseMutex();
                        int waittime = zaman - (int)sw.ElapsedMilliseconds;
                        Thread.Sleep(waittime < 3 ? 10 : waittime);
                    }
                }
                return Task.CompletedTask;
            });
        }

        private int ByteLentghOfVarType(Tag tag)
        {
            switch (tag.DegiskenTipi)
            {
                case VarType.Bit:
                    return (7 + tag.VarCount) / 8;
                case VarType.Byte:
                    return (tag.VarCount < 1) ? 1 : tag.VarCount;
                case VarType.Word:
                case VarType.Int:
                case VarType.Counter://???
                case VarType.Timer://????
                    return 2 * tag.VarCount;
                case VarType.DInt:
                case VarType.Real:
                case VarType.DWord:
                    return 4 * tag.VarCount;
                case VarType.LReal:
                case VarType.DateTime:
                    return 8 * tag.VarCount;
                case VarType.DateTimeLong:
                    return tag.VarCount * 8;
                case VarType.S7String:
                    return ((tag.VarCount + 2) & 1) == 1 ? (tag.VarCount + 3) : (tag.VarCount + 2);
                case VarType.S7WString:
                    return 4 + 2 * tag.VarCount;
                default:
                    return tag.VarCount * 8;
            }
        }
        public void ListeDegerOku(List<Tag> liste)
        {
            try
            {
                foreach (IGrouping<VarType, Tag> grouping in liste.GroupBy(t=>t.DegiskenTipi))
                {
                    int i = 0;
                    int last = 0;
                    int sum = 19;
                    var _list = grouping.ToList();
                    while ( last < _list.Count)
                    {
                        int val = ByteLentghOfVarType(_list[last]);
                        val = val > 12 ? val : 12;
                        if (sum + val> this.Plc.MaxPDUSize)
                        {
                            Listedegeroku(_list.GetRange(i, last - i), this.Plc);
                            i = last;
                            sum = 19;
                        }
                        else
                        {
                            sum += val;
                            last++;
                        }
                    }
                    Listedegeroku(_list.GetRange(i, last - i), this.Plc);
                }
                //if (liste.Count <= 2)
                //{
                //    Listedegeroku(liste, this.Plc);
                //    Thread.Sleep(1);
                //}
                //else
                //{
                //    var ilk5 = liste.Take(2);
                //    var ilk5Haric = liste.Except(ilk5);
                //    ListeDegerOku(ilk5Haric.ToList());
                //    Listedegeroku(ilk5.ToList(), this.Plc);
                //}
                foreach (Tag tag in liste)
                    tag.SenkronizeEt();
            }
            catch (Exception)
            {
                foreach (Tag tag in liste)
                    if (tag.Item.Value != null)
                        tag.SenkronizeEt();
            }
        }

        private void Listedegeroku(List<Tag> liste,
            S7.Net.Plc plc)
        {
            try
            {
                if (liste.First().DegiskenTipi == VarType.S7WString)
                {

                }


                Task readmultiple = plc.ReadMultipleVarsAsync(liste.Select(x => x.Item)
                    .ToList());
                readmultiple.Wait(1000);
            }
            catch (Exception ex)
            {
            
            }
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            PlcValuesChangeEventHandler += PlcValuesChange;
            PlcValuesChange(this, EventArgs.Empty);
            GuvenlikTagThread = new Thread(GuvenlikTagThreadStart);
            GuvenlikTagThread.Start();
        }
        private void Frm_Closed(object sender, EventArgs e)
        {
            ServerAborting = true;
        }
        private void PlcServer_BaglantiDurumuChangeEvetHandler(object sender, EventArgs e)
        {
            bool baglanti = (bool) (sender ?? false);

            //if (baglanti)
            //{
            //    foreach (Tag tag in Taglists.SelectMany(t => t.Tags))
            //    {
            //        bool temp = tag.DataBaseIleSenkronizeEt;
            //        tag.DataBaseIleSenkronizeEt = false;
            //        tag.OnValueChanged(tag);
            //        tag.DataBaseIleSenkronizeEt = temp;
            //    }

            //}
            //else
            //{
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(500);
            //        foreach (Tag tag in Taglists.SelectMany(t => t.Tags))
            //        {
            //            bool temp = tag.DataBaseIleSenkronizeEt;
            //            tag.DataBaseIleSenkronizeEt = false;

            //            if (tag.Value == null)
            //                tag.OnValueChanged(tag);
            //            tag.Value = null;

            //            tag.DataBaseIleSenkronizeEt = temp;
            //        }
            //    });
            //}

        }
        #endregion

        #region Public Methods

        //public Methods
        public TagList ListeyeTagEkle(Tag c)
        {
            int timer = (int) c.TaramaSuresi;

            TagList HedefListe = Taglists.SingleOrDefault(l => l.Time == timer);

            if (HedefListe is null)//???
            {
                HedefListe = new TagList() {EnableTimer = true, Tags = new List<Tag>() {c}, Time = timer};
                Taglists.Add(HedefListe);
                TagOku(HedefListe);
            }
            else if (HedefListe.Tags.All(t => t != c))
                HedefListe.Tags.Add(c);
            
            return HedefListe;
        }
        public override ISite Site
        {
            get { return base.Site; }
            set
            {
                base.Site = value;
                if (value == null)
                {
                    return;
                }

                IDesignerHost host = value.GetService(
                    typeof(IDesignerHost)) as IDesignerHost;
                if (host != null)
                {
                    IComponent componentHost = host.RootComponent;
                    if (componentHost is ContainerControl)
                    {
                        ContainerControl = componentHost as ContainerControl;
                    }
                }
            }
        }
        #endregion

        #region Private Fields

        //private fields
        private bool? bagli = null;

        private CpuType cputype = CpuType.S71200;

        private string ip = "192.168.2.1";

        private int port = 102;

        private short rack = 0;

        private short slot = 1;

        private int _taramaSuresi = 50;

        private List<TagList> Taglists = new List<TagList>();

        private ContainerControl _containerControl = null;

        private bool ServerAborting = false;

        #endregion

        #region Public Fields

        //public fields
        public Plc Plc;
        public Thread GuvenlikTagThread;
        public Mutex Mut = new Mutex();
        #endregion

        #region Properties

        //properties
        [Browsable(false)]
        public bool Bagli
        {
            get => (bagli ?? false);
            set
            {
                if (value != bagli)
                {
                    bagli = value;
                    BaglantiDurumuChangeEvetHandler?.Invoke(value, EventArgs.Empty);
                }
            }
        }
        #region Plc Türü Değerleri
        [Category("Plc Ayarları")]
        public CpuType CpuType
        {
            get => cputype;
            set
            {
                if (value != cputype)
                {
                    cputype = value;
                    PlcValuesChangeEventHandler?.Invoke(this,EventArgs.Empty);
                }
            }
        }
        [Category("Plc Ayarları")]
        public string Ip
        {
            get => ip;
            set
            {
                if (value != ip)
                {
                    ip = value;
                    PlcValuesChangeEventHandler?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        [Category("Plc Ayarları")]
        public int Port
        {
            get => port;
            set
            {
                if (value != port)
                {
                    PlcValuesChangeEventHandler?.Invoke(this, EventArgs.Empty);
                    port = value;
                }
            }
        }
        [Category("Plc Ayarları")]
        public short Rack
        {
            get => rack;
            set
            {
                if (value != rack)
                {
                    rack = value;
                    PlcValuesChangeEventHandler?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        [Category("Plc Ayarları")]
        public short Slot
        {
            get => slot;
            set
            {
                if (value != slot)
                {
                    slot = value;
                    PlcValuesChangeEventHandler?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        #endregion
        #region Güvenlik Tagi Değerleri
        [Category("Güvenlik Tagi")]
        public int Sifre { get; set; }
        [Category("Güvenlik Tagi")]
        public DataType DataTipi { get; set; }
        [Category("Güvenlik Tagi")]
        public int Db { get; set; }
        [Category("Güvenlik Tagi")]
        public int BaslangicByteAdresi { get; set; }
        [Category("Güvenlik Tagi"),Description("Bağlantı Kontrol Sıklığı\n(5ms -1000ms)")]
        public int TaramaSuresi
        {
            get => _taramaSuresi;
            set =>
                _taramaSuresi = value < 5 ? 5 : value > 1000 ? 1000 : value;
        }
        #endregion
        public ContainerControl ContainerControl
        {
            get { return _containerControl; }
            set
            {
                if (_containerControl == null && value != null)
                {
                    if (value is Form frm)
                    {
                        frm.Load += ParentForm_Load;
                        frm.Closed += Frm_Closed;
                    }
                }
                _containerControl = value;
            }
        }

       

        #endregion
        //EventHandler
        private EventHandler PlcValuesChangeEventHandler;
        public event EventHandler BaglantiDurumuChangeEvetHandler;
    }
}
