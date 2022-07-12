using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scada.AnaSayfa;

namespace Scada.Forms.Giris
{
    public partial class SifreDegistir : Form
    {
        private User kullanici;
        public SifreDegistir(User _kullanici)
        {
            InitializeComponent();
            errorFlashTimer.Tick += ErrorFlashTimerOnTick;
            this.kullanici = _kullanici;
        }

        #region Cubuk

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        protected internal string KullaniciAdi;
        protected internal User.UserTypes KullaniciTuru;

        private bool _sifrelerFarkli = false;
        private Timer errorFlashTimer = new Timer() {Interval = 1200, Enabled = false};
        public bool SifrelerFarkli
        {
            get => _sifrelerFarkli;
            set
            {
                if (_sifrelerFarkli != value)
                {
                    _sifrelerFarkli = value;
                    SifreEslesmeDurumuChanged(value);
                }
            }
        }

        private Image tempimage;
        void SifreEslesmeDurumuChanged(bool val)
        {
            if (val) //sifreler eşleşmiyor ise
            {
                pictureBox1.Visible = true;
                btn_SifreDegistir.Enabled = false;
                if (tempimage != null)
                    pictureBox1.Image = tempimage;
                toolTip1.SetToolTip(pictureBox1,"Şifreler Eşleşmiyor");
                errorFlashTimer.Start();
            }
            else     //Eşleşiyor ise
            {
                errorFlashTimer.Stop();
                if (pictureBox1.Image != null)
                {
                    tempimage = pictureBox1.Image;
                    pictureBox1.Image = null;
                }
                toolTip1.SetToolTip(pictureBox1, "");
                btn_SifreDegistir.Enabled = true;
            }
        }

        private void ErrorFlashTimerOnTick(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null)
            {
                errorFlashTimer.Interval = 400;
                tempimage = pictureBox1.Image;
                pictureBox1.Image = null;
                
            }
            else
            {
                errorFlashTimer.Interval = 800;
                if (tempimage != null)
                    pictureBox1.Image = tempimage;
            }
        }
        private void SifreDegistir_Load(object sender, EventArgs e)
        {

        }

        private void SifreDegistir_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void customShapeButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            errorFlashTimer.Stop();
            this.Close();
        }

        private void formattedTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.textbox_YeniSifre.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void formattedTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.textbox_YeniSifre_tekrar.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyData == (Keys.Enter | Keys.Control))
            {
                this.textbox_EskiSifre.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void formattedTextbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                label1.Focus();
               btn_SifreDegistir.PerformClick();
               e.Handled = true;
               e.SuppressKeyPress = true;
            }
            else if(e.KeyData ==(Keys.Enter|Keys.Control))
            {
                this.textbox_YeniSifre.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void formattedTextbox3__TextChanged(object sender, EventArgs e)
        {
            SifrelerFarkli = textbox_YeniSifre_tekrar.Texts != textbox_YeniSifre.Texts;
         
        }

        private void formattedTextbox2__TextChanged(object sender, EventArgs e)
        {
            if (textbox_YeniSifre_tekrar.Texts != "") 
            {
                SifrelerFarkli = textbox_YeniSifre_tekrar.Texts != textbox_YeniSifre.Texts;
            }
            else if (textbox_YeniSifre.Texts == "")
            {
                SifrelerFarkli = false;
            }
           
        }

        private void formattedTextbox2_Leave(object sender, EventArgs e)
        {
            SifrelerFarkli = textbox_YeniSifre_tekrar.Texts != textbox_YeniSifre.Texts;
        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            if (textbox_YeniSifre.textBox1.Text != textbox_YeniSifre_tekrar.textBox1.Text)              //Şifreler Eşleşmiyor ise
            {
                MessageBox.Show("Şifreler Eşleşmiyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textbox_YeniSifre.textBox1.Text.Length >= 20) //yeni şifre 20den uzun veya 8den kısa ise
            {
                MessageBox.Show("Yeni şifre 20 karakterden uzun olamaz", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textbox_YeniSifre.textBox1.Text == "")
            {
                MessageBox.Show("Yeni şifre boş olamaz", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textbox_EskiSifre.textBox1.Text == textbox_YeniSifre.textBox1.Text)
            {
                MessageBox.Show("Eski şifre ile yeni şifre aynı olamaz", "HATA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (kullanici.SifreKontrol(textbox_EskiSifre.textBox1.Text))
            {
                if (kullanici.SifreDegistir(textbox_YeniSifre.textBox1.Text))
                {
                    MessageBox.Show("Şifre Değiştirme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Eski Şifre Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox_EskiSifre.Focus();
                return;
            }

        }
    }
}
