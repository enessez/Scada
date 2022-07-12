using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using S7.Net;
using Scada.Forms.AnaSayfa;
using Scada.Forms.ErrorLog;
using Timer = System.Threading.Timer;

namespace Scada
{
    public partial class FormMain 
    {
        public List<TagFormEsleme> errorTags;


        private void InitializeErrorTags()
        {
            errorTags = new List<TagFormEsleme>();
            for (int i = 0; i < 672; i++)
            {
                var tag = new Tag();
                tag.BaslangicByteAdresi = 3000 + i / 8;
                tag.BitAddrs = ((byte) (i % 8));
                tag.ContainerControl = this;
                tag.Datatipi = S7.Net.DataType.Memory;
                tag.Db = 1;
                tag.DegiskenTipi = S7.Net.VarType.Bit;
                tag.FormGozukmeseDeOku = true;
                tag.Server = this.plcServer1;
                tag.TaramaSuresi = 50;
                tag.VarCount = 1;
                errorTags.Add(new TagFormEsleme(tag, f_giris));
                tag.ValueChanged += ErrorDegerDegisti;
            }
            //
            HerhangiBirErrorDegisti(errorTags.Any(t => (bool)(t.Tag.Value ?? false)));

            ErrorDegisimTimer.Elapsed += ErrorDegisimTimerOnElapsed;
        }

        private void ErrorDegisimTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            lock (errorlist)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                ErrorDegisimTimer.Stop();
                var copy = new List<Tag>(errorlist);
                errorlist = new List<Tag>();
                if (!normFeedDBDataset1.tbl_ErrorTags.Any())
                    ErrorTagsTableAdapter.Fill(normFeedDBDataset1.tbl_ErrorTags);

                errorLogTableAdapter.Fill_Last1000Rows(normFeedDBDataset1.tbl_ErrorLog);

                var idler = copy.Select(DegisenTag =>
                {
                    var errorRow = normFeedDBDataset1.tbl_ErrorTags.FirstOrDefault(et =>
                        (int) et.Db == DegisenTag.Db && et.BitAddress == DegisenTag.BitAddrs &&
                         et.DataType == (int) DegisenTag.Datatipi &&
                         et.StartByteAddress == DegisenTag.BaslangicByteAdresi &&
                         et.VarType == (short) DegisenTag.DegiskenTipi);

                    return new
                    {
                        DegisenTag,
                        errorRow
                    };
                });

                var dbyeyazilacaklar = idler.Select(obj =>
                    new
                    {
                        obj.DegisenTag,
                        sondeger = normFeedDBDataset1.tbl_ErrorLog.OrderBy(log => log.Id).LastOrDefault(log =>
                            obj.errorRow != null && log.ErrorTag == obj.errorRow.Id),
                        errorRow = obj.errorRow
                    }).Where(obj =>
                    obj.sondeger is null || (bool) obj.DegisenTag.Value != obj.sondeger.ErrorDeger);


                    var command = new SqlCommand();
                    command.Connection = errorLogTableAdapter.Connection;
                    string komut =
                        $"INSERT INTO {normFeedDBDataset1.tbl_ErrorLog.TableName} ({normFeedDBDataset1.tbl_ErrorLog.ErrorTagColumn.ColumnName},{normFeedDBDataset1.tbl_ErrorLog.ErrorDegerColumn.ColumnName},[{normFeedDBDataset1.tbl_ErrorLog.UserColumn.ColumnName}]) VALUES ";

                    if (dbyeyazilacaklar.Any())
                    {
                        foreach (var variable in dbyeyazilacaklar)
                        {
                            komut +=
                                $" ({variable.errorRow.Id},{((bool) variable.DegisenTag.Value ? 1 : 0)},{Kullanici.kullaniciRow.Id}),";
                            //errorLogTableAdapter.InsertQuery(variable.errorRow.Id, (bool) variable.DegisenTag.Value,
                            //    Kullanici.kullaniciRow.Id);
                        }

                        komut = komut.TrimEnd(',');
                        command.CommandText = komut;
                        command.CommandTimeout = 150;
                        try
                        {
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exception)
                        {

                        }
                        finally
                        {
                            command.Connection.Close();
                            command.Dispose();
                        }
                    }

                    if (!(f_errorLog is null)) f_errorLog.LogDegisti?.Invoke(this, EventArgs.Empty);
                    sw.Stop();
            }

        }

        private bool _herhangiBirErrorVar = false;

        public bool HerhangiBirErrorVar
        {
            get => _herhangiBirErrorVar;
            set
            {
                if (_herhangiBirErrorVar != value)
                {
                    _herhangiBirErrorVar = value;
                    if (!this.InvokeRequired)
                        HerhangiBirErrorDegisti(value);
                    else
                        this.Invoke((MethodInvoker) (() => HerhangiBirErrorDegisti(value)));
                }
            }
        }

        void HerhangiBirErrorDegisti(bool deger)
        {
            btn_Error.Gorsel = deger ? global::Scada.Properties.Resources._8iE9 : global::Scada.Properties.Resources.Silo;
        }

        private System.Timers.Timer ErrorDegisimTimer = new System.Timers.Timer(150);
        private List<Tag> errorlist = new List<Tag>();
        public void ErrorDegerDegisti(object sender, EventArgs e)
        {
            var DegisenTag = (Tag)sender;
            if (DegisenTag?.Value is null) //?????
                return;
            if (!(bool)DegisenTag.Value) //DEğişen değer false ise sorgula
                HerhangiBirErrorVar = errorTags.Any(t => (bool)(t.Tag.Value ?? false));
            else //true ise
                HerhangiBirErrorVar = true;

            //Değişen tag null değil    
            errorlist.Add(DegisenTag);
            ErrorDegisimTimer.Stop();
            ErrorDegisimTimer.Start();
        }

        private void btn_Error_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Cast<object>().LastOrDefault() == f_errorLog)
            {
                //Belki Animasyon Eklenebilir
                return;
            }

            if (f_errorLog is null)
            {
                f_errorLog = new FormErrorLog(this,normFeedDBDataset1) { TopMost = false, TopLevel = false, Dock = DockStyle.Fill};
                f_errorLog.Load += AltFormlarLoad;
            }
            panel2.Controls.Clear();
            panel2.Controls.Add(f_errorLog);
            f_errorLog.Show();
            f_errorLog.FormAcildi();
        }

    }
}
