using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scada.AnaSayfa;
using Scada.Forms.Giris;

namespace Scada
{
    public partial class GirisForm_KullaniciArayuzu : Form
    {
        private NormFeedDBDataset dataset;
        private GirisForm girisform;
        public GirisForm_KullaniciArayuzu(GirisForm _girisForm)
        {
            InitializeComponent();
            listBox1.BackColor = listBox2.BackColor = this.BackColor;
            this.girisform = _girisForm;
        }

        void InitializeForm()
        {
            Main.Kullanici.KullaciAdiChanged+= KullaciAdiChanged;
            Main.Kullanici.KullaniciTuruChanged += KullaniciTuruChanged;
            Main.Kullanici.SaniyeEvent += Kullanici_SaniyeEvent;
            KullaciAdiChanged(Main.Kullanici.Kullanici_Adi,EventArgs.Empty);
            KullaniciTuruChanged(Main.Kullanici.Kullanici_Turu,EventArgs.Empty);
            Kullanici_SaniyeEvent(0,EventArgs.Empty);
        }

        private void Kullanici_SaniyeEvent(object sender, EventArgs e)
        {
            int saniye = (int)sender;
            this.lbl_time.Text = String.Format("{0:t}", TimeSpan.FromSeconds(28800-saniye));
        }

        private void KullaniciTuruChanged(object sender, EventArgs e)
        {
            lbl_usertype.Text = sender.ToString();
        }

        private void KullaciAdiChanged(object sender, EventArgs e)
        {
            lbl_username.Text = (string) sender;
        }

        protected internal FormMain Main;
        private void GirisForm_KullaniciArayuzu_Load(object sender, EventArgs e)
        {
            FormGozuktu();
        }

        public void FormGozuktu()
        {
            Task.Run(() =>
            {
                Thread.Sleep(5);
                this.Invoke((MethodInvoker) (() =>
                {
                    var cevrimici = view_GirisCikisLogTableAdapter1.GetDataByUserSondurum(true);
                    var cevrimdisi = view_GirisCikisLogTableAdapter1.GetDataByUserSondurum(false);
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    if (cevrimici.Any())
                        listBox1.Items.AddRange(cevrimici.Select(c => c.KullaniciAdi).ToArray());
                    if (cevrimdisi.Any())
                        listBox2.Items.AddRange(cevrimdisi.Select(c => c.KullaniciAdi).ToArray());
                }));
            });

        }
        private void btn_CikisYap_Click(object sender, EventArgs e)
        {
            Main.Kullanici.CikisYap();
        }

        public static GirisForm_KullaniciArayuzu NewForm(GirisForm _girisform,FormMain main,NormFeedDBDataset dataset)
        {
            var yeni = new GirisForm_KullaniciArayuzu(_girisform) { TopMost = false, TopLevel = false, Dock = DockStyle.Fill, Main = main};
            yeni.InitializeForm();
            yeni.dataset = dataset;
            return yeni;
        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            using (SifreDegistir degistir = new SifreDegistir(this.Main.Kullanici))
            {
                degistir.KullaniciAdi = degistir.lbl_username.Text = Main.Kullanici.Kullanici_Adi;
                degistir.KullaniciTuru = Main.Kullanici.Kullanici_Turu;
                degistir.lbl_usertype.Text = degistir.KullaniciTuru.ToString();

                degistir.ShowDialog();
                degistir.Dispose();
                degistir.Hide();
                degistir.Close();
            }
    
            
        }

        private void GirisForm_KullaniciArayuzu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                FormGozuktu();
        }
    }
}
