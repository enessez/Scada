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
using Scada.Resources;

namespace Scada.Forms.TestForms
{
    public partial class mwordtestform : Form
    {
        internal testform anaform;
        private const int i_max = 1;
        private const int j_max = 1;
        public mwordtestform()
        {
            InitializeComponent();
            for (int i = 0; i < i_max; i++)
            {
                for (int j = 0; j < i_max; j += 2)
                {
                    var tag = new Tag();
                    tag.BaslangicByteAdresi = 8 * i + j;
                    tag.BitAddrs = ((byte)(0));
                    tag.ContainerControl = this;
                    tag.Datatipi = S7.Net.DataType.Memory;
                    tag.Db = 1;
                    tag.DegiskenTipi = S7.Net.VarType.Word;
                    tag.TaramaSuresi = 50;
                    tag.VarCount = 1;

                    PlcTextBox plcTextBox1 = new PlcTextBox();
                    plcTextBox1.BackColor = System.Drawing.SystemColors.Window;
                    plcTextBox1.BasamakSayisi = 0;
                    plcTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
                    plcTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
                    plcTextBox1.BorderSize = 2;
                    tableLayoutPanel1.Controls.Add(plcTextBox1, i, j / 2);
                    plcTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    plcTextBox1.ForeColor = System.Drawing.Color.DimGray;
                    plcTextBox1.HepsiBuyuk = false;
                    plcTextBox1.Location = new System.Drawing.Point(304, 32);
                    plcTextBox1.Margin = new System.Windows.Forms.Padding(4);
                    plcTextBox1.MaxKarakter = 0;
                    plcTextBox1.MaxValue = 0D;
                    plcTextBox1.MinValue = 0D;
                    plcTextBox1.Dock = DockStyle.Fill;
                    plcTextBox1.Name = "plcTextBox1";
                    plcTextBox1.Padding = new System.Windows.Forms.Padding(7);
                    plcTextBox1.PasswordChar = false;
                    plcTextBox1.PlcTag = tag;
                    plcTextBox1.AutoSize = false;
                    plcTextBox1.textBox1.TextAlign = HorizontalAlignment.Center;
                    plcTextBox1.SadeceOkumaModu = true;
                    plcTextBox1.Sayi = true;
                    plcTextBox1.TabIndex = 0;
                    plcTextBox1.TamSayi = false;
                    plcTextBox1.Texts = "";
                    plcTextBox1.TimeoutBackColor = System.Drawing.Color.Empty;
                    plcTextBox1.TimeoutSuresi = 3000;
                    plcTextBox1.TumunuSec = true;
                    plcTextBox1.UnderlinedStyle = false;
                    plcTextBox1.Unit = null;
                }
            }
        }

        private void mwordtestform_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < i_max; i++)
            {
                for (int j = 0; j < i_max; j++)
                {
                    var butn = (PlcTextBox)tableLayoutPanel1.GetControlFromPosition(i, j);
                    var tag = butn.PlcTag;
                    tag.Server = anaform.plcServer1;
                    //tag.OnValueChanged(tag.Value);
                }
            }
        }
    }
}
