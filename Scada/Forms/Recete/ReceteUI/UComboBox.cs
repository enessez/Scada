using System;
using System.Windows.Forms;
using System.Linq;


namespace Scada
{
    class UComboBox : ComboBox
    {
        public UComboBox()
        {
         
        }
   
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            this.DroppedDown = true;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (this.DroppedDown)
            {
                this.DroppedDown = false;
            }
            e.KeyChar = (char)e.KeyChar.ToString().ToUpper().ToCharArray().FirstOrDefault();
            switch (e.KeyChar)
            {
                case 'Ş':
                    e.KeyChar = 'S';
                    break;

                case 'Ç':
                    e.KeyChar = 'C';
                    break;

                case 'Ü':
                    e.KeyChar = 'U';
                    break;

                case 'Ö':
                    e.KeyChar = 'O';
                    break;

                case 'İ':
                    e.KeyChar = 'I';
                    break;

                case 'Ğ':
                    e.KeyChar = 'G';
                    break;
            }
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        protected override void OnDropDownClosed(EventArgs e)
        {
            base.OnDropDownClosed(e);
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
