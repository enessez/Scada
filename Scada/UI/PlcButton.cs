using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Scada.UI;
using Timer = System.Timers.Timer;


namespace Scada
{
    public class PlcButton : CustomShapeButton
    {
        //Constructor
        public PlcButton()
        {
            gecikmeTimer.Elapsed += GecikmeTimerOnElapsed;
            this.TabStop = false;
            this.Enter += PlcButton_Enter;
        }

        #region privateFields
        private Tag _plcTag;
        private Tag _plcTag2;
        private Tag _plcTagError;
        private Color _onBackColor = Color.DarkSeaGreen;
        private Color _offBackColor = Color.Gray;
        private Color _onBorderColor = Color.LightSalmon;
        private Color _offBorderColor = Color.White;
        private Timer gecikmeTimer = new Timer(400);
        private bool readable = true;
        private PlcServer _server;
        #endregion

        #region public fields

        public PictureBox PictureBox1 = new PictureBox();
#endregion

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

                if (value.Server != null)
                    this.Server = value.Server;

                if (_plcTag != null)
                    _plcTag.ValueChanged -= PlcTagOnValueChanged;
                _plcTag = value;
                _plcTag.ValueChanged += PlcTagOnValueChanged;
                _plcTag = value;
                Invalidate();
            }
        }
        [Browsable(true), Category("PlcTagBool Özellikleri")]
        public Tag PlcTag2
        {
            get => _plcTag2;
            set
            {
                if (value == _plcTag2) return;
                if (value is null)
                {
                    _plcTag2 = null;
                    return;
                }

                if (value.Server != null)
                    this.Server = value.Server;

                if (_plcTag2 != null)
                    _plcTag2.ValueChanged -= PlcTag2OnValueChanged;
                _plcTag2 = value;
                _plcTag2.ValueChanged += PlcTag2OnValueChanged;
                _plcTag2 = value;
                Invalidate();
            }
        }
        [Browsable(true), Category("PlcTagBool Özellikleri")]
        public Tag PlcTagError
        {
            get => _plcTagError;
            set
            {
                if (value == _plcTagError) return;
                if (value is null)
                {
                    _plcTagError = null;
                    return;
                }

                if (value.Server != null)
                    this.Server = value.Server;

                if (_plcTag2 != null)
                {
                    _plcTagError.ValueChanged -= PlcTag2OnValueChanged;
                    _plcTagError.ValueChanged -= PlcTagOnValueChanged;
                }
                _plcTagError = value;
                _plcTagError.ValueChanged += PlcTagOnValueChanged;
                _plcTagError.ValueChanged += PlcTag2OnValueChanged;
                _plcTagError = value;
                Invalidate();
            }
        }
        [Browsable(true), Category("PlcTagBool Özellikleri")]
        public int TaramaSuresi => PlcTag.TaramaSuresi;

        [Browsable(true), Category("Renk Ayarları")]
        public Color OnBackColor
        {
            get => _onBackColor;
            set
            {
                _onBackColor = this.BackColor = value;
                Invalidate();
            }
        }

        [Browsable(true), Category("Renk Ayarları")]
        public Color OnBorderColor
        {
            get => _onBorderColor;
            set => _onBorderColor = value;
        }

        [Browsable(true), Category("Renk Ayarları")]
        public Color OffBackColor
        {
            get => _offBackColor;
            set => _offBackColor = value;
        }

        [Browsable(true), Category("Renk Ayarları")]
        public Color OffBorderColor
        {
            get => _offBorderColor;
            set => _offBorderColor = value;
        }

        public Color ErrorColor { get; set; } = Color.DarkRed;

        [Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PlcServer Server
        {
            get => _server;
            set
            {
                if ( value != _server && value != null)
                {
                    value.BaglantiDurumuChangeEvetHandler += ServerValue_BaglantiDurumuChangeEvetHandler;
                }

                _server = value;
            }
        }

      
        #endregion

        #region Private Methods
        private void PlcTagOnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (PlcTag2 != null) return;
                if (!readable)
                {
                    Task.Run(() =>
                    {
                        do
                        {
                            Thread.Sleep(10);
                        } while (!this.readable);

                        this.PlcTag.ContainerControl.Invoke((MethodInvoker)(() =>
                            PlcTagOnValueChanged(this.PlcTag, EventArgs.Empty)));
                    });
                    return;
                }

                bool yenideger;
                if (((Tag)sender).Value is bool)
                    yenideger = (bool)(((Tag)sender).Value ?? false);
                else yenideger = false;

                if (PlcTagError != null && (bool)PlcTagError.Value)
                {
                    this.BackColor = ErrorColor;
                }
                else
                {
                    if (yenideger)
                    {
                        this.BackColor = OnBackColor;
                        this.BorderColor = OnBorderColor;
                    }
                    else
                    {
                        this.BackColor = OffBackColor;
                        this.BorderColor = OffBorderColor;
                    }
                }
                this.Invalidate();
            }
            catch (Exception)
            {
                
            }
        }
        private void PlcTag2OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(PlcTag2 is null)
                    return;
                if (!readable)
                {
                    Task.Run(() =>
                    {
                        do
                        {
                            Thread.Sleep(10);
                        } while (!this.readable);

                        this.PlcTag.ContainerControl.Invoke((MethodInvoker)(() =>
                            PlcTag2OnValueChanged(this.PlcTag.Value, EventArgs.Empty)));
                    });
                    return;
                }

                bool yenideger;
                if (((Tag)sender).Value is bool)
                    yenideger = (bool)(((Tag)sender).Value ?? false);
                else yenideger = false;

                if (PlcTagError != null && (bool)PlcTagError.Value)
                {
                    this.BackColor = ErrorColor;
                }
                else
                {
                    if (yenideger)
                    {
                        this.BackColor = OnBackColor;
                        this.BorderColor = OnBorderColor;
                    }
                    else
                    {
                        this.BackColor = OffBackColor;
                        this.BorderColor = OffBorderColor;
                    }
                }
                this.Invalidate();
            }
            catch (Exception)
            {

            }
        }
     
        private void GecikmeTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            this.PlcTag.Readable = this.readable = true;
            gecikmeTimer.Stop();
        }

        private void ServerValue_BaglantiDurumuChangeEvetHandler(object sender, EventArgs e)
        {
            PlcTagOnValueChanged(this.PlcTag, EventArgs.Empty);
            PlcTag2OnValueChanged(this.PlcTag2, EventArgs.Empty);
        }

        #endregion

        #region Override
        public override Color BackColor { get; set; } = Color.DarkSeaGreen;
        protected override void OnClick(EventArgs e)
        {
            if (this.readable && this.PlcTag.Readable && this.PlcTag.Server.Bagli)
            {
                bool tagdeger = (bool) (this.PlcTag.Value ?? false);
                this.PlcTag.Readable = false;
                PlcTagOnValueChanged(!tagdeger,EventArgs.Empty);
                this.readable = false;
                gecikmeTimer.Stop();
                gecikmeTimer.Start();
                Task.Run(() => PlcTag.DegerYaz(!tagdeger)).Wait(30);
            }
         
            base.OnClick(e);
        }
        private void PlcButton_Enter(object sender, EventArgs e)
        {
            foreach (Control control in this.PlcTag.ContainerControl.Controls)
            {
                if (control is Label)
                {
                    control.Focus();
                    return;
                }
            }
            
        }

        protected override void OnCreateControl()
        {
            if (this.Server is null)
                this.Server = this.PlcTag.Server;
            
            PlcTagOnValueChanged(this.PlcTag,EventArgs.Empty);
            PlcTag2OnValueChanged(this.PlcTag2,EventArgs.Empty);

            base.OnCreateControl();
        }

        #endregion

    }
}
