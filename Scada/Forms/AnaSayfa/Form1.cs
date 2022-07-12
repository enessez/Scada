using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scada;
using Scada.AnaSayfa;
using Scada.Forms.AnaSayfa;
using Scada.Forms.ErrorLog;
using Scada.Forms.LogForms;
using Scada.Forms.TestForms;

namespace Scada
{
    public partial class FormMain : Form
    {
        #region Esc
        void gmh_TheMouseMoved()
        {
            //Point cur_pos = System.Windows.Forms.Cursor.Position;                   Mouse ile menü kaydırma
            //if (cur_pos.Y >= 1060)
            //{
            //    this.SuspendLayout();
            //    tableLayoutPanel2.Height = 80;
            //    this.ResumeLayout();
            //}
            //if (cur_pos.Y < 1000)
            //{
            //    tableLayoutPanel2.Height = 20;

            //}

        }
        [DllImport("user32.dll")]
        public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);
        private void panel1_Load(object sender, EventArgs e)
        {

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F11)
            {
                this.WindowState = this.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Minimized
                    : FormWindowState.Maximized;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void panel1_Deactivate(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }


        #endregion
        public FormMain()
        {
            //Esc'ye basma ayarları
            GlobalMouseHandler gmh = new GlobalMouseHandler();
            gmh.TheMouseMoved += new MouseMovedEvent(gmh_TheMouseMoved);
            Application.AddMessageFilter(gmh);
            /////////////////////////////////
            InitializeComponent();

            /// Database hata vermesin diye
            if (f_silo is null)
            {
                f_silo = new FormSilo() { TopMost = false, TopLevel = false, Dock = DockStyle.Fill, main = this };
                f_silo.Load += AltFormlarLoad;
            }

            panel2.Controls.Clear();
            f_silo.Show();
            panel2.Controls.Add(f_silo);
            return;
            ///  Database hata vermesin diye
            Kullanici = new User(this.normFeedDBDataset1,this);

            //Buton ayarları
            menuButtonForms[0] = customShapeButton0;
            menuButtonForms[1] = customShapeButton1;
            menuButtonForms[2] = customShapeButton2;
            menuButtonForms[3] = customShapeButton3;
            menuButtonForms[4] = customShapeButton4;
            menuButtonForms[5] = customShapeButton5;
            menuButtonForms[6] = customShapeButton6;
            menuButtonForms[7] = customShapeButton7;
            menuButtonForms[8] = customShapeButton8;
            menuButtonForms[9] = customShapeButton9;
            foreach (CustomShapeButton button in menuButtonForms)
                button.Click += ButtonRenkDegisimi;
            btn_Error.Click += ButtonRenkDegisimi;
            pictureBoxButton1.Click += ButtonRenkDegisimi;
            //////////////////////////////////////
            Kullanici.KullaniciTuruChanged += Kullanici_KullaniciTuruChanged;
            Kullanici.KullaniciTuruChanged.Invoke(Kullanici.Kullanici_Turu,EventArgs.Empty);

            InitializeErrorTags();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            return;//////////////
            pictureBox1_Click(sender, e);
            AcilanButton(pictureBoxButton1);
        }

        private void Kullanici_KullaniciTuruChanged(object sender, EventArgs e)
        {
            User.UserTypes uType = (User.UserTypes) sender;
            foreach (CustomShapeButton button in menuButtonForms)
            {
                button.Enabled = uType == User.UserTypes.Misafir ? false : true;
            }
            switch (uType)
            {
                case User.UserTypes.Admin:

                    break;

                case User.UserTypes.Misafir:
                    pictureBox1_Click(pictureBoxButton1, EventArgs.Empty);
                    break;

                case User.UserTypes.Operator:

                    break;

                case User.UserTypes.Yonetici:

                    break;
            }
        }

        #region Public Fields

        public User Kullanici;
        

        #endregion

        #region Private Fields
        private GirisForm f_giris;
        private FormRecete f_recete;
        private FormSilo f_silo;
        private FormErrorLog f_errorLog;
        private KullaniciGirisCikisForm f_kullaniciGirisCikislogForm;
        private memorysForm f_memorytestform;
        private CustomShapeButton[] menuButtonForms = new CustomShapeButton[10];

        #endregion


        #region ButonClick

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (f_giris is null)
            {
                f_giris = GirisForm.NewForm(this, this.normFeedDBDataset1);
                f_giris.Load += AltFormlarLoad;
            }
            if (panel2.Controls.Cast<object>().LastOrDefault() == f_giris)
            {
                //Belki Animasyon Eklenebilir
                return;
            }

            foreach (Control c in panel2.Controls)
            {
                c.Hide();
            }
            panel2.Controls.Clear();
            f_giris.Show();
            panel2.Controls.Add(f_giris);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Cast<object>().Last() == f_recete)
            {
                //Belki Animasyon Eklenebilir
                return;
            }

            if (f_recete is null)
            {
                f_recete = new FormRecete() { TopMost = false, TopLevel = false, Dock = DockStyle.Fill };
                f_recete.Load += AltFormlarLoad;
            }
            foreach (Control c in panel2.Controls)
            {
                c.Hide();
            }
            panel2.Controls.Clear();
            f_recete.Show();
            panel2.Controls.Add(f_recete);

        }

        private void customShapeButton1_Click(object sender, EventArgs e)
        {
            if (f_memorytestform is null)
            {
                f_memorytestform = new memorysForm(this) { TopMost = false, TopLevel = false, Dock = DockStyle.Fill ,FormBorderStyle = FormBorderStyle.None};
            }
            if (panel2.Controls.Cast<object>().LastOrDefault() == f_memorytestform)
            {
                //Belki Animasyon Eklenebilir
                return;
            }

            panel2.Controls.Clear();
            f_memorytestform.Show();
            panel2.Controls.Add(f_memorytestform);
        }
        
        private void customShapeButton2_Click(object sender, EventArgs e)
        {
            if (f_silo is null)
            {
                f_silo = new FormSilo() { TopMost = false, TopLevel = false, Dock = DockStyle.Fill, main = this };
                f_silo.Load += AltFormlarLoad;
            }
            if (panel2.Controls.Cast<object>().Last() == f_silo)
            {
                //Belki Animasyon Eklenebilir
                return;
            }

            panel2.Controls.Clear();
            f_silo.Show();
            panel2.Controls.Add(f_silo);
        }
        
        private void customShapeButton9_Click(object sender, EventArgs e)
        {
            errorTags[0].Tag.Value = !(bool)(errorTags[0].Tag.Value ?? false);
        }

        private void customShapeButton7_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Cast<object>().Last() == f_kullaniciGirisCikislogForm)
            {
                //Belki Animasyon Eklenebilir
                return;
            }

            if (f_kullaniciGirisCikislogForm is null)
            {
                f_kullaniciGirisCikislogForm = new KullaniciGirisCikisForm(this) { TopMost = false, TopLevel = false, Dock = DockStyle.Fill };
            }
            panel2.Controls.Clear();
            panel2.Controls.Add(f_kullaniciGirisCikislogForm);
            f_kullaniciGirisCikislogForm.Show();
            f_kullaniciGirisCikislogForm.FormAcildi();
        }

        private void customShapeButton8_Click(object sender, EventArgs e)
        {
            errorTags[1].Tag.Value = !(bool)errorTags[1].Tag.Value;
        }

        #endregion



        private void AltFormlarLoad(object sender, EventArgs e)
        {
            var ErrorTags = sender.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(p => p.GetType() == typeof(Tag)).Select(f => (Tag) f.GetValue(sender)).Where(t => t.ErrorTag);

        }

     
     

        void AcilanButton(Control buton1)
        {

            if (buton1 == pictureBoxButton1)
            {
                pictureBoxButton1.Gorsel = Scada.Properties.Resources.icons8_user_shield_48px_1; 
                pictureBoxButton1.ImageOverMouse = Scada.Properties.Resources.icons8_user_shield_48px;
                foreach (var menuButtonForm in menuButtonForms)
                    menuButtonForm.BackColor = Color.FromArgb(176, 0, 32);
            }
            else if (buton1 is CustomShapeButton buton)
            {
                pictureBoxButton1.BackColor = Color.Empty;
                foreach (var menuButtonForm in menuButtonForms)
                {
                    if (menuButtonForm == null) continue;
                    menuButtonForm.BackColor = menuButtonForm == buton ? Color.FromArgb(173, 217, 255) : Color.FromArgb(176, 0, 32);
                }
                pictureBoxButton1.Gorsel = Scada.Properties.Resources.icons8_user_shield_48px;
                pictureBoxButton1.ImageOverMouse = Scada.Properties.Resources.icons8_user_shield_48px_1;
            }
            else if (buton1 == btn_Error)
            {
                foreach (var menuButtonForm in menuButtonForms)
                    menuButtonForm.BackColor = Color.FromArgb(176, 0, 32);
                pictureBoxButton1.Gorsel = Scada.Properties.Resources.icons8_user_shield_48px;
                pictureBoxButton1.ImageOverMouse = Scada.Properties.Resources.icons8_user_shield_48px_1;
            }

        }
     

        private void ButtonRenkDegisimi(object sender, EventArgs e)
        {
            pictureBoxButton1.Focus();
            AcilanButton((Control)sender);
        }

    }

    #region EscDevam
    public delegate void MouseMovedEvent();

    public class GlobalMouseHandler : IMessageFilter
    {
        private const int WM_MOUSEMOVE = 0x0200;

        public event MouseMovedEvent TheMouseMoved;

        #region IMessageFilter Members

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE)
            {
                if (TheMouseMoved != null)
                {
                    TheMouseMoved();
                }
            }
            // Always allow message to continue to the next filter control
            return false;
        }

        #endregion
    }
    #endregion

}
