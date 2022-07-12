
namespace Scada.Forms.AnaSayfa
{
    partial class testform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plcServer1 = new Scada.PlcServer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customShapeButton3 = new Scada.CustomShapeButton();
            this.customShapeButton2 = new Scada.CustomShapeButton();
            this.customShapeButton1 = new Scada.CustomShapeButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plcServer1
            // 
            this.plcServer1.Bagli = false;
            this.plcServer1.BaslangicByteAdresi = 0;
            this.plcServer1.ContainerControl = this;
            this.plcServer1.CpuType = S7.Net.CpuType.S71500;
            this.plcServer1.DataTipi = S7.Net.DataType.DataBlock;
            this.plcServer1.Db = 1;
            this.plcServer1.Ip = "192.168.1.77";
            this.plcServer1.Port = 102;
            this.plcServer1.Rack = ((short)(0));
            this.plcServer1.Sifre = 1489;
            this.plcServer1.Slot = ((short)(1));
            this.plcServer1.TaramaSuresi = 50;
            this.plcServer1.BaglantiDurumuChangeEvetHandler += new System.EventHandler(this.plcServer1_BaglantiDurumuChangeEvetHandler);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 510);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(73, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 510);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customShapeButton3);
            this.panel1.Controls.Add(this.customShapeButton2);
            this.panel1.Controls.Add(this.customShapeButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 510);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // customShapeButton3
            // 
            this.customShapeButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customShapeButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customShapeButton3.BorderRadius = 19;
            this.customShapeButton3.BorderSize = 0;
            this.customShapeButton3.FlatAppearance.BorderSize = 0;
            this.customShapeButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton3.ForeColor = System.Drawing.Color.White;
            this.customShapeButton3.Location = new System.Drawing.Point(7, 160);
            this.customShapeButton3.Name = "customShapeButton3";
            this.customShapeButton3.Size = new System.Drawing.Size(58, 51);
            this.customShapeButton3.TabIndex = 2;
            this.customShapeButton3.Text = "MWord";
            this.customShapeButton3.UseVisualStyleBackColor = false;
            this.customShapeButton3.Click += new System.EventHandler(this.customShapeButton3_Click);
            // 
            // customShapeButton2
            // 
            this.customShapeButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customShapeButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customShapeButton2.BorderRadius = 19;
            this.customShapeButton2.BorderSize = 0;
            this.customShapeButton2.FlatAppearance.BorderSize = 0;
            this.customShapeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton2.ForeColor = System.Drawing.Color.White;
            this.customShapeButton2.Location = new System.Drawing.Point(7, 101);
            this.customShapeButton2.Name = "customShapeButton2";
            this.customShapeButton2.Size = new System.Drawing.Size(58, 51);
            this.customShapeButton2.TabIndex = 1;
            this.customShapeButton2.Text = "Memory";
            this.customShapeButton2.UseVisualStyleBackColor = false;
            this.customShapeButton2.Click += new System.EventHandler(this.customShapeButton2_Click);
            // 
            // customShapeButton1
            // 
            this.customShapeButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customShapeButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customShapeButton1.BorderRadius = 19;
            this.customShapeButton1.BorderSize = 0;
            this.customShapeButton1.FlatAppearance.BorderSize = 0;
            this.customShapeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton1.ForeColor = System.Drawing.Color.White;
            this.customShapeButton1.Location = new System.Drawing.Point(7, 42);
            this.customShapeButton1.Name = "customShapeButton1";
            this.customShapeButton1.Size = new System.Drawing.Size(58, 51);
            this.customShapeButton1.TabIndex = 0;
            this.customShapeButton1.Text = "İnput";
            this.customShapeButton1.UseVisualStyleBackColor = false;
            this.customShapeButton1.Click += new System.EventHandler(this.customShapeButton1_Click);
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "testform";
            this.Text = "testform";
            this.Load += new System.EventHandler(this.testform_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomShapeButton customShapeButton3;
        private CustomShapeButton customShapeButton2;
        private CustomShapeButton customShapeButton1;
        public PlcServer plcServer1;
        private System.Windows.Forms.Label label1;
    }
}