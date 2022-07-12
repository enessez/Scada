
namespace Scada.Forms.ErrorLog
{
    partial class FormErrorLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorDegerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridViewColumnStartByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridViewColumnBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridViewColumnDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridViewColumnDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewErrorLogErrorAdiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normFeedDBDataset1 = new Scada.NormFeedDBDataset();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_filtreleme = new System.Windows.Forms.Label();
            this.viewErrorLogGelismisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ErrorLog_ErrorAdiTableAdapter = new Scada.NormFeedDBDatasetTableAdapters.View_ErrorLog_ErrorAdiTableAdapter();
            this.view_ErrorLogGelismisTableAdapter = new Scada.NormFeedDBDatasetTableAdapters.View_ErrorLogGelismisTableAdapter();
            this.tblErrorTagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ErrorTagsTableAdapter = new Scada.NormFeedDBDatasetTableAdapters.tbl_ErrorTagsTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tableAdapterManager = new Scada.NormFeedDBDatasetTableAdapters.TableAdapterManager();
            this.Filter_textbox = new Scada.UI.FormattedTextbox();
            this.btn_filtreleme = new Scada.ToggleButton();
            this.TumLoglar_toggleButton = new Scada.ToggleButton();
            this.GelismisGosterim_toggleButton = new Scada.ToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewErrorLogErrorAdiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewErrorLogGelismisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblErrorTagsBindingSource)).BeginInit();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.IdDataGridViewTextBoxColumn,
            this.errorAdiDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.errorDegerDataGridViewCheckBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.DatagridViewColumnStartByte,
            this.DatagridViewColumnBit,
            this.DatagridViewColumnDB,
            this.DatagridViewColumnDataType});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.viewErrorLogErrorAdiBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = "####";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(55, 190);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1775, 841);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            dataGridViewCellStyle6.Format = "G";
            dataGridViewCellStyle6.NullValue = null;
            this.dateTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdDataGridViewTextBoxColumn
            // 
            this.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.IdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn";
            this.IdDataGridViewTextBoxColumn.ReadOnly = true;
            this.IdDataGridViewTextBoxColumn.Visible = false;
            // 
            // errorAdiDataGridViewTextBoxColumn
            // 
            this.errorAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errorAdiDataGridViewTextBoxColumn.DataPropertyName = "ErrorAdi";
            this.errorAdiDataGridViewTextBoxColumn.HeaderText = "ErrorAdi";
            this.errorAdiDataGridViewTextBoxColumn.Name = "errorAdiDataGridViewTextBoxColumn";
            this.errorAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorDegerDataGridViewCheckBoxColumn
            // 
            this.errorDegerDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errorDegerDataGridViewCheckBoxColumn.DataPropertyName = "ErrorDeger";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.errorDegerDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.errorDegerDataGridViewCheckBoxColumn.HeaderText = "ErrorDeger";
            this.errorDegerDataGridViewCheckBoxColumn.Name = "errorDegerDataGridViewCheckBoxColumn";
            this.errorDegerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.errorDegerDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.errorDegerDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.errorDegerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciAdiDataGridViewTextBoxColumn.Visible = false;
            // 
            // DatagridViewColumnStartByte
            // 
            this.DatagridViewColumnStartByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatagridViewColumnStartByte.DataPropertyName = "StartByteAddress";
            this.DatagridViewColumnStartByte.HeaderText = "Baslangic Byte";
            this.DatagridViewColumnStartByte.Name = "DatagridViewColumnStartByte";
            this.DatagridViewColumnStartByte.ReadOnly = true;
            this.DatagridViewColumnStartByte.Visible = false;
            // 
            // DatagridViewColumnBit
            // 
            this.DatagridViewColumnBit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatagridViewColumnBit.HeaderText = "Bit Adresi";
            this.DatagridViewColumnBit.Name = "DatagridViewColumnBit";
            this.DatagridViewColumnBit.ReadOnly = true;
            this.DatagridViewColumnBit.Visible = false;
            // 
            // DatagridViewColumnDB
            // 
            this.DatagridViewColumnDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatagridViewColumnDB.HeaderText = "DB Numarasi";
            this.DatagridViewColumnDB.Name = "DatagridViewColumnDB";
            this.DatagridViewColumnDB.ReadOnly = true;
            this.DatagridViewColumnDB.Visible = false;
            // 
            // DatagridViewColumnDataType
            // 
            this.DatagridViewColumnDataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatagridViewColumnDataType.HeaderText = "Data Tipi";
            this.DatagridViewColumnDataType.Name = "DatagridViewColumnDataType";
            this.DatagridViewColumnDataType.ReadOnly = true;
            this.DatagridViewColumnDataType.Visible = false;
            // 
            // viewErrorLogErrorAdiBindingSource
            // 
            this.viewErrorLogErrorAdiBindingSource.DataMember = "View_ErrorLog_ErrorAdi";
            this.viewErrorLogErrorAdiBindingSource.DataSource = this.normFeedDBDataset1;
            this.viewErrorLogErrorAdiBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.viewErrorLogGelismisBindingSource_ListChanged);
            // 
            // normFeedDBDataset1
            // 
            this.normFeedDBDataset1.DataSetName = "NormFeedDBDataset";
            this.normFeedDBDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aktif Alarmlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_filtreleme
            // 
            this.lbl_filtreleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtreleme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_filtreleme.Location = new System.Drawing.Point(56, 110);
            this.lbl_filtreleme.Name = "lbl_filtreleme";
            this.lbl_filtreleme.Size = new System.Drawing.Size(115, 55);
            this.lbl_filtreleme.TabIndex = 7;
            this.lbl_filtreleme.Text = "Filtreleme\r\nKapalı";
            this.lbl_filtreleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewErrorLogGelismisBindingSource
            // 
            this.viewErrorLogGelismisBindingSource.DataMember = "View_ErrorLogGelismis";
            this.viewErrorLogGelismisBindingSource.DataSource = this.normFeedDBDataset1;
            this.viewErrorLogGelismisBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.viewErrorLogGelismisBindingSource_ListChanged);
            // 
            // view_ErrorLog_ErrorAdiTableAdapter
            // 
            this.view_ErrorLog_ErrorAdiTableAdapter.ClearBeforeFill = true;
            // 
            // view_ErrorLogGelismisTableAdapter
            // 
            this.view_ErrorLogGelismisTableAdapter.ClearBeforeFill = true;
            // 
            // tblErrorTagsBindingSource
            // 
            this.tblErrorTagsBindingSource.DataMember = "tbl_ErrorTags";
            this.tblErrorTagsBindingSource.DataSource = this.normFeedDBDataset1;
            // 
            // tbl_ErrorTagsTableAdapter
            // 
            this.tbl_ErrorTagsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 52);
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
            this.dateTimePicker2.Location = new System.Drawing.Point(569, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 29);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_DataTypesTableAdapter = null;
            this.tableAdapterManager.tbl_ErrorLogTableAdapter = null;
            this.tableAdapterManager.tbl_ErrorTagsTableAdapter = this.tbl_ErrorTagsTableAdapter;
            this.tableAdapterManager.tbl_UserGirisCikisLogTableAdapter = null;
            this.tableAdapterManager.tbl_UserRolesTableAdapter = null;
            this.tableAdapterManager.tbl_UsersTableAdapter = null;
            this.tableAdapterManager.tbl_VarTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Scada.NormFeedDBDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.Filter_textbox.Location = new System.Drawing.Point(310, 122);
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
            this.btn_filtreleme.Location = new System.Drawing.Point(187, 120);
            this.btn_filtreleme.MinimumSize = new System.Drawing.Size(45, 22);
            this.btn_filtreleme.Name = "btn_filtreleme";
            this.btn_filtreleme.OffBackColor = System.Drawing.Color.Gray;
            this.btn_filtreleme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btn_filtreleme.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_filtreleme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btn_filtreleme.Size = new System.Drawing.Size(78, 35);
            this.btn_filtreleme.TabIndex = 6;
            this.btn_filtreleme.Text = "toggleButton1";
            this.btn_filtreleme.UseVisualStyleBackColor = true;
            this.btn_filtreleme.CheckedChanged += new System.EventHandler(this.btn_filtreleme_CheckedChanged);
            // 
            // TumLoglar_toggleButton
            // 
            this.TumLoglar_toggleButton.Location = new System.Drawing.Point(187, 49);
            this.TumLoglar_toggleButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.TumLoglar_toggleButton.Name = "TumLoglar_toggleButton";
            this.TumLoglar_toggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.TumLoglar_toggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.TumLoglar_toggleButton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TumLoglar_toggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TumLoglar_toggleButton.Size = new System.Drawing.Size(78, 35);
            this.TumLoglar_toggleButton.TabIndex = 2;
            this.TumLoglar_toggleButton.Text = "toggleButton2";
            this.TumLoglar_toggleButton.UseVisualStyleBackColor = true;
            this.TumLoglar_toggleButton.CheckedChanged += new System.EventHandler(this.TumLoglar_toggleButton_CheckedChanged);
            // 
            // GelismisGosterim_toggleButton
            // 
            this.GelismisGosterim_toggleButton.Location = new System.Drawing.Point(878, 47);
            this.GelismisGosterim_toggleButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.GelismisGosterim_toggleButton.Name = "GelismisGosterim_toggleButton";
            this.GelismisGosterim_toggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.GelismisGosterim_toggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.GelismisGosterim_toggleButton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GelismisGosterim_toggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.GelismisGosterim_toggleButton.Size = new System.Drawing.Size(78, 37);
            this.GelismisGosterim_toggleButton.TabIndex = 1;
            this.GelismisGosterim_toggleButton.Text = "toggleButton1";
            this.GelismisGosterim_toggleButton.UseVisualStyleBackColor = true;
            this.GelismisGosterim_toggleButton.Visible = false;
            this.GelismisGosterim_toggleButton.CheckedChanged += new System.EventHandler(this.GelismisGosterim_CheckedChanged);
            // 
            // FormErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1864, 1080);
            this.Controls.Add(this.Filter_textbox);
            this.Controls.Add(this.lbl_filtreleme);
            this.Controls.Add(this.btn_filtreleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TumLoglar_toggleButton);
            this.Controls.Add(this.GelismisGosterim_toggleButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormErrorLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormErrorLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormErrorLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewErrorLogErrorAdiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normFeedDBDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewErrorLogGelismisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblErrorTagsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewErrorLogErrorAdiBindingSource;
        private NormFeedDBDatasetTableAdapters.View_ErrorLog_ErrorAdiTableAdapter view_ErrorLog_ErrorAdiTableAdapter;
        private System.Windows.Forms.BindingSource viewErrorLogGelismisBindingSource;
        private NormFeedDBDataset normFeedDBDataset1;
        private NormFeedDBDatasetTableAdapters.View_ErrorLogGelismisTableAdapter view_ErrorLogGelismisTableAdapter;
        private ToggleButton GelismisGosterim_toggleButton;
        private ToggleButton TumLoglar_toggleButton;
        private System.Windows.Forms.Label label1;
        private ToggleButton btn_filtreleme;
        private System.Windows.Forms.Label lbl_filtreleme;
        private System.Windows.Forms.BindingSource tblErrorTagsBindingSource;
        private NormFeedDBDatasetTableAdapters.tbl_ErrorTagsTableAdapter tbl_ErrorTagsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private UI.FormattedTextbox Filter_textbox;
        private NormFeedDBDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagridViewColumnStartByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagridViewColumnBit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagridViewColumnDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagridViewColumnDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDegerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
    }
}