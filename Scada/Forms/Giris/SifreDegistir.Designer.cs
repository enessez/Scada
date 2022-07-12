
namespace Scada.Forms.Giris
{
    partial class SifreDegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>panel1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customShapeButton1 = new Scada.CustomShapeButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_usertype = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_SifreDegistir = new Scada.CustomShapeButton();
            this.textbox_YeniSifre_tekrar = new Scada.UI.FormattedTextbox();
            this.textbox_YeniSifre = new Scada.UI.FormattedTextbox();
            this.textbox_EskiSifre = new Scada.UI.FormattedTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.customShapeButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 33);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SifreDegistir_MouseDown);
            // 
            // customShapeButton1
            // 
            this.customShapeButton1.BackColor = System.Drawing.Color.Transparent;
            this.customShapeButton1.BackgroundImage = global::Scada.Properties.Resources.icons8_Close_64px;
            this.customShapeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customShapeButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customShapeButton1.BorderRadius = 0;
            this.customShapeButton1.BorderSize = 0;
            this.customShapeButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customShapeButton1.FlatAppearance.BorderSize = 0;
            this.customShapeButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customShapeButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.customShapeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customShapeButton1.ForeColor = System.Drawing.Color.White;
            this.customShapeButton1.Location = new System.Drawing.Point(440, 0);
            this.customShapeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.customShapeButton1.Name = "customShapeButton1";
            this.customShapeButton1.Size = new System.Drawing.Size(33, 33);
            this.customShapeButton1.TabIndex = 0;
            this.customShapeButton1.UseVisualStyleBackColor = false;
            this.customShapeButton1.Click += new System.EventHandler(this.customShapeButton1_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(33, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "Şifre Değiştirme";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SifreDegistir_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_username.Location = new System.Drawing.Point(220, 83);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(241, 24);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "123456789012345678901";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_usertype
            // 
            this.lbl_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usertype.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usertype.Location = new System.Drawing.Point(220, 127);
            this.lbl_usertype.Name = "lbl_usertype";
            this.lbl_usertype.Size = new System.Drawing.Size(230, 36);
            this.lbl_usertype.TabIndex = 5;
            this.lbl_usertype.Text = "label3";
            this.lbl_usertype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(45, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Türü:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(92, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eski Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(89, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yeni Şifre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yeni Şifre (Tekrar):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(223, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "21 karakter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // btn_SifreDegistir
            // 
            this.btn_SifreDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_SifreDegistir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btn_SifreDegistir.BorderRadius = 25;
            this.btn_SifreDegistir.BorderSize = 0;
            this.btn_SifreDegistir.FlatAppearance.BorderSize = 0;
            this.btn_SifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SifreDegistir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SifreDegistir.Location = new System.Drawing.Point(320, 342);
            this.btn_SifreDegistir.Name = "btn_SifreDegistir";
            this.btn_SifreDegistir.Size = new System.Drawing.Size(104, 49);
            this.btn_SifreDegistir.TabIndex = 12;
            this.btn_SifreDegistir.Text = "Şifre Değiştir";
            this.btn_SifreDegistir.UseVisualStyleBackColor = false;
            this.btn_SifreDegistir.Click += new System.EventHandler(this.btn_SifreDegistir_Click);
            // 
            // textbox_YeniSifre_tekrar
            // 
            this.textbox_YeniSifre_tekrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textbox_YeniSifre_tekrar.BasamakSayisi = 0;
            this.textbox_YeniSifre_tekrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(83)))), ((int)(((byte)(230)))));
            this.textbox_YeniSifre_tekrar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.textbox_YeniSifre_tekrar.BorderSize = 3;
            this.textbox_YeniSifre_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_YeniSifre_tekrar.ForeColor = System.Drawing.Color.White;
            this.textbox_YeniSifre_tekrar.HepsiBuyuk = false;
            this.textbox_YeniSifre_tekrar.Location = new System.Drawing.Point(220, 288);
            this.textbox_YeniSifre_tekrar.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_YeniSifre_tekrar.MaxKarakter = 0;
            this.textbox_YeniSifre_tekrar.MaxValue = 0D;
            this.textbox_YeniSifre_tekrar.MinValue = 0D;
            this.textbox_YeniSifre_tekrar.Multiline = false;
            this.textbox_YeniSifre_tekrar.Name = "textbox_YeniSifre_tekrar";
            this.textbox_YeniSifre_tekrar.OzelKarakterYasak = false;
            this.textbox_YeniSifre_tekrar.Padding = new System.Windows.Forms.Padding(7);
            this.textbox_YeniSifre_tekrar.PasswordChar = true;
            this.textbox_YeniSifre_tekrar.SadeceIngilizceKarakter = false;
            this.textbox_YeniSifre_tekrar.Sayi = false;
            this.textbox_YeniSifre_tekrar.Size = new System.Drawing.Size(201, 33);
            this.textbox_YeniSifre_tekrar.TabIndex = 10;
            this.textbox_YeniSifre_tekrar.TamSayi = false;
            this.textbox_YeniSifre_tekrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_YeniSifre_tekrar.Texts = "";
            this.textbox_YeniSifre_tekrar.TumunuSec = false;
            this.textbox_YeniSifre_tekrar.UnderlinedStyle = true;
            this.textbox_YeniSifre_tekrar._TextChanged += new System.EventHandler(this.formattedTextbox3__TextChanged);
            this.textbox_YeniSifre_tekrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formattedTextbox3_KeyDown);
            // 
            // textbox_YeniSifre
            // 
            this.textbox_YeniSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textbox_YeniSifre.BasamakSayisi = 0;
            this.textbox_YeniSifre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(83)))), ((int)(((byte)(230)))));
            this.textbox_YeniSifre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.textbox_YeniSifre.BorderSize = 3;
            this.textbox_YeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_YeniSifre.ForeColor = System.Drawing.Color.White;
            this.textbox_YeniSifre.HepsiBuyuk = false;
            this.textbox_YeniSifre.Location = new System.Drawing.Point(220, 243);
            this.textbox_YeniSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_YeniSifre.MaxKarakter = 0;
            this.textbox_YeniSifre.MaxValue = 0D;
            this.textbox_YeniSifre.MinValue = 0D;
            this.textbox_YeniSifre.Multiline = false;
            this.textbox_YeniSifre.Name = "textbox_YeniSifre";
            this.textbox_YeniSifre.OzelKarakterYasak = false;
            this.textbox_YeniSifre.Padding = new System.Windows.Forms.Padding(7);
            this.textbox_YeniSifre.PasswordChar = true;
            this.textbox_YeniSifre.SadeceIngilizceKarakter = false;
            this.textbox_YeniSifre.Sayi = false;
            this.textbox_YeniSifre.Size = new System.Drawing.Size(201, 33);
            this.textbox_YeniSifre.TabIndex = 8;
            this.textbox_YeniSifre.TamSayi = false;
            this.textbox_YeniSifre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_YeniSifre.Texts = "";
            this.textbox_YeniSifre.TumunuSec = false;
            this.textbox_YeniSifre.UnderlinedStyle = true;
            this.textbox_YeniSifre._TextChanged += new System.EventHandler(this.formattedTextbox2__TextChanged);
            this.textbox_YeniSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formattedTextbox2_KeyDown);
            this.textbox_YeniSifre.Leave += new System.EventHandler(this.formattedTextbox2_Leave);
            // 
            // textbox_EskiSifre
            // 
            this.textbox_EskiSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textbox_EskiSifre.BasamakSayisi = 0;
            this.textbox_EskiSifre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(83)))), ((int)(((byte)(230)))));
            this.textbox_EskiSifre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.textbox_EskiSifre.BorderSize = 3;
            this.textbox_EskiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_EskiSifre.ForeColor = System.Drawing.Color.White;
            this.textbox_EskiSifre.HepsiBuyuk = false;
            this.textbox_EskiSifre.Location = new System.Drawing.Point(220, 193);
            this.textbox_EskiSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_EskiSifre.MaxKarakter = 0;
            this.textbox_EskiSifre.MaxValue = 0D;
            this.textbox_EskiSifre.MinValue = 0D;
            this.textbox_EskiSifre.Multiline = false;
            this.textbox_EskiSifre.Name = "textbox_EskiSifre";
            this.textbox_EskiSifre.OzelKarakterYasak = false;
            this.textbox_EskiSifre.Padding = new System.Windows.Forms.Padding(7);
            this.textbox_EskiSifre.PasswordChar = true;
            this.textbox_EskiSifre.SadeceIngilizceKarakter = false;
            this.textbox_EskiSifre.Sayi = false;
            this.textbox_EskiSifre.Size = new System.Drawing.Size(201, 33);
            this.textbox_EskiSifre.TabIndex = 6;
            this.textbox_EskiSifre.TamSayi = false;
            this.textbox_EskiSifre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_EskiSifre.Texts = "";
            this.textbox_EskiSifre.TumunuSec = false;
            this.textbox_EskiSifre.UnderlinedStyle = true;
            this.textbox_EskiSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formattedTextbox1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Scada.Properties.Resources.icons8_error_128px;
            this.pictureBox1.Location = new System.Drawing.Point(429, 288);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(473, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_SifreDegistir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_YeniSifre_tekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_YeniSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_EskiSifre);
            this.Controls.Add(this.lbl_usertype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomShapeButton customShapeButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private UI.FormattedTextbox textbox_EskiSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UI.FormattedTextbox textbox_YeniSifre;
        private System.Windows.Forms.Label label5;
        private UI.FormattedTextbox textbox_YeniSifre_tekrar;
        private CustomShapeButton btn_SifreDegistir;
        protected internal System.Windows.Forms.Label lbl_username;
        protected internal System.Windows.Forms.Label lbl_usertype;
        protected internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
    }
}