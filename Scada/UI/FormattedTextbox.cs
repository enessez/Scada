using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scada.UI
{
    public class FormattedTextbox : RJTextBox 
    {
        //Constructor
        public FormattedTextbox()
        {
            this.textBox1.KeyDown += OnKeyDown;
            this.textBox1.MouseClick += TextBox1OnMouseClick;
        }

        //Properties
        #region Properties

        public bool Sayi
        {
            get => _sayi;
            set
            {
                _sayi = value;
                SayiChanged();
            }
        }

        public bool TamSayi
        {
            get => _tamsayi;
            set
            {
                _tamsayi = value;
                TamsayiChanged();
            }
        }

        public int BasamakSayisi
        {
            get => _basamaksayisi;
            set
            {
                _basamaksayisi = value;
            }
        }

        public bool SadeceIngilizceKarakter
        {
            get => _sadeceIngilizceKarakter;
            set
            {
                _sadeceIngilizceKarakter = value;
            }
        }

        public bool OzelKarakterYasak
        {
            get => _ozelKarakterYasak;
            set
            {
                _ozelKarakterYasak = value;
            }
        }

        public bool HepsiBuyuk
        {
            get => _hepsiBuyuk;
            set
            {
                _hepsiBuyuk = value;
            }
        }

        public bool TumunuSec
        {
            get => _tumunuSec;
            set => _tumunuSec = value;
        }
      

        public int MaxKarakter
        {
            get => _maxKarakter;
            set
            {
                if (value < 0)
                    _maxKarakter = 0;
                else _maxKarakter = value;
            }
        }

        public double MaxValue
        {
            get => _maxValue;
            set => _maxValue = value;
        }

        public double MinValue
        {
            get => _minValue;
            set => _minValue = value;
        }
        #endregion
        //private fields
        #region Private Fields
        private bool _sayi = false;
        private bool _tamsayi = false;
        private int _basamaksayisi = 0;

        private bool _sadeceIngilizceKarakter = false;
        private bool _ozelKarakterYasak = false;
        private bool _hepsiBuyuk = false;
        private bool _tumunuSec = true;
        private char[] _trToen =
        {
            'ş', 's', 'Ş', 'S', 'ç', 'c', 'Ç', 'C', 'ğ', 'g', 'Ğ', 'G', 'ü', 'u', 'Ü', 'U', 'ı', 'i', 'İ', 'I', 'ö',
            'o', 'Ö', 'O'
        };
        private int _maxKarakter = 0;
        private double _maxValue = 0;
        private double _minValue = 0;
        #endregion
        //override
        #region Override

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == 22)//ctrl v
                {
                    int indexstart = this.textBox1.SelectionStart;
                    string beforecursor = this.Texts.Substring(0, this.textBox1.SelectionStart);
                    string afterselection =
                        this.Texts.Substring(this.textBox1.SelectionStart + this.textBox1.SelectionLength);
                    string text = Clipboard.GetText();
                    foreach (char c in text)
                    {
                        var _e = new KeyPressEventArgs(c);
                        TumKontroller(_e);
                        if (!_e.Handled)
                        {
                            beforecursor += _e.KeyChar;
                            this.Texts = beforecursor + afterselection;
                            this.textBox1.SelectionStart = (++indexstart);
                        }
                    }
                    e.Handled = true;
                    this.textBox1.SelectionStart = beforecursor.Length;
                }
                goto EventeYolla;
            }
            TumKontroller(e);
            EventeYolla:
            base.OnKeyPress(e);
        }


        protected void OnKeyDown(object sender,KeyEventArgs e)
        {
            Keys[] keys = new Keys[]
                {Keys.Enter, Keys.Control|Keys.ControlKey, Keys.Down, Keys.Left, Keys.Up, Keys.Right, Keys.ControlKey};
            //if (this.textBox1.SelectionLength == this.Texts.Length && !keys.Contains(e.KeyData))
            //    this.Texts = "";????
        }

  
        #endregion
        //private methods

        #region Private Methods

        private void TumKontroller(KeyPressEventArgs e)
        {
            if (Sayi)
            {
                if (TamSayi)
                    Tamsayi(e);
                else
                {
                    VirgulluSayi(e);
                }

                if (!e.Handled && (this.MaxValue != 0 || this.MinValue != 0))  
                {
                    int indexstart = this.textBox1.SelectionStart;
                    string beforecursor = this.Texts.Substring(0, this.textBox1.SelectionStart);
                    string afterselection =
                        this.Texts.Substring(this.textBox1.SelectionStart + this.textBox1.SelectionLength);
                    string textyeni = beforecursor + e.KeyChar + afterselection;
                    double newdeger = double.Parse(textyeni);
                    if (newdeger>Double.MaxValue )
                    {
                        e.Handled = true;
                        this.Text = MaxValue.ToString();
                    }
                    else if(newdeger<MinValue)
                    {
                        e.Handled = true;
                        this.Text = MinValue.ToString();
                    }
                }
            }
            else     //sayı değil
            {
                if (this.MaxKarakter != 0 && this.Text.Length >= this.MaxKarakter)
                {
                    e.Handled = true;
                    return;
                }
                if (HepsiBuyuk)
                    toUpper(e);
                if (SadeceIngilizceKarakter)
                    TurkceyeCevir(e);
                if (OzelKarakterYasak)
                    OzeKarakterseAtla(e);
            }
        }
        private void VirgulluSayi(KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',')
            {
                if (this.Texts.Contains(','))
                    e.Handled = true;
                else
                {
                    string text = this.Texts;
                    int index = this.textBox1.SelectionStart;
                    text = text.Substring(index);
                    if (text.Length > this.BasamakSayisi)
                    {
                        this.Texts = this.Texts.Substring(0, index + BasamakSayisi);
                        this.textBox1.SelectionStart = index;
                    }
                }
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = this.Texts.Length != 0;
            }
            else
            {
                if (this.Texts.Contains(','))
                {
                    int index = this.textBox1.SelectionStart;
                    int virgulindex = this.Texts.IndexOf(',');
                    if (index > virgulindex)
                    {
                        int basamaksayisi = this.Texts.Length - virgulindex - 1;
                        if (basamaksayisi >= BasamakSayisi)
                            e.Handled = true;
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        private void Tamsayi(KeyPressEventArgs e)
        {
            e.Handled |= !(char.IsDigit(e.KeyChar) || ((this.Texts.Length == 0) && e.KeyChar == '-'));
        }

        private void TamsayiChanged()
        {
            if (_tamsayi)
            {
                _basamaksayisi = 0;
                _sayi= true;
                _sadeceIngilizceKarakter = _ozelKarakterYasak = _hepsiBuyuk = false;
            }
            else
            {
               
            }
        }
        private void SayiChanged()
        {
            if (_sayi)
            {
                _sadeceIngilizceKarakter = _ozelKarakterYasak = _hepsiBuyuk = false;
            }
            else
            {
                _tamsayi = false;
                _basamaksayisi = 0;
            }
        }

        private void TurkceyeCevir(KeyPressEventArgs e)
        {
            for (int i = 0; i < _trToen.Length; i+=2)
                if (e.KeyChar == _trToen[i])
                    e.KeyChar = _trToen[i + 1];
        }

        private void OzeKarakterseAtla(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void toUpper(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void TextBox1OnMouseClick(object sender, MouseEventArgs e)
        {
            if (TumunuSec)
                this.textBox1.SelectAll();
        }
        #endregion
    }
}
