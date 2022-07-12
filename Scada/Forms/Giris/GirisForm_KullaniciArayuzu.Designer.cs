
namespace Scada
{
    partial class GirisForm_KullaniciArayuzu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_usertype = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SifreDegistir = new Scada.CustomShapeButton();
            this.btn_CikisYap = new Scada.CustomShapeButton();
            this.view_GirisCikisLogTableAdapter1 = new Scada.NormFeedDBDatasetTableAdapters.View_GirisCikisLogTableAdapter();
            this.CevrimiciUsersbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normFeedDBDataset1 = new Scada.NormFeedDBDataset();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CevrimiciUsersbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Türü:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(253, 103);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(111, 20);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Kullanıcı Adı:";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_usertype
            // 
            this.lbl_usertype.AutoSize = true;
            this.lbl_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usertype.Location = new System.Drawing.Point(253, 149);
            this.lbl_usertype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usertype.Name = "lbl_usertype";
            this.lbl_usertype.Size = new System.Drawing.Size(111, 20);
            this.lbl_usertype.TabIndex = 4;
            this.lbl_usertype.Text = "Kullanıcı Adı:";
            this.lbl_usertype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(253, 191);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(111, 20);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Kullanıcı Adı:";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oturum Çıkış Süresi:";
            // 
            // btn_SifreDegistir
            // 
            this.btn_SifreDegistir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_SifreDegistir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SifreDegistir.BorderRadius = 40;
            this.btn_SifreDegistir.BorderSize = 0;
            this.btn_SifreDegistir.FlatAppearance.BorderSize = 0;
            this.btn_SifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SifreDegistir.ForeColor = System.Drawing.Color.White;
            this.btn_SifreDegistir.Location = new System.Drawing.Point(257, 241);
            this.btn_SifreDegistir.Name = "btn_SifreDegistir";
            this.btn_SifreDegistir.Size = new System.Drawing.Size(107, 51);
            this.btn_SifreDegistir.TabIndex = 8;
            this.btn_SifreDegistir.Text = "Şifre Değiştir";
            this.btn_SifreDegistir.UseVisualStyleBackColor = false;
            this.btn_SifreDegistir.Click += new System.EventHandler(this.btn_SifreDegistir_Click);
            // 
            // btn_CikisYap
            // 
            this.btn_CikisYap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_CikisYap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CikisYap.BorderRadius = 40;
            this.btn_CikisYap.BorderSize = 0;
            this.btn_CikisYap.FlatAppearance.BorderSize = 0;
            this.btn_CikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CikisYap.ForeColor = System.Drawing.Color.White;
            this.btn_CikisYap.Location = new System.Drawing.Point(257, 310);
            this.btn_CikisYap.Name = "btn_CikisYap";
            this.btn_CikisYap.Size = new System.Drawing.Size(107, 51);
            this.btn_CikisYap.TabIndex = 5;
            this.btn_CikisYap.Text = "Çıkış Yap";
            this.btn_CikisYap.UseVisualStyleBackColor = false;
            this.btn_CikisYap.Click += new System.EventHandler(this.btn_CikisYap_Click);
            // 
            // view_GirisCikisLogTableAdapter1
            // 
            this.view_GirisCikisLogTableAdapter1.ClearBeforeFill = true;
            // 
            // CevrimiciUsersbindingSource
            // 
            this.CevrimiciUsersbindingSource.DataMember = "View_GirisCikisLog";
            this.CevrimiciUsersbindingSource.DataSource = this.normFeedDBDataset1;
            // 
            // normFeedDBDataset1
            // 
            this.normFeedDBDataset1.DataSetName = "NormFeedDBDataset";
            this.normFeedDBDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.listBox1.ForeColor = System.Drawing.Color.LightGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(536, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(188, 104);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.listBox2.ForeColor = System.Drawing.Color.Crimson;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(536, 257);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(188, 104);
            this.listBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(536, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Çevrimiçi Kullanıcılar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(536, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "Çevrimdışı Kullanıcılar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GirisForm_KullaniciArayuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Scada.Properties.Settings.Default.GirisMenusuArkaPlan;
            this.ClientSize = new System.Drawing.Size(1844, 995);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_SifreDegistir);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CikisYap);
            this.Controls.Add(this.lbl_usertype);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Scada.Properties.Settings.Default, "GirisMenusuArkaPlan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GirisForm_KullaniciArayuzu";
            this.Text = "GirisForm_KullaniciArayuzu";
            this.Load += new System.EventHandler(this.GirisForm_KullaniciArayuzu_Load);
            this.VisibleChanged += new System.EventHandler(this.GirisForm_KullaniciArayuzu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.CevrimiciUsersbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_usertype;
        private CustomShapeButton btn_CikisYap;
        private System.Windows.Forms.Label label4;
        private CustomShapeButton btn_SifreDegistir;
        protected internal System.Windows.Forms.Label lbl_time;
        private NormFeedDBDatasetTableAdapters.View_GirisCikisLogTableAdapter view_GirisCikisLogTableAdapter1;
        private System.Windows.Forms.BindingSource CevrimiciUsersbindingSource;
        private NormFeedDBDataset normFeedDBDataset1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}