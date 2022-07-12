using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace Scada.UI
{
    public class PictureBoxButton : PictureBox
    {
        private void golgeChanged(bool value)
        {
            if (value)
                this.Image = ImageOverMouse;
            else if (Gorsel != null)
                this.Image = Gorsel;
            this.Invalidate();
        }
        private bool _golgeli = false;
        private Image _gorsel;

        public Image Gorsel
        {
            get => _gorsel;
            set
            {
                if (value!=_gorsel)
                {
                    _gorsel = value;
                    this.Image = value;
                }
            }
        }
        public Image GorselMaske { get; set; }
        public bool Golgeli
        {
            get => _golgeli;
            set
            {
                if (_golgeli != value && !tikli && ImageOverMouse !=null) 
                {
                   golgeChanged(value);
                   _golgeli = value;
                }
            }
        }
        private bool _onOverButton = false;

        public bool OnOverButton
        {
            get => _onOverButton;
            set
            {
                _onOverButton = value;
                if (value)
                {
                    this.Image = ImageOverMouse;
                }
                else if (Gorsel != null)
                    this.Image = this.Gorsel;
            }
        }

        private Image _imageovermouse;

        public Image ImageOverMouse
        {
            get => _imageovermouse;
            set
            {
                _imageovermouse = value;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (ImageOverMouse is null)
            {
                var color = TiklananNoktaColor(new MouseEventArgs(MouseButtons.Left, 1, x, y, 1));
                mouseuzerindemi = color.Name != "0";
            }
            if (mouseuzerindemi)
                base.OnClick(e);
        }

        protected bool mouseuzerindemi = false;
        private int x;
        private int y;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (ImageOverMouse is null)
            {
                x = e.X;
                y = e.Y;
                return;
            }
            var color = TiklananNoktaColor(e);
            mouseuzerindemi = color.Name != "0";
            Golgeli = mouseuzerindemi;
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Golgeli = false;
            base.OnMouseLeave(e);
        }

        private bool tikli = false;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(!mouseuzerindemi)
                return;
            
            base.OnMouseDown(e);
            Golgeli = !Golgeli;
            tikli = true;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            tikli = false;
            Golgeli = false;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

      
        private Color TiklananNoktaColor(EventArgs e)
        {
            try
            {
                MouseEventArgs _e = (MouseEventArgs)e;
                //Bitmap b = new Bitmap(this.ClientSize.Width, this.Height);
                //this.DrawToBitmap(b, this.ClientRectangle);
                //b.MakeTransparent();
                Bitmap b = new Bitmap((this.GorselMaske ?? this.Gorsel) ?? this.Image);
                b.MakeTransparent();
                Color c=Color.Transparent;
                if (this.SizeMode == PictureBoxSizeMode.StretchImage)
                {
                    double k_y = (double)b.Height / this.Height;
                    double k_x = (double)b.Width / this.Size.Width;
                    c = b.GetPixel((int) ((double) k_x * _e.X), (int) ((double) k_y * _e.Y));
                }
                else if (this.SizeMode == PictureBoxSizeMode.Zoom)
                {
                    double o_c = (double) this.Width / this.Height;
                    double o_b = (double) b.Width / b.Height;
                    if (o_c > o_b)
                    {
                        double k1= (double) b.Height / this.Height;
                        int imaj_x = (int) ((double) b.Width / k1);
                        int bosluk = (this.Width - imaj_x) / 2;
                        if (_e.X >= bosluk && _e.X <= this.Width - bosluk)
                        {
                            c = b.GetPixel((int) ((double) (_e.X - bosluk) * k1), (int) ((double) (_e.Y) * k1));
                        }
                        else
                        {
                            c = Color.FromName("0");
                        }
                    }
                    else
                    {
                        double k1 = (double)b.Width / this.Width;
                        int imaj_y = (int)((double)b.Height / k1);
                        int bosluk = (this.Height - imaj_y) / 2;
                        if (_e.Y >= bosluk && _e.Y <= this.Height - bosluk)
                        {
                            c = b.GetPixel((int) ((double) _e.X * k1), (int) ((double) (_e.Y - bosluk) * k1));
                        }
                        else
                        {
                            c = Color.FromName("0");
                        }
                    }

                }

              
                b.Dispose();
                return c;
            }
            catch (Exception exception)
            {
                return Color.Empty;
            }
        }

       
    }
}
