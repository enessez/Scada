using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scada.Forms.AnaSayfa;

namespace Scada.Forms.TestForms
{
    public partial class InputsForm : Form
    {
        internal testform anaform;
        public InputsForm()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    var tag = new Tag();
                    tag.BaslangicByteAdresi = j;
                    tag.BitAddrs = ((byte)(i));
                    tag.ContainerControl = this;
                    tag.Datatipi = S7.Net.DataType.Input;
                    tag.Db = 1;
                    tag.DegiskenTipi = S7.Net.VarType.Bit;
                    tag.TaramaSuresi = 50;
                    tag.VarCount = 1;

                    //var tag2 = new Tag();
                    //tag2.Server = this.plcServer1;
                    //tag2.BaslangicByteAdresi = j;
                    //tag2.BitAddrs = ((byte)(i));
                    //tag2.ContainerControl = this;
                    //tag2.Datatipi = S7.Net.DataType.Output;
                    //tag2.Db = 1;
                    //tag2.DegiskenTipi = S7.Net.VarType.Bit;
                    //tag2.TaramaSuresi = 50;
                    //tag2.VarCount = 1;

                    PlcButton plcButton = new PlcButton();
                    plcButton.BorderRadius = 8;
                    plcButton.BorderSize = 0;
                    plcButton.FlatAppearance.BorderSize = 0;
                    plcButton.BorderColor = System.Drawing.Color.PaleVioletRed;
                    plcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    plcButton.ForeColor = System.Drawing.Color.White;
                    plcButton.Location = new System.Drawing.Point(0, 0);
                    tableLayoutPanel1.Controls.Add(plcButton, i, j);
                    plcButton.Dock = DockStyle.Fill;
                    plcButton.Name = "plcButton1";
                    plcButton.OffBackColor = System.Drawing.Color.Gray;
                    plcButton.OffBorderColor = System.Drawing.Color.White;
                    plcButton.OnBackColor = System.Drawing.Color.DarkSeaGreen;
                    plcButton.OnBorderColor = System.Drawing.Color.LightSalmon;
                    plcButton.PlcTag = tag;
                    //plcButton.PlcTag2 = tag2;
                    plcButton.Size = new System.Drawing.Size(29, 8);
                    plcButton.TabIndex = 0;
                    plcButton.TabStop = false;
                    plcButton.Text = $"I{j}.{i}";
                    plcButton.UseVisualStyleBackColor = true;
                }
            }
        }

        private void InputsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    var butn = ((PlcButton) tableLayoutPanel1.GetControlFromPosition(i, j));
                    butn.PlcTag.Server = anaform.plcServer1;
                }
            }
        }
    }
}
