
namespace Scada
{
    partial class FormRecete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idLabel = new System.Windows.Forms.Label();
            this.recete_AdLabel = new System.Windows.Forms.Label();
            this.urun_AdiLabel = new System.Windows.Forms.Label();
            this.kategoriLabel = new System.Windows.Forms.Label();
            this.yuzdeLabel = new System.Windows.Forms.Label();
            this.ReceteYoluDİalog = new System.Windows.Forms.FolderBrowserDialog();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.recete_AdTextBox = new System.Windows.Forms.TextBox();
            this.tabloFullDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.UrunDegisimContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UrunSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuReceteEkleSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buReçeteyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniReçeteEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecetelerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labeloran = new System.Windows.Forms.Label();
            this.AnaTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxYag = new System.Windows.Forms.CheckBox();
            this.checkBoxKatki = new System.Windows.Forms.CheckBox();
            this.checkBoxHammadde = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabloFullDataGridView)).BeginInit();
            this.UrunDegisimContextMenu.SuspendLayout();
            this.ContextMenuReceteEkleSil.SuspendLayout();
            this.RecetelerTableLayout.SuspendLayout();
            this.AnaTableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(64, 305);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // recete_AdLabel
            // 
            this.recete_AdLabel.AutoSize = true;
            this.recete_AdLabel.Location = new System.Drawing.Point(12, 339);
            this.recete_AdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recete_AdLabel.Name = "recete_AdLabel";
            this.recete_AdLabel.Size = new System.Drawing.Size(89, 20);
            this.recete_AdLabel.TabIndex = 5;
            this.recete_AdLabel.Text = "Recete Ad:";
            this.recete_AdLabel.Visible = false;
            // 
            // urun_AdiLabel
            // 
            this.urun_AdiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urun_AdiLabel.Location = new System.Drawing.Point(0, 0);
            this.urun_AdiLabel.Margin = new System.Windows.Forms.Padding(0);
            this.urun_AdiLabel.Name = "urun_AdiLabel";
            this.urun_AdiLabel.Size = new System.Drawing.Size(115, 32);
            this.urun_AdiLabel.TabIndex = 3;
            this.urun_AdiLabel.Text = "Urun Adi:";
            this.urun_AdiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kategoriLabel
            // 
            this.kategoriLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kategoriLabel.Location = new System.Drawing.Point(0, 32);
            this.kategoriLabel.Margin = new System.Windows.Forms.Padding(0);
            this.kategoriLabel.Name = "kategoriLabel";
            this.kategoriLabel.Size = new System.Drawing.Size(115, 32);
            this.kategoriLabel.TabIndex = 4;
            this.kategoriLabel.Text = "Kategori:";
            this.kategoriLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yuzdeLabel
            // 
            this.yuzdeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yuzdeLabel.Location = new System.Drawing.Point(0, 64);
            this.yuzdeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.yuzdeLabel.Name = "yuzdeLabel";
            this.yuzdeLabel.Size = new System.Drawing.Size(115, 32);
            this.yuzdeLabel.TabIndex = 5;
            this.yuzdeLabel.Text = "Yuzde:";
            this.yuzdeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceteYoluDİalog
            // 
            this.ReceteYoluDİalog.SelectedPath = "Z:\\\\";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(105, 305);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 26);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.Visible = false;
            // 
            // recete_AdTextBox
            // 
            this.recete_AdTextBox.Location = new System.Drawing.Point(105, 334);
            this.recete_AdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.recete_AdTextBox.Name = "recete_AdTextBox";
            this.recete_AdTextBox.Size = new System.Drawing.Size(104, 26);
            this.recete_AdTextBox.TabIndex = 2;
            this.recete_AdTextBox.Visible = false;
            // 
            // tabloFullDataGridView
            // 
            this.tabloFullDataGridView.AllowUserToAddRows = false;
            this.tabloFullDataGridView.AllowUserToDeleteRows = false;
            this.tabloFullDataGridView.AllowUserToResizeColumns = false;
            this.tabloFullDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabloFullDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabloFullDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabloFullDataGridView.CausesValidation = false;
            this.tabloFullDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabloFullDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabloFullDataGridView.ColumnHeadersHeight = 40;
            this.tabloFullDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabloFullDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabloFullDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabloFullDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tabloFullDataGridView.EnableHeadersVisualStyles = false;
            this.tabloFullDataGridView.Location = new System.Drawing.Point(0, 59);
            this.tabloFullDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.tabloFullDataGridView.MultiSelect = false;
            this.tabloFullDataGridView.Name = "tabloFullDataGridView";
            this.tabloFullDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabloFullDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabloFullDataGridView.RowHeadersVisible = false;
            this.tabloFullDataGridView.ShowCellToolTips = false;
            this.tabloFullDataGridView.ShowEditingIcon = false;
            this.tabloFullDataGridView.Size = new System.Drawing.Size(752, 429);
            this.tabloFullDataGridView.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSil.Location = new System.Drawing.Point(121, 0);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 48);
            this.btnSil.TabIndex = 0;
            this.btnSil.Tag = "";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSil, "Ürün Sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Green;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEkle.Location = new System.Drawing.Point(0, 48);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 48);
            this.btnEkle.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnEkle, "Ürün Ekle");
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuncelle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuncelle.Location = new System.Drawing.Point(121, 48);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(122, 48);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnGuncelle, "Ürün Güncelle");
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // UrunDegisimContextMenu
            // 
            this.UrunDegisimContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunSilToolStripMenuItem,
            this.değiştirToolStripMenuItem});
            this.UrunDegisimContextMenu.Name = "UrunDegisimContextMenu";
            this.UrunDegisimContextMenu.Size = new System.Drawing.Size(115, 48);
            // 
            // UrunSilToolStripMenuItem
            // 
            this.UrunSilToolStripMenuItem.Name = "UrunSilToolStripMenuItem";
            this.UrunSilToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.UrunSilToolStripMenuItem.Text = "Sil";
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            // 
            // ContextMenuReceteEkleSil
            // 
            this.ContextMenuReceteEkleSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buReçeteyiSilToolStripMenuItem,
            this.yeniReçeteEkleToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.ContextMenuReceteEkleSil.Name = "ContextMenuReceteEkleSil";
            this.ContextMenuReceteEkleSil.Size = new System.Drawing.Size(159, 70);
            // 
            // buReçeteyiSilToolStripMenuItem
            // 
            this.buReçeteyiSilToolStripMenuItem.Name = "buReçeteyiSilToolStripMenuItem";
            this.buReçeteyiSilToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buReçeteyiSilToolStripMenuItem.Text = "Bu Reçeteyi Sil";
            // 
            // yeniReçeteEkleToolStripMenuItem
            // 
            this.yeniReçeteEkleToolStripMenuItem.Name = "yeniReçeteEkleToolStripMenuItem";
            this.yeniReçeteEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yeniReçeteEkleToolStripMenuItem.Text = "Yeni Reçete Ekle";
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // RecetelerTableLayout
            // 
            this.RecetelerTableLayout.ColumnCount = 5;
            this.RecetelerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.RecetelerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.RecetelerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.RecetelerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.RecetelerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.RecetelerTableLayout.Controls.Add(this.labeloran, 4, 0);
            this.RecetelerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecetelerTableLayout.Location = new System.Drawing.Point(0, 26);
            this.RecetelerTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.RecetelerTableLayout.Name = "RecetelerTableLayout";
            this.RecetelerTableLayout.RowCount = 1;
            this.RecetelerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RecetelerTableLayout.Size = new System.Drawing.Size(752, 33);
            this.RecetelerTableLayout.TabIndex = 23;
            // 
            // labeloran
            // 
            this.labeloran.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labeloran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeloran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloran.Location = new System.Drawing.Point(717, 0);
            this.labeloran.Margin = new System.Windows.Forms.Padding(0);
            this.labeloran.Name = "labeloran";
            this.labeloran.Size = new System.Drawing.Size(35, 33);
            this.labeloran.TabIndex = 4;
            this.labeloran.Text = "label2";
            this.labeloran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnaTableLayout
            // 
            this.AnaTableLayout.ColumnCount = 1;
            this.AnaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AnaTableLayout.Controls.Add(this.RecetelerTableLayout, 0, 1);
            this.AnaTableLayout.Controls.Add(this.tabloFullDataGridView, 0, 2);
            this.AnaTableLayout.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.AnaTableLayout.Controls.Add(this.label1, 0, 0);
            this.AnaTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaTableLayout.Location = new System.Drawing.Point(0, 0);
            this.AnaTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.AnaTableLayout.Name = "AnaTableLayout";
            this.AnaTableLayout.RowCount = 4;
            this.AnaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.AnaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.AnaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AnaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.AnaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.AnaTableLayout.Size = new System.Drawing.Size(752, 590);
            this.AnaTableLayout.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 488);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(752, 102);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.92857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.07143F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.yuzdeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kategoriLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.urun_AdiLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(399, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(115, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 32);
            this.panel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(170, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 33);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(393, 96);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxYag);
            this.panel2.Controls.Add(this.checkBoxKatki);
            this.panel2.Controls.Add(this.checkBoxHammadde);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 96);
            this.panel2.TabIndex = 2;
            // 
            // checkBoxYag
            // 
            this.checkBoxYag.AutoSize = true;
            this.checkBoxYag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxYag.Location = new System.Drawing.Point(20, 63);
            this.checkBoxYag.Name = "checkBoxYag";
            this.checkBoxYag.Size = new System.Drawing.Size(63, 25);
            this.checkBoxYag.TabIndex = 2;
            this.checkBoxYag.Text = "Yağ";
            this.checkBoxYag.UseVisualStyleBackColor = true;
            // 
            // checkBoxKatki
            // 
            this.checkBoxKatki.AutoSize = true;
            this.checkBoxKatki.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxKatki.Location = new System.Drawing.Point(20, 36);
            this.checkBoxKatki.Name = "checkBoxKatki";
            this.checkBoxKatki.Size = new System.Drawing.Size(69, 25);
            this.checkBoxKatki.TabIndex = 1;
            this.checkBoxKatki.Text = "Katkı";
            this.checkBoxKatki.UseVisualStyleBackColor = true;
            // 
            // checkBoxHammadde
            // 
            this.checkBoxHammadde.AutoSize = true;
            this.checkBoxHammadde.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxHammadde.Location = new System.Drawing.Point(20, 9);
            this.checkBoxHammadde.Name = "checkBoxHammadde";
            this.checkBoxHammadde.Size = new System.Drawing.Size(117, 25);
            this.checkBoxHammadde.TabIndex = 0;
            this.checkBoxHammadde.Text = "Hammadde";
            this.checkBoxHammadde.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGuncelle, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEkle, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(150, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(243, 96);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 48);
            this.button2.TabIndex = 3;
            this.button2.Tag = "";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.button2, "Raporlar");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "NORMFEED SU ÜRÜNLERi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // FormRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 590);
            this.Controls.Add(this.AnaTableLayout);
            this.Controls.Add(this.recete_AdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.recete_AdLabel);
            this.Controls.Add(this.idLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(752, 590);
            this.Name = "FormRecete";
            ((System.ComponentModel.ISupportInitialize)(this.tabloFullDataGridView)).EndInit();
            this.UrunDegisimContextMenu.ResumeLayout(false);
            this.ContextMenuReceteEkleSil.ResumeLayout(false);
            this.RecetelerTableLayout.ResumeLayout(false);
            this.AnaTableLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog ReceteYoluDİalog;
        private UComboBox ComboboxReceteIsmi;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox recete_AdTextBox;
        private System.Windows.Forms.DataGridView tabloFullDataGridView;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip UrunDegisimContextMenu;
        private System.Windows.Forms.ToolStripMenuItem UrunSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuReceteEkleSil;
        private System.Windows.Forms.ToolStripMenuItem buReçeteyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniReçeteEkleToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel RecetelerTableLayout;
        private System.Windows.Forms.TableLayoutPanel AnaTableLayout;
        private ENTextBox KategoriTextBox;
        private ENTextBox yuzdeTextBox;
        private UComboBox UrunAdCombobox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxYag;
        private System.Windows.Forms.CheckBox checkBoxKatki;
        private System.Windows.Forms.CheckBox checkBoxHammadde;
        private System.Windows.Forms.Label labeloran;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label recete_AdLabel;
        private System.Windows.Forms.Label urun_AdiLabel;
        private System.Windows.Forms.Label kategoriLabel;
        private System.Windows.Forms.Label yuzdeLabel;
    }
}
