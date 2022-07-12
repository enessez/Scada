using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Scada.UI
{
    public class PlcToggleButton : ToggleButton
    {
        //Constructor
        public PlcToggleButton()
        {
            buton_tiklama_timer.Tick += Buton_tiklama_timer_Elapsed;
        }

        #region Properties

        [Browsable(true), Category("PlcTagBool Özellikleri")]
        public Tag PlcTag
        {
            get => _plcTag;
            set
            {
                if (value == _plcTag) return;
                if (value is null)
                {
                    _plcTag = null;
                    return;
                }

                if (_plcTag != null)
                    _plcTag.ValueChanged -= PlcTagOnValueChanged;
                _plcTag = value;
                _plcTag.ValueChanged += PlcTagOnValueChanged;
                _plcTag = value;
                Invalidate();
            }
        }

        [Browsable(true), Category("PlcTagBool Özellikleri")]
        public int TaramaSuresi => PlcTag.TaramaSuresi;

        [Browsable(true), Category("Renk Ayarları")]
        public Color TagOnBackColor
        {
            get => _tagOnBackColor;
            set
            {
                _tagOnBackColor = this.BackColor = value;
                Invalidate();
            }
        }

        [Browsable(true), Category("Renk Ayarları")]
        public Color TagOnBorderColor
        {
            get => _tagOnBorderColor;
            set => _tagOnBorderColor = value;
        }

        [Browsable(true), Category("Renk Ayarları")]
        public Color TagOffBackColor
        {
            get => _tagOffBackColor;
            set => _tagOffBackColor = value;
        }

        [Browsable(true), Category("Renk Ayarları")]
        public Color TagOffBorderColor
        {
            get => _tagOffBorderColor;
            set => _tagOffBorderColor = value;
        }
        #endregion

        #region privateFields
        private Tag _plcTag;
        private Color _tagOnBackColor = Color.DarkSeaGreen;
        private Color _tagOffBackColor = Color.IndianRed;
        private Color _tagOnBorderColor = Color.LightSalmon;
        private Color _tagOffBorderColor = Color.White;
        private Timer buton_tiklama_timer = new Timer() {Interval =  1000, Enabled = false};
        private bool readable = true;
        #endregion

        #region Private Methods
        private void PlcTagOnValueChanged(object sender, EventArgs e)
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
                            PlcTagOnValueChanged(this.PlcTag, EventArgs.Empty)));
                    });
                    return;
                }

                bool yenideger = (bool)(((Tag)sender).Value ?? false);
                this.Checked = yenideger;
                this.Invalidate();
            }
            catch (Exception)
            {
                
            }
        }

        private void Buton_tiklama_timer_Elapsed(object sender, EventArgs e)
        {
            readable = PlcTag.Readable = true;
            buton_tiklama_timer.Stop();
        }
        #endregion

        #region Override
        public override Color BackColor { get; set; } = Color.DarkSeaGreen;

        protected override void OnClick(EventArgs e)
        {
            if (this.readable && this.PlcTag.Readable && this.PlcTag.Server.Bagli)
            {
                bool tagdeger = (bool)(this.PlcTag.Value ?? false);
                this.PlcTag.Readable = false;
                PlcTagOnValueChanged(!tagdeger,EventArgs.Empty);
                this.readable = false;
                buton_tiklama_timer.Stop();
                buton_tiklama_timer.Start();
                Task.Run(() => PlcTag.DegerYaz(!tagdeger)).Wait(30);
            }
            base.OnClick(e);
        }

        #endregion
    }
}
