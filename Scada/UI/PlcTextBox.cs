using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;
using Scada.UI;
using Timer = System.Windows.Forms.Timer;

namespace Scada.Resources
{
    public class PlcTextBox : FormattedTextbox
    { 
        //Constructor
        public PlcTextBox()
        {
            this.textBox1.Enter += TextBox1_Enter;
            this.timer2.Tick += Timer2_Tick;
            this.textBox1.KeyDown += PlcTextBox_KeyDown;
            this.textBox1.Leave += TextBox1_Leave;
            this.KeyDown += ThisControl_KeyDown1;
        }

        //private fields
        #region private fields
        private Tag _plcTag;
        private Timer timer1;
        private Timer timer2 = new Timer() {Interval = 1000, Enabled = false};
        private int _timeoutSuresi = 3000;
        private Color _tempcolor;
        private Mutex timermut = new Mutex();
        private string _tempText = "";
        private bool readable = true;
        private bool _sadeceOkumaModu = false;
        private PlcServer _server;
        #endregion

        //properties
        #region Properties
        [Category("Plc Ayarları"),Description("Herhangi bir harf yazmadan durulduğunda yazma işlemine geçilmesi için gerekli süre")]
        public int TimeoutSuresi
        {
            get => _timeoutSuresi;
            set
            {
                _timeoutSuresi = value;
                timer1 = new Timer {Interval = value, Enabled = false};
                timer1.Tick+= Timer1Elapsed;
            }
        }
        [Category("Plc Ayarları")]
        public Tag PlcTag
        {
            get => _plcTag;
            set
            {
                if (value == _plcTag) return;
                if (value is null)
                {
                    if (_plcTag != null)
                        _plcTag.ValueChanged -= PlcTagValueChanged;
                    _plcTag = null;
                    return;
                }

                if (value.Server != null)
                    this.Server = value.Server;

                if (_plcTag != null)
                    _plcTag.ValueChanged -= PlcTagValueChanged;
                _plcTag = value;
                _plcTag.ValueChanged += PlcTagValueChanged;
                Invalidate();
            }
        }
        [Category("Plc Ayarları")]
        public VarType DegiskenTipi
        {
            get => this.PlcTag.DegiskenTipi;
        }

        [Category("Plc Ayarları")]
        [Description("Timeout olduğu anda değer yazılırkenki backcolor")]
        public Color TimeoutBackColor { get; set; }

        public string Unit { get; set; }

        public bool SadeceOkumaModu
        {
            get => _sadeceOkumaModu;
            set
            {
                this.Multiline = value;
                this.Enabled = !value;
                _sadeceOkumaModu = value;
            }
        }
        [Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PlcServer Server
        {
            get => _server;
            set
            {
                if (value != _server && value != null) 
                {
                    value.BaglantiDurumuChangeEvetHandler += ServerValue_BaglantiDurumuChangeEvetHandler;
                }
            }
        }

      
        #endregion
        //private methods
        #region Private Methods

        protected override void OnClick(EventArgs e)
        {
            if (!timer1.Enabled)
                TextBox1_Enter(this, e);
            base.OnClick(e);
        }

        private void PlcTagValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker) (() =>
                {
                    if (((Tag)sender).Value is null)
                    {
                        this.tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Absolute;
                        this.tableLayoutPanel1.ColumnStyles[1].Width = this.Height;
                        this.tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
                        this.tableLayoutPanel1.ColumnStyles[0].Width = 100;
                    }
                    else
                    {
                        this.tableLayoutPanel1.ColumnStyles[1].Width = 0;
                    }
                    this.Texts = GetStringFromValue(((Tag)sender).Value);
                }));
            }
            catch (Exception)
            {
             
            }
        }

        private void TexttenTageYaz()
        {
            if (!this.PlcTag.Server.Bagli) 
                return;
            
            this.PlcTag.Readable = false;
            try
            {
                object value = GetObjectFromText(this.Texts);
                this.PlcTag.Value = value;
                this.textBox1.Enabled = false;
                this._tempcolor = Color.FromArgb(this.BackColor.ToArgb());
                this.BackColor = TimeoutBackColor;
                Task.Run(() =>
                {
                    this.PlcTag.DegerYaz(GetObjectFromText(this.Texts));
                    _tempText = GetStringFromValue(PlcTag.Value);
                }).Wait(30);
                this.timer2.Start();
            }
            catch (Exception e)
            {
                
            }
        }
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            this.Texts = GetStringFromValue(this.PlcTag.Value);
            this.PlcTag.Readable = true;
            this.timer1.Stop();
        }
        private void Timer1Elapsed(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Texts = GetStringFromValue(this.PlcTag.Value);
            foreach (var ctr in this.PlcTag.ContainerControl.Controls)
                if (ctr is Label lbl)
                {
                    lbl.Focus();
                    break;
                }
            
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.textBox1.Enabled = true;
            this.textBox1.Focus();
            this.BackColor = this._tempcolor;
            this.PlcTag.Readable = this.readable = true;
            timer2.Stop();
        }
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            _tempText = this.Texts;
            this.timer1.Start();
            if (!SadeceOkumaModu)
                this.PlcTag.Readable = false;
            this.textBox1.SelectAll();
        }
        private void PlcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                timer1.Stop();
                this.Texts = GetStringFromValue(this.PlcTag.Value);
                foreach (Control ctr in this.PlcTag.ContainerControl.Controls)
                    if (ctr is Label lbl)
                    {
                        lbl.Focus();
                        break;
                    }
            }
            else if (SadeceOkumaModu)
            {
                e.Handled = e.SuppressKeyPress = true;
                return;
            }
            else if (e.KeyData == Keys.Enter)               //süre bitmeden enter
            {
                this.timer1.Stop();
                TexttenTageYaz();
                this.textBox1.SelectAll();
            }
            else
            {
                this.readable = this.PlcTag.Readable = false;
                this.timer1.Stop();
                this.timer1.Start();
            }
        }
        private void ThisControl_KeyDown1(object sender, KeyEventArgs e)
        {
            //this.textBox1.Focus();
        }
        private string GetStringFromValue(object value)
        {
            try
            {
                string unit = this.Unit == "" || this.Unit is null ? "" : " " + Unit;
                if (value is null)
                    return "####";
                switch (this.DegiskenTipi)
                {
                    case VarType.Bit:
                        return (bool) value ? "True" : "False";
                    case VarType.Byte://????
                        return Convert.ToString((byte) value);
                    case VarType.Real:
                        return string.Format("{0:F" + this.BasamakSayisi.ToString() + "}",
                            Math.Round(Convert.ToDecimal(value), this.BasamakSayisi)) + unit;
                    case VarType.Counter:
                    case VarType.DInt:
                    case VarType.Int:
                    case VarType.Word:
                        return Convert.ToString(value) + unit;
                    case VarType.S7String:
                        if (value is byte[] _bvalue)
                            return S7.Net.Types.S7String.FromByteArray(_bvalue) + unit;
                        else if (value is string)
                            return value + unit;
                        else return "####";
                    case VarType.S7WString:
                        if (value is byte[] __bvalue)
                            return S7.Net.Types.S7WString.FromByteArray(__bvalue) + unit;
                        else if (value is string)
                            return value + unit;
                        else return "####";
                    default:
                        return Convert.ToString(value) + unit;
                }
            }
            catch (Exception )
            {
                return "####";
            }
        }

        private object GetObjectFromText(string textToObj)
        {
            string unit = this.Unit == "" || this.Unit is null ? "" : " " + Unit;
            string _text = textToObj.TrimEnd((this.Unit ?? "").ToCharArray()).TrimEnd();
            switch (this.DegiskenTipi)
            {
                case VarType.Bit://?????
                    bool deger;
                    return bool.TryParse(_text, out deger) ? deger : false;
                case VarType.Byte:
                    return byte.Parse(_text);
                case VarType.Counter:
                    return Int16.Parse(_text == "" ? "0" : _text);
                case VarType.DInt:
                    return int.Parse(_text == "" ? "0" : _text);
                case VarType.Int:
                case VarType.Word:
                    return Int16.Parse(_text == "" ? "0" : _text);
                case VarType.Real:
                    return float.Parse(_text == "" ? "0" : _text);
                case VarType.S7String:
                    return S7.Net.Types.S7String.ToByteArray(_text, this.PlcTag.VarCount);
                case VarType.S7WString:
                    return S7.Net.Types.S7WString.ToByteArray(_text, this.PlcTag.VarCount);
                default:
                    return false;
            }
        }

        private void ServerValue_BaglantiDurumuChangeEvetHandler(object sender, EventArgs e)
        {
            PlcTagValueChanged(this.Tag,EventArgs.Empty);
        }

        protected override void OnCreateControl()
        {
            if (this.Server is null)
                this.Server = this.PlcTag.Server;
            
            PlcTagValueChanged(this.Tag,EventArgs.Empty);
            base.OnCreateControl();
        }

        #endregion
    }
}
