using System;
using System.Linq;
using System.Windows.Forms;



namespace Scada
{
    public class ENTextBox : TextBox
    {
        public ENTextBox()
        {
            CharacterCasing = CharacterCasing.Upper;
            
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
   
        public bool SadeceSayi { get; set; } = false;
        public int VirguldenOnce { get; set; } = 2;
        public int VirguldenSonra { get; set; } = 2;

        KeyPressEventArgs ReplaceTurkish(KeyPressEventArgs e)
        {
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
            return e;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e = ReplaceTurkish(e);
            if (SadeceSayi)
            {
                if (e.KeyChar == '.') e.KeyChar = ',';

                int durum = char.IsDigit(e.KeyChar) ? 0
                    : e.KeyChar == ',' ? 1
                         : e.KeyChar == '\b' ? 2
                              : char.IsControl(e.KeyChar) ? 3
                                  : 4;

                if (durum == 4) { e.Handled = true; return; }

                switch (durum)
                {
                    case 0:
                        if (this.Text.Contains(","))
                        {
                            string[] textarray = this.Text.Split(',');
                            int virgulindex = this.Text.IndexOf(',');
                            int mouse = this.SelectionStart;
                            int secilenmiktar = this.SelectionLength;
                            if (mouse > virgulindex)
                            {
                                if (textarray.Last().Length - secilenmiktar >= VirguldenSonra) e.Handled = true;
                            }
                            else
                            {
                                if (textarray.First().Length - secilenmiktar >= VirguldenOnce) e.Handled = true;
                            }
                        }
                        else
                        {
                            if (this.Text.Length - this.SelectionLength >= VirguldenOnce && !(this.Text == "10" && e.KeyChar == '0')) e.Handled = true;
                        }
                        break;
                    case 1:
                        if (this.Text == "" || this.Text.Contains(",") || this.Text == "100") e.Handled = true;
                        break;
                    case 3:
                        if (e.KeyChar == '\u0016')
                        {
                            string kopyalanan = Clipboard.GetText();
                            kopyalanan = kopyalanan.Replace('.', ',');
                            Clipboard.SetText(kopyalanan);
                            if (kopyalanan == "") e.Handled = true;
                            else if (kopyalanan.Count(x => x == ',') > 1) e.Handled = true;
                            else if (kopyalanan.Count(x => !char.IsDigit(x)) > 1) e.Handled = true;
                        }
                        break;
                    case 4:
                        e.Handled = true;
                        break;
                }
            }
            else if (!Char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == '\u0016')
            {
                string kopyalanan = Clipboard.GetText();
                kopyalanan = kopyalanan.ToUpper();
                char[] kopyalananingiliz = new char[kopyalanan.Length];
                int i = 0;
                foreach (char c in kopyalanan)
                {
                    char c_ = ReplaceTurkish(new System.Windows.Forms.KeyPressEventArgs(c)).KeyChar;
                    kopyalananingiliz[i++] = c_;
                }
                kopyalanan = new string(kopyalananingiliz);
                kopyalanan = new string(kopyalanan.Where(c => char.IsLetterOrDigit(c)).ToArray());
         
                if (kopyalanan == "") e.Handled = true;
                else if (kopyalanan.Length > 24)
                {
                    kopyalanan = new string(kopyalanan.Take(24).ToArray());
                }
                Clipboard.SetText(kopyalanan);
            }
           
        }

    }
}
