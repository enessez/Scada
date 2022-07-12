using Scada;
using Scada.UI;


namespace Scada
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.customShapeButton9 = new Scada.CustomShapeButton();
            this.customShapeButton8 = new Scada.CustomShapeButton();
            this.customShapeButton0 = new Scada.CustomShapeButton();
            this.customShapeButton7 = new Scada.CustomShapeButton();
            this.customShapeButton1 = new Scada.CustomShapeButton();
            this.customShapeButton6 = new Scada.CustomShapeButton();
            this.customShapeButton2 = new Scada.CustomShapeButton();
            this.customShapeButton5 = new Scada.CustomShapeButton();
            this.customShapeButton3 = new Scada.CustomShapeButton();
            this.customShapeButton4 = new Scada.CustomShapeButton();
            this.pictureBoxButton1 = new Scada.UI.PictureBoxButton();
            this.btn_Error = new Scada.UI.PictureBoxButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plcServer1 = new Scada.PlcServer();
            this.normFeedDBDataset1 = new Scada.NormFeedDBDataset();
            this.errorLogTableAdapter = new Scada.NormFeedDBDatasetTableAdapters.tbl_ErrorLogTableAdapter();
            this.ErrorTagsTableAdapter = new Scada.NormFeedDBDatasetTableAdapters.tbl_ErrorTagsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(50, 1000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 1080);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton9, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton8, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton0, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton7, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton6, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.customShapeButton4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxButton1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Error, 0, 11);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(56, 684);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // customShapeButton9
            // 
            this.customShapeButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton9.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton9.BorderRadius = 20;
            this.customShapeButton9.BorderSize = 0;
            this.customShapeButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton9.ForeColor = System.Drawing.Color.White;
            this.customShapeButton9.Location = new System.Drawing.Point(3, 573);
            this.customShapeButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton9.Name = "customShapeButton9";
            this.customShapeButton9.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton9.TabIndex = 10;
            this.customShapeButton9.TabStop = false;
            this.customShapeButton9.UseVisualStyleBackColor = false;
            this.customShapeButton9.Click += new System.EventHandler(this.customShapeButton9_Click);
            // 
            // customShapeButton8
            // 
            this.customShapeButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton8.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton8.BorderRadius = 20;
            this.customShapeButton8.BorderSize = 0;
            this.customShapeButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton8.ForeColor = System.Drawing.Color.White;
            this.customShapeButton8.Location = new System.Drawing.Point(3, 518);
            this.customShapeButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton8.Name = "customShapeButton8";
            this.customShapeButton8.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton8.TabIndex = 9;
            this.customShapeButton8.TabStop = false;
            this.customShapeButton8.UseVisualStyleBackColor = false;
            this.customShapeButton8.Click += new System.EventHandler(this.customShapeButton8_Click);
            // 
            // customShapeButton0
            // 
            this.customShapeButton0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.customShapeButton0.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton0.BorderRadius = 20;
            this.customShapeButton0.BorderSize = 0;
            this.customShapeButton0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton0.ForeColor = System.Drawing.Color.White;
            this.customShapeButton0.Location = new System.Drawing.Point(3, 78);
            this.customShapeButton0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton0.Name = "customShapeButton0";
            this.customShapeButton0.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton0.TabIndex = 1;
            this.customShapeButton0.TabStop = false;
            this.customShapeButton0.Text = "reçete";
            this.customShapeButton0.UseVisualStyleBackColor = false;
            this.customShapeButton0.Click += new System.EventHandler(this.button1_Click);
            // 
            // customShapeButton7
            // 
            this.customShapeButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton7.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton7.BorderRadius = 20;
            this.customShapeButton7.BorderSize = 0;
            this.customShapeButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton7.ForeColor = System.Drawing.Color.White;
            this.customShapeButton7.Location = new System.Drawing.Point(3, 463);
            this.customShapeButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton7.Name = "customShapeButton7";
            this.customShapeButton7.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton7.TabIndex = 8;
            this.customShapeButton7.TabStop = false;
            this.customShapeButton7.UseVisualStyleBackColor = false;
            this.customShapeButton7.Click += new System.EventHandler(this.customShapeButton7_Click);
            // 
            // customShapeButton1
            // 
            this.customShapeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton1.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton1.BorderRadius = 20;
            this.customShapeButton1.BorderSize = 0;
            this.customShapeButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton1.ForeColor = System.Drawing.Color.White;
            this.customShapeButton1.Location = new System.Drawing.Point(3, 133);
            this.customShapeButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton1.Name = "customShapeButton1";
            this.customShapeButton1.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton1.TabIndex = 2;
            this.customShapeButton1.TabStop = false;
            this.customShapeButton1.Text = "silo";
            this.customShapeButton1.UseVisualStyleBackColor = false;
            this.customShapeButton1.Click += new System.EventHandler(this.customShapeButton2_Click);
            // 
            // customShapeButton6
            // 
            this.customShapeButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton6.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton6.BorderRadius = 20;
            this.customShapeButton6.BorderSize = 0;
            this.customShapeButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton6.ForeColor = System.Drawing.Color.White;
            this.customShapeButton6.Location = new System.Drawing.Point(3, 408);
            this.customShapeButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton6.Name = "customShapeButton6";
            this.customShapeButton6.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton6.TabIndex = 7;
            this.customShapeButton6.TabStop = false;
            this.customShapeButton6.UseVisualStyleBackColor = false;
            // 
            // customShapeButton2
            // 
            this.customShapeButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton2.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton2.BorderRadius = 20;
            this.customShapeButton2.BorderSize = 0;
            this.customShapeButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton2.ForeColor = System.Drawing.Color.White;
            this.customShapeButton2.Location = new System.Drawing.Point(3, 188);
            this.customShapeButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton2.Name = "customShapeButton2";
            this.customShapeButton2.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton2.TabIndex = 3;
            this.customShapeButton2.TabStop = false;
            this.customShapeButton2.Text = "test1";
            this.customShapeButton2.UseVisualStyleBackColor = false;
            this.customShapeButton2.Click += new System.EventHandler(this.customShapeButton1_Click);
            // 
            // customShapeButton5
            // 
            this.customShapeButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton5.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton5.BorderRadius = 20;
            this.customShapeButton5.BorderSize = 0;
            this.customShapeButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton5.ForeColor = System.Drawing.Color.White;
            this.customShapeButton5.Location = new System.Drawing.Point(3, 353);
            this.customShapeButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton5.Name = "customShapeButton5";
            this.customShapeButton5.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton5.TabIndex = 6;
            this.customShapeButton5.TabStop = false;
            this.customShapeButton5.UseVisualStyleBackColor = false;
            // 
            // customShapeButton3
            // 
            this.customShapeButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton3.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton3.BorderRadius = 20;
            this.customShapeButton3.BorderSize = 0;
            this.customShapeButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton3.ForeColor = System.Drawing.Color.White;
            this.customShapeButton3.Location = new System.Drawing.Point(3, 243);
            this.customShapeButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton3.Name = "customShapeButton3";
            this.customShapeButton3.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton3.TabIndex = 4;
            this.customShapeButton3.TabStop = false;
            this.customShapeButton3.UseVisualStyleBackColor = false;
            // 
            // customShapeButton4
            // 
            this.customShapeButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.customShapeButton4.BorderColor = System.Drawing.Color.DeepPink;
            this.customShapeButton4.BorderRadius = 20;
            this.customShapeButton4.BorderSize = 0;
            this.customShapeButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton4.ForeColor = System.Drawing.Color.White;
            this.customShapeButton4.Location = new System.Drawing.Point(3, 298);
            this.customShapeButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customShapeButton4.Name = "customShapeButton4";
            this.customShapeButton4.Size = new System.Drawing.Size(50, 51);
            this.customShapeButton4.TabIndex = 5;
            this.customShapeButton4.TabStop = false;
            this.customShapeButton4.UseVisualStyleBackColor = false;
            // 
            // pictureBoxButton1
            // 
            this.pictureBoxButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxButton1.Golgeli = false;
            this.pictureBoxButton1.Gorsel = null;
            this.pictureBoxButton1.GorselMaske = global::Scada.Properties.Resources.UserMaske;
            this.pictureBoxButton1.Image = global::Scada.Properties.Resources.icons8_user_shield_48px;
            this.pictureBoxButton1.ImageOverMouse = global::Scada.Properties.Resources.icons8_user_shield_48px_1;
            this.pictureBoxButton1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxButton1.Name = "pictureBoxButton1";
            this.pictureBoxButton1.OnOverButton = false;
            this.pictureBoxButton1.Size = new System.Drawing.Size(50, 51);
            this.pictureBoxButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton1.TabIndex = 11;
            this.pictureBoxButton1.TabStop = false;
            this.pictureBoxButton1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Error
            // 
            this.btn_Error.BackColor = System.Drawing.Color.Transparent;
            this.btn_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Error.Golgeli = false;
            this.btn_Error.Gorsel = global::Scada.Properties.Resources._8iE9;
            this.btn_Error.GorselMaske = null;
            this.btn_Error.Image = global::Scada.Properties.Resources._8iE9;
            this.btn_Error.ImageOverMouse = null;
            this.btn_Error.Location = new System.Drawing.Point(3, 629);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.OnOverButton = false;
            this.btn_Error.Size = new System.Drawing.Size(50, 52);
            this.btn_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Error.TabIndex = 12;
            this.btn_Error.TabStop = false;
            this.btn_Error.Click += new System.EventHandler(this.btn_Error_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(56, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1864, 1080);
            this.panel2.TabIndex = 1;
            // 
            // plcServer1
            // 
            this.plcServer1.Bagli = false;
            this.plcServer1.BaslangicByteAdresi = 0;
            this.plcServer1.ContainerControl = this;
            this.plcServer1.CpuType = S7.Net.CpuType.S71500;
            this.plcServer1.DataTipi = S7.Net.DataType.DataBlock;
            this.plcServer1.Db = 1;
            this.plcServer1.Ip = "192.168.2.2";
            this.plcServer1.Port = 102;
            this.plcServer1.Rack = ((short)(0));
            this.plcServer1.Sifre = 1489;
            this.plcServer1.Slot = ((short)(1));
            this.plcServer1.TaramaSuresi = 50;
            // 
            // normFeedDBDataset1
            // 
            this.normFeedDBDataset1.DataSetName = "NormFeedDBDataset";
            this.normFeedDBDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorLogTableAdapter
            // 
            this.errorLogTableAdapter.ClearBeforeFill = true;
            // 
            // ErrorTagsTableAdapter
            // 
            this.ErrorTagsTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.panel1_Deactivate);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomShapeButton customShapeButton0;
        private CustomShapeButton customShapeButton9;
        private CustomShapeButton customShapeButton8;
        private CustomShapeButton customShapeButton7;
        private CustomShapeButton customShapeButton6;
        private CustomShapeButton customShapeButton5;
        private CustomShapeButton customShapeButton4;
        private CustomShapeButton customShapeButton3;
        private CustomShapeButton customShapeButton2;
        private CustomShapeButton customShapeButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private PictureBoxButton pictureBoxButton1;
        public PlcServer plcServer1;
        private PictureBoxButton btn_Error;
        private NormFeedDBDataset normFeedDBDataset1;
        private NormFeedDBDatasetTableAdapters.tbl_ErrorLogTableAdapter errorLogTableAdapter;
        private NormFeedDBDatasetTableAdapters.tbl_ErrorTagsTableAdapter ErrorTagsTableAdapter;
    }
}