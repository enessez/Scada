using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Scada
{
    public class CustomShapeButton : Button
    {
        //Fields
        int borderRadius = 40;
        Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public int BorderRadius
        {
            get =>
                borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get =>
                borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        //Constructor
        public CustomShapeButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }
        //Methods
        private GraphicsPath GetFigurePath(RectangleF rect,float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);

            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270,90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectsurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectborder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) 
            {
                using (GraphicsPath pathsurface = GetFigurePath(rectsurface, borderRadius))
                using (GraphicsPath pathborder = GetFigurePath(rectborder, borderRadius - 1F))
                using (Pen pensurface = new Pen(this.Parent.BackColor, 2)) 
                    using(Pen penBorder = new Pen(BorderColor,BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathsurface);
                    //draw surface border for hd results
                    pevent.Graphics.DrawPath(pensurface, pathsurface);
                    if (BorderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathborder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectsurface);
                if (BorderSize >=1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            var form = this.GetContainerControl();
            bool bulundu = false;
            if (form != null && form is Form f)
                foreach (Control c in f.Controls)
                    if (c is Label || c is PictureBox)
                    {
                        c.Focus();
                        bulundu = true;
                        break;
                    }


        }


        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += Parent_BackColorChanged;  
        }

        private void Parent_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
  
}
