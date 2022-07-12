using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Scada.UI;

namespace Scada
{
    public partial class FormSilo : Form
    {
        protected internal FormMain main;
        private Thread gifilerlet;
        public FormSilo()
        {
            InitializeComponent();
            Initializepointers();
            timeBeginPeriod(timerAccuracy);

        }

        
        private const int timerAccuracy = 1;
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int msec);
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        public static extern int timeEndPeriod(int msec);
        private void pictureBoxButton1_Click(object sender, EventArgs e)
        {

        }

        private void FormSilo_Load(object sender, EventArgs e)
        {
            if (main != null)
            {
                //main.Kullanici.KullaniciTuruChanged += KullaniciTuruChanged;
                //KullaniciTuruChanged(main.Kullanici.Kullanici_Turu, EventArgs.Empty);
                foreach (FieldInfo taginfo in this.GetType().GetFields(
                    BindingFlags.NonPublic |
                    BindingFlags.Instance).Where(f => f.FieldType == typeof(Tag)))
                {
                    Tag tag = (Tag)taginfo.GetValue(this);
                    tag.Server = main.plcServer1;
                }
                pictureBoxButton1_Click_1(this,EventArgs.Empty);
                pictureBoxButton9_Click(this,EventArgs.Empty);
                pictureBoxButton8_Click(this,EventArgs.Empty);
            }
            //gifilerlet.Start();
        }

        private void KullaniciTuruChanged(object sender, EventArgs e)
        {
            foreach (var field in this.GetType().GetFields().Where(f => f.FieldType == typeof(Tag)))
            {
                var tag = ((Tag)field.GetValue(this));
                tag.User = this.main.Kullanici.Kullanici_Turu;
            }
        }

        #region MyRegion

        private Point Elevator1_UstCikis;
        private Point Elevator1_UstCikis_Elek_UstGiris_ElevatorHiza;
        private Point Elevator1_UstCikis_Elek_UstGiris_ElekHiza;
        private Point Elek_UstGiris;

        private Point Elevator2_UstCikis;
        private Point Elevator2_UstCikis_HelezonUstGiris_AraNokta_ElevatorHiza;
        private Point Elevator2_UstCikis_HelezonUstGiris_AraNokta_HelezonHiza;
        private Point HelezonUstGiris;

        private Point Elevator2AltGiris;
        private Point ElekAlt_ElevatorAltAraNokta1;
        private Point ElekAlt_ElevatorAltAraNokta2;
        private Point ElekAltCikis;

        private Point HelezonOrtaCikis;
        private Point Dagitici2Giris;
        #endregion

        private void FormSilo_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Aqua, 2);
            if (cizim)
                e.Graphics.DrawLine(pen,
                    resimliPlcButon1.Location.X + resimliPlcButon1.Size.Width / 2,
                    resimliPlcButon1.Location.Y + resimliPlcButon1.Size.Height / 2,
                    pictureBoxButton1.Location.X + pictureBoxButton1.Size.Width / 2, pictureBoxButton1.Location.Y);

            e.Graphics.DrawLine(pen, Elevator2_UstCikis, Elevator2_UstCikis_HelezonUstGiris_AraNokta_ElevatorHiza);

            e.Graphics.DrawLine(pen, Elevator2_UstCikis_HelezonUstGiris_AraNokta_ElevatorHiza,
                Elevator2_UstCikis_HelezonUstGiris_AraNokta_HelezonHiza);

            e.Graphics.DrawLine(pen, Elevator2_UstCikis_HelezonUstGiris_AraNokta_HelezonHiza,
                HelezonUstGiris);

            e.Graphics.DrawLine(pen, Elevator1_UstCikis, Elevator1_UstCikis_Elek_UstGiris_ElevatorHiza);
            e.Graphics.DrawLine(pen, Elevator1_UstCikis_Elek_UstGiris_ElevatorHiza, Elevator1_UstCikis_Elek_UstGiris_ElekHiza);
            e.Graphics.DrawLine(pen, Elevator1_UstCikis_Elek_UstGiris_ElekHiza, Elek_UstGiris);

            e.Graphics.DrawLine(pen, ElekAltCikis, ElekAlt_ElevatorAltAraNokta1);
            e.Graphics.DrawLine(pen, ElekAlt_ElevatorAltAraNokta1, ElekAlt_ElevatorAltAraNokta2);
            e.Graphics.DrawLine(pen, ElekAlt_ElevatorAltAraNokta2, Elevator2AltGiris);

            e.Graphics.DrawLine(pen, HelezonOrtaCikis, Dagitici2Giris);
        }

        void Initializepointers()
        {
            Elevator2_UstCikis = new Point(pictureBoxButton23.Location.X +
                                           (int)((double)pictureBoxButton23.Size.Width * 0.85599056),
                pictureBoxButton23.Location.Y +
                (int)((double)pictureBoxButton23.Size.Height * 0.04057681159420289));

            HelezonUstGiris = new Point(resimliPlcButon1.Location.X +
                                        (int)((double)resimliPlcButon1.Size.Width * 0.034181761399125546),
                resimliPlcButon1.Location.Y);
            Elevator2_UstCikis_HelezonUstGiris_AraNokta_ElevatorHiza = new Point(Elevator2_UstCikis.X,
                Elevator2_UstCikis.Y + Math.Abs(resimliPlcButon1.Location.Y - Elevator2_UstCikis.Y) / 2);
            Elevator2_UstCikis_HelezonUstGiris_AraNokta_HelezonHiza = new Point(HelezonUstGiris.X,
                Elevator2_UstCikis.Y + Math.Abs(resimliPlcButon1.Location.Y - Elevator2_UstCikis.Y) / 2);


            Elevator1_UstCikis = new Point(pictureBoxButton22.Location.X +
                                           (int)((double)pictureBoxButton22.Size.Width * 0.85599056),
                pictureBoxButton22.Location.Y +
                (int)((double)pictureBoxButton22.Size.Height * 0.04057681159420289));

            Elek_UstGiris = new Point((int)(ElekBurron.Location.X + (double)ElekBurron.Size.Width * 0.163875262789067974772),
                ElekBurron.Location.Y);
            Elevator1_UstCikis_Elek_UstGiris_ElevatorHiza = new Point(Elevator1_UstCikis.X,
                Elevator1_UstCikis.Y + Math.Abs(Elevator1_UstCikis.Y - Elek_UstGiris.Y) / 2);
            Elevator1_UstCikis_Elek_UstGiris_ElekHiza =
                new Point(Elek_UstGiris.X, Elevator1_UstCikis_Elek_UstGiris_ElevatorHiza.Y);


            ElekAltCikis = new Point(ElekBurron.Location.X +
                                     (int)((double)ElekBurron.Size.Width * 0.6310791871058163980), ElekBurron.Location.Y + (int)((double)ElekBurron.Size.Height * 0.95726569217540842648));

            Elevator2AltGiris = new Point(pictureBoxButton23.Location.X + (int)((double)pictureBoxButton23.Size.Width * 0.143192488262910798122),
                pictureBoxButton23.Location.Y +
                (int)((double)pictureBoxButton23.Size.Height * 0.968800695249130938586));
            ElekAlt_ElevatorAltAraNokta1 = new Point(ElekAltCikis.X,
                ElekAltCikis.Y + 3 * Math.Abs(ElekAltCikis.Y - Elevator2AltGiris.Y) / 4);
            ElekAlt_ElevatorAltAraNokta2 = new Point(Elevator2AltGiris.X, ElekAlt_ElevatorAltAraNokta1.Y);

            HelezonOrtaCikis = new Point((int)(this.resimliPlcButon1.Location.X + (double)resimliPlcButon1.Size.Width * 0.57542161149281698), resimliPlcButon1.Location.Y + resimliPlcButon1.Size.Height);
            Dagitici2Giris = new Point(Dagitici2Button.Location.X + Dagitici2Button.Size.Width / 2, Dagitici2Button.Location.Y);
        }

        private bool cizim = false;
        private void pictureBoxButton1_Click_1(object sender, EventArgs e)
        {
            t_helezon1Value.Value = !(bool)(t_helezon1Value.Value ?? false);
            cizim = !cizim;
            this.Refresh();
        }

        private void pictureBoxButton2_Click(object sender, EventArgs e)
        {
            tag1.Value = !(bool)(tag1.Value ?? false);
        }

        private void pictureBoxButton22_Click(object sender, EventArgs e)
        {

        }

        private int a = 0;
        private void pictureBoxButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBoxButton9_Click(object sender, EventArgs e)
        {
            tag_FanDurum.Value = !(bool)(tag_FanDurum.Value ?? false);
        }

        private void pictureBoxButton5_Click(object sender, EventArgs e)
        {
            Tag_FanError.Value = !(bool)(Tag_FanError.Value ?? false);
        }

        private void pictureBoxButton8_Click(object sender, EventArgs e)
        {
            tag_ElekDurum.Value = !(bool)(tag_ElekDurum.Value ?? false);
        }

        private void pictureBoxButton7_Click(object sender, EventArgs e)
        {
            tag_ElekError.Value = !(bool)(tag_ElekError.Value ?? false);
        }

        private void resimliPlcButon2_Click(object sender, EventArgs e)
        {

        }

        private void FormSilo_VisibleChanged(object sender, EventArgs e)
        {
            //if (this.Visible) this.Refresh();
        }

    }
}
