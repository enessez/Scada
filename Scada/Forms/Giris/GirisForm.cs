using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scada.AnaSayfa;

namespace Scada
{
    public partial class GirisForm : Form
    {
        protected internal FormMain Main;
        private NormFeedDBDataset dataset;
        public GirisForm()
        {
            InitializeComponent();
        }

        public void InitializeAfterCreating()
        {
            Main.Kullanici.KullaniciTuruChanged += KullaniciTuruChanged;
            Main.Kullanici.KullaciAdiChanged += KullaciAdiChanged;
            KullaniciTuruChanged(Main.Kullanici.Kullanici_Turu,EventArgs.Empty);
            KullaciAdiChanged(Main.Kullanici.Kullanici_Adi,EventArgs.Empty);
        }

        private void KullaciAdiChanged(object sender, EventArgs e)
        {
            
        }

        private GirisForm_GirisMenusu f_girisMenusu;
        private GirisForm_KullaniciArayuzu f_kullaniciArayuzu;
        private void KullaniciTuruChanged(object sender, EventArgs e)
        {
            if (Main.Kullanici.Kullanici_Turu == User.UserTypes.Misafir)
            {
                f_girisMenusu = GirisForm_GirisMenusu.NewForm(this.Main, this.dataset);
                foreach (Control c in panel2.Controls)
                    c.Dispose();

                panel2.Controls.Clear();
                panel2.Controls.Add(f_girisMenusu);
                f_girisMenusu.Show();
                f_girisMenusu.GirisMenusuUsteAlindi();
            }
            else
            {

                f_kullaniciArayuzu = GirisForm_KullaniciArayuzu.NewForm(this, this.Main, this.dataset);
                foreach (Control c in panel2.Controls)
                    c.Dispose();
                panel2.Controls.Clear();
                panel2.Controls.Add(f_kullaniciArayuzu);
                f_kullaniciArayuzu.lbl_time.Text = String.Format("{0:t}", TimeSpan.FromSeconds(28800));
                f_kullaniciArayuzu.Show();
            }
        }
        public static GirisForm NewForm(FormMain main,NormFeedDBDataset dataset)
        {
            var ret = new GirisForm() { TopMost = false, TopLevel = false, Dock = DockStyle.Fill, Main = main };
            ret.dataset = dataset;
            ret.InitializeAfterCreating();
            ret.Main.Kullanici.GirisYap("admin",
                "0000");
            return ret;
        }
    } 
   
}
