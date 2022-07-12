using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using Scada.AnaSayfa;
using Timer = System.Timers.Timer;

namespace Scada.UI
{
    public class ResimliPlcButon : PictureBoxButton
    {
        //Constructor
        public ResimliPlcButon()
        {
            gecikmeTimer.Elapsed += GecikmeTimerElapsed;
            this.BackColor = Color.FromName("0");//??
            this.TabStop = false;
        }

    

        //private fields

        #region private fields
        private Tag _plcTagYazilacakBool;
        private Tag _plcTagBoolError;
        private Tag _plcTagOkunacakBool;
        private Image image1;
        private Image image2;
        private Image image3;
        private Timer gecikmeTimer = new Timer(400);
        private bool readable = true;
        private PlcServer _server = null;
        #endregion

        //properties

        #region properties

        public Image Image1
        {
            get => image1;
            set
            {
                image1 = this.Image = value;
                Invalidate();
            }
        }
        public Image Image1_Golge { get; set; }
        public Image Image2
        {
            get => image2;
            set => image2 = value;
        }
        public Image Image2_Golge { get; set; }
        public Image Image3
        {
            get => image3;
            set
            {
                image3 = value;
            }
        }
        public Image Image3_Golge { get; set; }

        [Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PlcServer Server
        {
            get => _server;
            set
            {
                if (_server != value && value !=null)
                {
                    value.BaglantiDurumuChangeEvetHandler += OnServerBaglantiDurumuChangeEvetHandler;
                }
                _server = value;
            }
        }

      

        public Tag PlcTagBoolError
        {
            get => _plcTagBoolError;
            set
            {
                if (value == _plcTagBoolError) return;
                if (value is null)
                {                       //eski tagden eventi silme
                    _plcTagBoolError = null;
                    return;
                }

                if (value.Server != null)
                    this.Server = value.Server;

                if (_plcTagBoolError != null)
                {
                    _plcTagBoolError.ValueChanged -= PlcTagOkunacakBoolOnBoolValueChanged;
                    _plcTagBoolError.ValueChanged -= PlcTagBoolErrorValueChanged;
                }

                _plcTagBoolError = value;
                _plcTagBoolError.ValueChanged += PlcTagBoolErrorValueChanged;
                _plcTagBoolError.ValueChanged += PlcTagOkunacakBoolOnBoolValueChanged;
                Invalidate();
            }
        }
        public Tag PlcTagYazilacakBool
        {
            get => _plcTagYazilacakBool;
            set
            {
                if (value == _plcTagYazilacakBool) return;
                if (value is null)
                {                       //eski tagden eventi silme
                    _plcTagYazilacakBool = null;
                    return;
                }
                if (value.Server != null)
                    this.Server = value.Server;

                if (_plcTagYazilacakBool != null)
                    _plcTagYazilacakBool.ValueChanged -= PlcTagYazilacakBoolOnBoolValueChanged;

                _plcTagYazilacakBool = value;
                _plcTagYazilacakBool.ValueChanged += PlcTagYazilacakBoolOnBoolValueChanged;

                Invalidate();
            }
        }
        public Tag PlcTagOkunacakBool
        {
            get => _plcTagOkunacakBool;
            set
            {
                if (value == _plcTagOkunacakBool) return;
                if (value is null)
                {                       //eski tagden eventi silme
                    _plcTagOkunacakBool = null;
                    return;
                }

                if (value.Server != null)
                    this.Server = value.Server;

                if (_plcTagOkunacakBool != null)
                    _plcTagOkunacakBool.ValueChanged -= PlcTagOkunacakBoolOnBoolValueChanged;

                _plcTagOkunacakBool = value;
                _plcTagOkunacakBool.ValueChanged += PlcTagOkunacakBoolOnBoolValueChanged;

                Invalidate();
            }
        }
        //[Browsable(false),
        // DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public User.UserTypes Yetki { get; set; }
        //[Browsable(false),
        // DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public bool Tiklanabilir { get; set; } = true;
        #endregion

        //private methods
        #region Private Methods
        private void PlcTagYazilacakBoolOnBoolValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (PlcTagOkunacakBool != null || PlcTagYazilacakBool is null) return;
                if (!readable)
                {
                    Task.Run(() =>
                    {
                        do
                        {
                            Thread.Sleep(10);
                        } while (!this.readable);

                        this.Invoke((MethodInvoker)(() =>
                            PlcTagYazilacakBoolOnBoolValueChanged(this.PlcTagYazilacakBool.Value, EventArgs.Empty)));
                    });
                    return;
                }
                bool yenideger;
                if (((Tag)sender).Value is null) //okuyamadıysa
                    yenideger = false;
                else if (((Tag)sender).Value is bool)
                    yenideger = (bool)((Tag)sender).Value;
                else yenideger = false;

                this.Gorsel = (bool)((PlcTagBoolError is null ? false : PlcTagBoolError.Value) ?? true) ? Image3 : yenideger ? Image1 : Image2;
                this.ImageOverMouse = (bool)((PlcTagBoolError is null ? false : PlcTagBoolError.Value) ?? true) ? Image3_Golge : yenideger ? Image1_Golge : Image2_Golge;
                this.Invalidate();

            }
            catch (Exception)
            {
                
            }
        }
        private void PlcTagOkunacakBoolOnBoolValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (PlcTagOkunacakBool is null) return;
                if (!readable)
                {
                    Task.Run(() =>
                    {
                        do
                        {
                            Thread.Sleep(10);
                        } while (!this.readable);

                        this.Invoke((MethodInvoker)(() =>
                            PlcTagOkunacakBoolOnBoolValueChanged(this.PlcTagYazilacakBool.Value, EventArgs.Empty)));
                    });
                    return;
                }
                bool yenideger;
                if (((Tag)sender).Value is null)            //okuyamadıysa
                    return;
                else if (((Tag)sender).Value is bool)
                    yenideger = (bool)((Tag)sender).Value;
                else yenideger = false;

                this.Gorsel = (bool)((PlcTagBoolError is null ? false : PlcTagBoolError.Value) ?? true) ? Image3 : yenideger ? Image1 : Image2;
                this.ImageOverMouse = (bool)((PlcTagBoolError is null ? false : PlcTagBoolError.Value) ?? true) ? Image3_Golge : yenideger ? Image1_Golge : Image2_Golge;
                this.Invalidate();
            }
            catch (Exception)
            {

            }
        }
        private void PlcTagBoolErrorValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!readable)
                {
                    Task.Run(() =>
                    {
                        do
                        {
                            Thread.Sleep(10);
                        } while (!this.readable);

                        this.Invoke((MethodInvoker) (() =>
                            PlcTagBoolErrorValueChanged(this.PlcTagYazilacakBool.Value, EventArgs.Empty)));
                    });
                    return;
                }

                bool yenideger = (bool) (((Tag)sender).Value ?? true);

                this.Gorsel = yenideger ? Image3 :
                    PlcTagOkunacakBool is null ? (bool) (PlcTagYazilacakBool.Value ?? false) ? Image1 : Image2 :
                    (bool) (PlcTagOkunacakBool.Value ?? false) ? Image1 : Image2;

                this.ImageOverMouse = yenideger ? Image3_Golge :
                    PlcTagOkunacakBool is null ? (bool) (PlcTagYazilacakBool.Value ?? false) ? Image1_Golge :
                    Image2_Golge :
                    (bool) (PlcTagOkunacakBool.Value ?? false) ? Image1_Golge : Image2_Golge;
                this.Invalidate();
            }
            catch (Exception)
            {
                
            }
        }

        private void GecikmeTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.PlcTagYazilacakBool.Readable = this.readable = true;
            gecikmeTimer.Stop();
        }
        private void OnServerBaglantiDurumuChangeEvetHandler(object sender, EventArgs e)
        {
         
        }
        //private Color TiklananNoktaColor(EventArgs e)
        //{
        //    MouseEventArgs _e = (MouseEventArgs)e;
        //    //Bitmap b = this.ImageTiklamaMaskesi is null
        //    //    ? new Bitmap(this.ClientSize.Width, this.Height)
        //    //    : new Bitmap(ImageTiklamaMaskesi);
        //    Bitmap b = new Bitmap(this.ClientSize.Width, this.Height);
        //    this.DrawToBitmap(b, this.ClientRectangle);
        //    b.MakeTransparent();
        //    Color colour = b.GetPixel(_e.X, _e.Y);
        //    this.Size = b.Size;
        //    b.Dispose();
        //    return colour;
        //}
        #endregion
        //override
        #region Override

        protected override void OnClick(EventArgs e)
        {
            if (!this.mouseuzerindemi) return;

            bool HataAyiklamaSarti = this.readable && this.PlcTagYazilacakBool.Readable && this.PlcTagYazilacakBool.Server.Bagli &&
                                     ((this.PlcTagBoolError != null &&
                                       (bool)(this.PlcTagBoolError.Value ?? true) == false) ||
                                      this.PlcTagBoolError is null);
            if ((this.PlcTagYazilacakBool.User != User.UserTypes.Admin && HataAyiklamaSarti && PlcTagYazilacakBool.YazmaIzni) ||
                (this.PlcTagYazilacakBool.User == User.UserTypes.Admin && HataAyiklamaSarti))
            {
                object yenideger =
                    !(bool)(PlcTagYazilacakBool.Value ?? false);

                this.PlcTagYazilacakBool.Value = yenideger;
                this.PlcTagYazilacakBool.Readable = this.readable = false;
                gecikmeTimer.Stop();
                gecikmeTimer.Start();
                Task.Run(() => PlcTagYazilacakBool.DegerYaz(yenideger));

            }
            base.OnClick(EventArgs.Empty);
        }
        [Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get; set; }= Color.Transparent;

        protected override void OnCreateControl()
        {
            PlcTagOkunacakBoolOnBoolValueChanged(this.PlcTagOkunacakBool, EventArgs.Empty);
            PlcTagYazilacakBoolOnBoolValueChanged(this.PlcTagYazilacakBool, EventArgs.Empty);
            base.OnCreateControl();
        }

        #endregion
    }
}
