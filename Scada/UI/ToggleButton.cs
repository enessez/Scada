using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Scada
{
    public class ToggleButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
  

        [Category("Ozellikler")]
        public Color OnBackColor
        {
            get => onBackColor;
            set
            {
                onBackColor = value;
                Invalidate();
            }
        }
        [Category("Ozellikler")]
        public Color OnToggleColor
        {
            get => onToggleColor;
            set
            {
                onToggleColor = value;
                Invalidate();
            }
        }
        [Category("Ozellikler")]
        public Color OffBackColor
        {
            get => offBackColor;
            set
            {
                offBackColor = value;
                Invalidate();
            }
        }
        [Category("Ozellikler")]
        public Color OffToggleColor
        {
            get => offToggleColor;
            set
            {
                offToggleColor = value;
                Invalidate();
            }
        }


        private GraphicsPath GetFigurePath()
        {
            int arcsize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcsize, arcsize);
            Rectangle RightArc = new Rectangle(this.Width - arcsize - 2, 0, arcsize, arcsize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(RightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        //paint
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);
            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }

        //constructure
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
            this.AutoSize = false;
        }
    }
}
