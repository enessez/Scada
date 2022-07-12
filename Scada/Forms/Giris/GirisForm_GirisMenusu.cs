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
    public partial class GirisForm_GirisMenusu : Form
    {
        private NormFeedDBDataset dataset;
        public GirisForm_GirisMenusu()
        {
            InitializeComponent();
        }

        protected internal FormMain Main;
        private void BtnGirisYapClick(object sender, EventArgs e)
        {
            try
            {
                this.Main.Kullanici.GirisYap(this.textBox_Kullanici_Adi.textBox1.Text,
                    this.textBox_Sifre.textBox1.Text);
                label2.Focus();
            }
            catch (Exception exception)
            {
                if (exception.Message == "Kullanıcı Bulunamadı")
                    textBox_Kullanici_Adi.Focus();
                else textBox_Sifre.Focus();
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }

        public static GirisForm_GirisMenusu NewForm(FormMain main,NormFeedDBDataset dataset)
        {
            var yeni = new GirisForm_GirisMenusu() { TopMost = false, TopLevel = false, Dock = DockStyle.Fill, Main = main };
            yeni.dataset = dataset;
            return yeni;
        }

        private void textBox_Kullanici_Adi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_Sifre.Focus();
        }

        private void textBox_Sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_GirisYap.PerformClick();

        }

        public void GirisMenusuUsteAlindi()
        {
            this.textBox_Kullanici_Adi.Focus();
        }
    }
}
