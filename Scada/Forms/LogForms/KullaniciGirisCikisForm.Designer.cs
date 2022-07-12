
namespace Scada.Forms.LogForms
{
    partial class KullaniciGirisCikisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GirisCikisLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normFeedDBDataset1 = new Scada.NormFeedDBDataset();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_filtreleme = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbl_UsersTableAdapter = new Scada.NormFeedDBDatasetTableAdapters.tbl_UsersTableAdapter();
            this.view_GirisCikisLogTableAdapter = new Scada.NormFeedDBDatasetTableAdapters.View_GirisCikisLogTableAdapter();
            this.Filter_textbox = new Scada.UI.FormattedTextbox();
            this.btn_filtreleme = new Scada.ToggleButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giris_Cikis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirisCikisLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KullaniciAdi,
            this.UserRole,
            this.Giris_Cikis,
            this.Zaman});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.GirisCikisLogBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.NullValue = "####";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(55, 121);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1775, 910);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // GirisCikisLogBindingSource
            // 
            this.GirisCikisLogBindingSource.DataMember = "View_GirisCikisLog";
            this.GirisCikisLogBindingSource.DataSource = this.normFeedDBDataset1;
            this.GirisCikisLogBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.GirisCikisLogBindingSource_ListChanged);
            // 
            // normFeedDBDataset1
            // 
            this.normFeedDBDataset1.DataSetName = "NormFeedDBDataset";
            this.normFeedDBDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.normFeedDBDataset1;
            // 
            // lbl_filtreleme
            // 
            this.lbl_filtreleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtreleme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_filtreleme.Location = new System.Drawing.Point(590, 44);
            this.lbl_filtreleme.Name = "lbl_filtreleme";
            this.lbl_filtreleme.Size = new System.Drawing.Size(106, 55);
            this.lbl_filtreleme.TabIndex = 7;
            this.lbl_filtreleme.Text = "Filtreleme\r\nKapalı";
            this.lbl_filtreleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 29);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 29);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // view_GirisCikisLogTableAdapter
            // 
            this.view_GirisCikisLogTableAdapter.ClearBeforeFill = true;
            // 
            // Filter_textbox
            // 
            this.Filter_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Filter_textbox.BasamakSayisi = 0;
            this.Filter_textbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Filter_textbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Filter_textbox.BorderSize = 2;
            this.Filter_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.Filter_textbox.HepsiBuyuk = false;
            this.Filter_textbox.Location = new System.Drawing.Point(825, 56);
            this.Filter_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Filter_textbox.MaxKarakter = 0;
            this.Filter_textbox.MaxValue = 0D;
            this.Filter_textbox.MinValue = 0D;
            this.Filter_textbox.Multiline = false;
            this.Filter_textbox.Name = "Filter_textbox";
            this.Filter_textbox.OzelKarakterYasak = false;
            this.Filter_textbox.Padding = new System.Windows.Forms.Padding(7);
            this.Filter_textbox.PasswordChar = false;
            this.Filter_textbox.SadeceIngilizceKarakter = false;
            this.Filter_textbox.Sayi = false;
            this.Filter_textbox.Size = new System.Drawing.Size(234, 31);
            this.Filter_textbox.TabIndex = 8;
            this.Filter_textbox.TamSayi = false;
            this.Filter_textbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Filter_textbox.Texts = "";
            this.Filter_textbox.TumunuSec = false;
            this.Filter_textbox.UnderlinedStyle = false;
            this.Filter_textbox.Visible = false;
            this.Filter_textbox._TextChanged += new System.EventHandler(this.Filter_textbox__TextChanged);
            // 
            // btn_filtreleme
            // 
            this.btn_filtreleme.Location = new System.Drawing.Point(702, 51);
            this.btn_filtreleme.MinimumSize = new System.Drawing.Size(45, 22);
            this.btn_filtreleme.Name = "btn_filtreleme";
            this.btn_filtreleme.OffBackColor = System.Drawing.Color.Gray;
            this.btn_filtreleme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btn_filtreleme.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_filtreleme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btn_filtreleme.Size = new System.Drawing.Size(78, 40);
            this.btn_filtreleme.TabIndex = 6;
            this.btn_filtreleme.Text = "toggleButton1";
            this.btn_filtreleme.UseVisualStyleBackColor = true;
            this.btn_filtreleme.CheckedChanged += new System.EventHandler(this.btn_filtreleme_CheckedChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KullaniciAdi.DataPropertyName = "KullaniciAdi";
            this.KullaniciAdi.HeaderText = "KullaniciAdi";
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.ReadOnly = true;
            // 
            // UserRole
            // 
            this.UserRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRole.DataPropertyName = "UserRole";
            this.UserRole.HeaderText = "UserRole";
            this.UserRole.Name = "UserRole";
            this.UserRole.ReadOnly = true;
            this.UserRole.Visible = false;
            // 
            // Giris_Cikis
            // 
            this.Giris_Cikis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Giris_Cikis.DataPropertyName = "Giris_Cikis";
            this.Giris_Cikis.HeaderText = "Giris_Cikis";
            this.Giris_Cikis.Name = "Giris_Cikis";
            this.Giris_Cikis.ReadOnly = true;
            this.Giris_Cikis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Giris_Cikis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zaman
            // 
            this.Zaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zaman.DataPropertyName = "Zaman";
            this.Zaman.HeaderText = "Zaman";
            this.Zaman.Name = "Zaman";
            this.Zaman.ReadOnly = true;
            // 
            // KullaniciGirisCikisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1864, 1080);
            this.Controls.Add(this.Filter_textbox);
            this.Controls.Add(this.lbl_filtreleme);
            this.Controls.Add(this.btn_filtreleme);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciGirisCikisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormErrorLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciGirisCikisForm_Load);
            this.Shown += new System.EventHandler(this.KullaniciGirisCikisForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirisCikisLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private NormFeedDBDataset normFeedDBDataset1;
        private ToggleButton btn_filtreleme;
        private System.Windows.Forms.Label lbl_filtreleme;
        private System.Windows.Forms.BindingSource GirisCikisLogBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private UI.FormattedTextbox Filter_textbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagridViewColumnStartByte;
        private NormFeedDBDatasetTableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private NormFeedDBDatasetTableAdapters.View_GirisCikisLogTableAdapter view_GirisCikisLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giris_Cikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaman;
    }
}