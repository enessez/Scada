using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using S7.Net;
using S7.Net.Types;
using Scada.AnaSayfa;
using Byte = System.Byte;

namespace Scada
{
    public class Tag : Component
    {
        public Tag()
        {
          
        }

    
        #region Private Fields
        private object _value;
        private DataType datatipi = DataType.DataBlock;
        private VarType degiskenTipi = VarType.Bit;
        private int db = 1;
        private int varCount = 1;
        private byte bitAddrs = 0;
        private int baslangicByteAdresi = 0;
        private int taramaSuresi = 50;
        private PlcServer _server = null;
        private ContainerControl _containerControl = null;
        #endregion

        #region Properties

        //Properties
        [Browsable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object Value
        {
            get => _value; 
            set
            {
                if (value != null && _value != null) 
                {
                    if (value.GetHashCode() != _value.GetHashCode())
                    {
                        _value = value;
                        this.ContainerControl.Invoke(
                            (MethodInvoker) (() => ValueChanged?.Invoke(this, EventArgs.Empty)));
                    }
                }
                else if (_value != value)
                {
                    _value = value;
                    this.ContainerControl.Invoke(
                        (MethodInvoker) (() => ValueChanged?.Invoke(this, EventArgs.Empty)));
                }
                _value = value;
            }
        }

   
        [Browsable(true),Category("PlcTagBool Adresi")]
        public DataType Datatipi
        {
            get => datatipi;
            set
            {
                if (value != datatipi)
                {
                    datatipi = value;
                    TagAdresiChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        [Browsable(true), Category("PlcTagBool Adresi")]
        public VarType DegiskenTipi
        {
            get => degiskenTipi;
            set
            {
                if (value != degiskenTipi)
                {
                    if (value != VarType.Bit) BitAddrs = 0;
                    degiskenTipi = value;
                    TagAdresiChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        [Browsable(true), Category("PlcTagBool Adresi")]
        public int Db
        {
            get => db;
            set
            {
                if (value != db)
                {
                    db = value;
                    TagAdresiChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        [Browsable(true), Category("PlcTagBool Adresi")]
        public int VarCount
        {
            get => varCount;
            set
            {
                if (value != varCount)
                {
                    varCount = value;
                    TagAdresiChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        [Browsable(true), Category("PlcTagBool Adresi")]
        public int BaslangicByteAdresi
        {
            get => baslangicByteAdresi;
            set
            {
                if (value != baslangicByteAdresi)
                {
                    baslangicByteAdresi = value;
                    TagAdresiChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        [Browsable(true), Category("PlcTagBool Adresi")]
        public byte BitAddrs
        {
            get => bitAddrs;
            set
            {
                if (value != bitAddrs)
                {
                    if (degiskenTipi != VarType.Bit) value = 0;
                    bitAddrs = value;
                    TagAdresiChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        [Browsable(true),Category("Özellikler"),Description("Tagin okunma sıklığı\n(min:5ms)")]
        public int TaramaSuresi
        {
            get => taramaSuresi;
            set => taramaSuresi = value < 5 ? 5 : value;
        }

        [Browsable(true), Category("Özellikler")]
        public PlcServer Server
        {
            get => _server;
            set
            {
                if (value != _server)
                {
                    ServerChanging?.Invoke(this,EventArgs.Empty);
                    _server = value;
                    ServerChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    
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
                        frm.VisibleChanged += (sender, args) =>
                            this.ContainerFormVisible = ((Form) sender).Visible;
                        
                    }
                }
                _containerControl = value;
            }
        }

        [Browsable(true), Category("Özellikler")]
        public bool FormGozukmeseDeOku { get; set; } = false;

        public bool DataBaseIleSenkronizeEt { get; set; } = false;
        public bool ErrorTag { get; set; } = false;
        #endregion

        #region Public Fields
        public DataItem Item = new DataItem();
        public TagList mevcutTagList = null;
        public bool Readable = true;
        public User.UserTypes User;
        public bool YazmaIzni = true;
        public bool ContainerFormVisible = true;
        #endregion

        #region Private Methods
       
        private void Tag_TagAdresiChanged(object sender, EventArgs e)
        {
            Item.BitAdr = BitAddrs;
            Item.DB = Db;
            Item.Count = VarCount;
            Item.DataType = Datatipi;
            Item.StartByteAdr = BaslangicByteAdresi;
            Item.VarType = DegiskenTipi;
        }
        private void Tag_ServerChanged(object sender, EventArgs e)
        {
            if (mevcutTagList is null)
                mevcutTagList = Server.ListeyeTagEkle(this);


        }
        private void Tag_ServerChanging(object sender, EventArgs e)
        {
            mevcutTagList?.Tags.Remove(this);
        }
        private void Tag_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void ParentForm_Load(object sender, EventArgs e)
        {
            TagAdresiChanged += Tag_TagAdresiChanged;
            Tag_TagAdresiChanged(this, EventArgs.Empty);
            ServerChanged += Tag_ServerChanged;
            ServerChanging += Tag_ServerChanging;
            ValueChanged += Tag_ValueChanged;

            this._value = false;//silinecek

            bool senkronizeet = this.DataBaseIleSenkronizeEt;
            this.DataBaseIleSenkronizeEt = false;
            ValueChanged?.Invoke(this,EventArgs.Empty);// kaldırılabilir
            this.DataBaseIleSenkronizeEt = senkronizeet;

            if (this.Server != null)
                mevcutTagList = this.Server.ListeyeTagEkle(this);
        }
        #endregion

        #region Public Methods

        public void SenkronizeEt()
        {
            this.Value = this.Item.Value;
        }
        public void DegerOku()
        {
            try
            {
                if (!Server.Mut.WaitOne())
                    return;
                DataItem dataItem = this.Item;
                var task = this.Server.Plc.ReadAsync(dataItem.DataType, dataItem.DB, dataItem.StartByteAdr, dataItem.VarType, dataItem.Count,
                    dataItem.BitAdr);
                task.Wait(200);
                if (!task.IsCompleted)
                    this.Item.Value = this.Value = null;
                else
                {
                    this.Item.Value = task.Result; 
                    this.Value = task.Result;
                }

            }
            catch (Exception ) {
                this.Item.Value = this.Value = null;
            }
            finally{ Server.Mut.ReleaseMutex(); }
        }

        public void DegerYaz(object newdeger)
        {
            Task.Run(() =>
            {
                var temp = this.Value;
                try
                {
                    if (!Server.Mut.WaitOne())
                        return;
                    
                    var yaz = this.Server.Plc.WriteAsync(this.Item.DataType, Item.DB, Item.StartByteAdr, newdeger,
                        Item.VarType == VarType.Bit ? Item.BitAdr : -1);
                    yaz.Wait(800);
                    if (!yaz.IsCompleted)
                        this.Item.Value = temp;
                    else
                        this.Value = newdeger;
                }
                catch (Exception )
                {
                    this.Value = temp;
                }
                finally
                {
                    Server.Mut.ReleaseMutex();
                }
            }).Wait();
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

        public void OnValueChanged(object sender)
            =>
                ValueChanged?.Invoke(sender, EventArgs.Empty);

        public override string ToString()
        {
            return
                $"{this.Datatipi.ToString()}| DB:{this.Db} BaslangicByte: {this.BaslangicByteAdresi} VarType: {this.DegiskenTipi} Value: {this.Value}";
        }

        #endregion

        #region Events
        public event EventHandler TagAdresiChanged;
        public event EventHandler ServerChanged;
        public event EventHandler ServerChanging;
        public event EventHandler ValueChanged;
        #endregion
    }
}
