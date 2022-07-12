
namespace Scada
{
    partial class GirisForm_GirisMenusu
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GirisYap = new Scada.CustomShapeButton();
            this.textBox_Sifre = new Scada.UI.FormattedTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Kullanici_Adi = new Scada.UI.FormattedTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1844, 995);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(743, 398);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(357, 198);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_GirisYap);
            this.panel1.Controls.Add(this.textBox_Sifre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_Kullanici_Adi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(70, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 139);
            this.panel1.TabIndex = 0;
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GirisYap.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GirisYap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_GirisYap.BorderRadius = 35;
            this.btn_GirisYap.BorderSize = 0;
            this.btn_GirisYap.FlatAppearance.BorderSize = 0;
            this.btn_GirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_GirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GirisYap.ForeColor = System.Drawing.Color.White;
            this.btn_GirisYap.Location = new System.Drawing.Point(112, 98);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(101, 38);
            this.btn_GirisYap.TabIndex = 4;
            this.btn_GirisYap.TabStop = false;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.BtnGirisYapClick);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Sifre.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Sifre.BasamakSayisi = 0;
            this.textBox_Sifre.BorderColor = System.Drawing.Color.Crimson;
            this.textBox_Sifre.BorderFocusColor = System.Drawing.Color.PaleVioletRed;
            this.textBox_Sifre.BorderSize = 2;
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox_Sifre.ForeColor = System.Drawing.Color.Black;
            this.textBox_Sifre.HepsiBuyuk = false;
            this.textBox_Sifre.Location = new System.Drawing.Point(114, 47);
            this.textBox_Sifre.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.textBox_Sifre.MaxKarakter = 0;
            this.textBox_Sifre.MaxValue = 0D;
            this.textBox_Sifre.MinValue = 0D;
            this.textBox_Sifre.Multiline = false;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.OzelKarakterYasak = false;
            this.textBox_Sifre.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_Sifre.PasswordChar = true;
            this.textBox_Sifre.SadeceIngilizceKarakter = false;
            this.textBox_Sifre.Sayi = false;
            this.textBox_Sifre.Size = new System.Drawing.Size(101, 33);
            this.textBox_Sifre.TabIndex = 3;
            this.textBox_Sifre.TamSayi = false;
            this.textBox_Sifre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_Sifre.Texts = "";
            this.textBox_Sifre.TumunuSec = false;
            this.textBox_Sifre.UnderlinedStyle = false;
            this.textBox_Sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Sifre_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre:";
            // 
            // textBox_Kullanici_Adi
            // 
            this.textBox_Kullanici_Adi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Kullanici_Adi.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Kullanici_Adi.BasamakSayisi = 0;
            this.textBox_Kullanici_Adi.BorderColor = System.Drawing.Color.Crimson;
            this.textBox_Kullanici_Adi.BorderFocusColor = System.Drawing.Color.PaleVioletRed;
            this.textBox_Kullanici_Adi.BorderSize = 2;
            this.textBox_Kullanici_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox_Kullanici_Adi.ForeColor = System.Drawing.Color.Black;
            this.textBox_Kullanici_Adi.HepsiBuyuk = false;
            this.textBox_Kullanici_Adi.Location = new System.Drawing.Point(114, 0);
            this.textBox_Kullanici_Adi.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.textBox_Kullanici_Adi.MaxKarakter = 0;
            this.textBox_Kullanici_Adi.MaxValue = 0D;
            this.textBox_Kullanici_Adi.MinValue = 0D;
            this.textBox_Kullanici_Adi.Multiline = false;
            this.textBox_Kullanici_Adi.Name = "textBox_Kullanici_Adi";
            this.textBox_Kullanici_Adi.OzelKarakterYasak = false;
            this.textBox_Kullanici_Adi.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_Kullanici_Adi.PasswordChar = false;
            this.textBox_Kullanici_Adi.SadeceIngilizceKarakter = false;
            this.textBox_Kullanici_Adi.Sayi = false;
            this.textBox_Kullanici_Adi.Size = new System.Drawing.Size(101, 33);
            this.textBox_Kullanici_Adi.TabIndex = 2;
            this.textBox_Kullanici_Adi.TamSayi = false;
            this.textBox_Kullanici_Adi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_Kullanici_Adi.Texts = "";
            this.textBox_Kullanici_Adi.TumunuSec = false;
            this.textBox_Kullanici_Adi.UnderlinedStyle = false;
            this.textBox_Kullanici_Adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Kullanici_Adi_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // GirisForm_GirisMenusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Scada.Properties.Settings.Default.GirisMenusuArkaPlan;
            this.ClientSize = new System.Drawing.Size(1844, 995);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Scada.Properties.Settings.Default, "GirisMenusuArkaPlan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisForm_GirisMenusu";
            this.Text = "GirisForm_GirisMenusu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private CustomShapeButton btn_GirisYap;
        private UI.FormattedTextbox textBox_Sifre;
        private System.Windows.Forms.Label label3;
        private UI.FormattedTextbox textBox_Kullanici_Adi;
        private System.Windows.Forms.Label label2;
    }
}