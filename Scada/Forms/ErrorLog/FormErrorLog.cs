using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Scada.AnaSayfa;

namespace Scada.Forms.ErrorLog
{
    public partial class FormErrorLog : Form
    {
        private FormMain main;
        private NormFeedDBDataset Maindataset;
        public EventHandler LogDegisti ;
        public FormErrorLog(FormMain _main,NormFeedDBDataset _dataset)
        {
            this.main = _main;
            this.Maindataset = _dataset;

            InitializeComponent();

            DatagridViewColumnStartByte.DataPropertyName = "StartByteAddress";
            DatagridViewColumnBit.DataPropertyName = "BitAddress";
            DatagridViewColumnDataType.DataPropertyName = "DataType";
            DatagridViewColumnDB.DataPropertyName = "Db";

            LogDegisti += OnLogDegisti;
            main.Kullanici.KullaniciTuruChanged += KullaniciTuruChanged;

           
        }

        private void KullaniciTuruChanged(object sender, EventArgs e)
        {
            switch ((User.UserTypes)sender)
            {
                case User.UserTypes.Admin:
                    GelismisGosterim_toggleButton.Visible = true;
                    kullaniciAdiDataGridViewTextBoxColumn.Visible = true;
                    break;
                case User.UserTypes.Operator:
                case User.UserTypes.Misafir:
                    GelismisGosterim_toggleButton.Visible = false;
                    kullaniciAdiDataGridViewTextBoxColumn.Visible = false;
                    break;
                case User.UserTypes.Rasyon:
                case User.UserTypes.Yonetici:
                    kullaniciAdiDataGridViewTextBoxColumn.Visible = true;
                    break;
            }
        }

        private void OnLogDegisti(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker) (() =>
            {
                if (this.Visible)
                {
                    dt2 = DateTime.Now;
                    DatagridGuncelle();
                }
            }));
        }

        private void FormErrorLog_Load(object sender, EventArgs e)
        {
            this.tbl_ErrorTagsTableAdapter.Fill(this.normFeedDBDataset1.tbl_ErrorTags);
            Filter_textbox.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Filter_textbox.textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var source = new AutoCompleteStringCollection();
            source.AddRange(
                normFeedDBDataset1.tbl_ErrorTags.Select(r => r.ErrorAdi).ToArray());
            Filter_textbox.textBox1.AutoCompleteCustomSource = source;
                

            dt2 = DateTime.Now;
            dt1 = dt2.Subtract(TimeSpan.FromHours(1));


            dataGridView1.DataSource = viewErrorLogErrorAdiBindingSource;

            DatagridGuncelle();
            KullaniciTuruChanged(main.Kullanici.Kullanici_Turu,EventArgs.Empty);

        }

        private DateTime dt1, dt2;
        public void FormAcildi()
        {
            DatagridGuncelle();
        }

        void DatagridGuncelle()
        {
            bool gelismis = dataGridView1.DataSource == viewErrorLogGelismisBindingSource;
            if (!gelismis)
            {
                if (!TumLoglar_toggleButton.Checked)
                    view_ErrorLog_ErrorAdiTableAdapter.FillByLastTrues(this.normFeedDBDataset1.View_ErrorLog_ErrorAdi);
                else
                    view_ErrorLog_ErrorAdiTableAdapter.Fill(normFeedDBDataset1.View_ErrorLog_ErrorAdi, dt1, dt2);
            }
            else
            {
                view_ErrorLogGelismisTableAdapter.FillByLastTrues(this.normFeedDBDataset1.View_ErrorLogGelismis);
                if (!TumLoglar_toggleButton.Checked)
                    view_ErrorLogGelismisTableAdapter.FillByLastTrues(this.normFeedDBDataset1.View_ErrorLogGelismis);
                else
                    view_ErrorLogGelismisTableAdapter.Fill(normFeedDBDataset1.View_ErrorLogGelismis, dt1, dt2);
            }

            dataGridView1.Sort(dataGridView1.Columns["dateTimeDataGridViewTextBoxColumn"],
                ListSortDirection.Descending);
        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            DatagridGuncelle();
            DatagridViewColumnStartByte.Visible =
                DatagridViewColumnBit.Visible =
                    DatagridViewColumnDB.Visible =
                        DatagridViewColumnDataType.Visible = dataGridView1.DataSource == viewErrorLogGelismisBindingSource;
        }

        private void GelismisGosterim_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GelismisGosterim_toggleButton.Checked
                ? viewErrorLogGelismisBindingSource
                : viewErrorLogErrorAdiBindingSource;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker1.Value,dateTimePicker2.Value) >= 0)
            {
                dateTimePicker2.Value = dt2 = DateTime.Now;
                dateTimePicker1.Value = dt1 = dt2.Subtract(TimeSpan.FromHours(1));
            }
            else
            {
                dt2 = dateTimePicker2.Value;
                dt1 = dateTimePicker1.Value;
            }
            DatagridGuncelle();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            Color defaultcolor = dataGridView1.DefaultCellStyle.BackColor;
            Color defaulforecolor = dataGridView1.DefaultCellStyle.ForeColor;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var error = (bool)row.Cells["errorDegerDataGridViewCheckBoxColumn"].Value;
                //row.DefaultCellStyle.BackColor = row.DefaultCellStyle.SelectionBackColor = error ? Color.Red : defaultcolor;
                //row.DefaultCellStyle.ForeColor =
                //    row.DefaultCellStyle.SelectionForeColor = error ? Color.White : defaulforecolor;
                row.DefaultCellStyle.ForeColor = row.DefaultCellStyle.SelectionForeColor = error ? Color.OrangeRed : Color.DarkGreen;
            }
        }

        private void btn_filtreleme_CheckedChanged(object sender, EventArgs e)
        {
            bool btnchecked = btn_filtreleme.Checked;
            Filter_textbox.Visible = btnchecked;
            if (!btnchecked)
            {
                Filter_textbox.textBox1.Text = viewErrorLogErrorAdiBindingSource.Filter =
                    viewErrorLogGelismisBindingSource.Filter = "";
                lbl_filtreleme.Text = "Filtreleme\nKapalı";
            }
            else
            {
                Filter_textbox.Focus();
                lbl_filtreleme.Text = "Filtreleme\nAçık";
            }
        }

        private void Filter_textbox__TextChanged(object sender, EventArgs e)
        {
            if (Filter_textbox.textBox1.Text == "" || normFeedDBDataset1.tbl_ErrorTags.All(r => r.ErrorAdi != Filter_textbox.textBox1.Text))
                viewErrorLogErrorAdiBindingSource.Filter =
                    viewErrorLogGelismisBindingSource.Filter = "";
            else 
                viewErrorLogErrorAdiBindingSource.Filter =
                    viewErrorLogGelismisBindingSource.Filter = $"ErrorAdi = '{Filter_textbox.textBox1.Text}'";
        }

        private void errorAdiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void viewErrorLogGelismisBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            Color defaultcolor = dataGridView1.DefaultCellStyle.BackColor;
            Color defaulforecolor = dataGridView1.DefaultCellStyle.ForeColor;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var error = (bool)row.Cells["errorDegerDataGridViewCheckBoxColumn"].Value;
                //row.DefaultCellStyle.BackColor = row.DefaultCellStyle.SelectionBackColor = error ? Color.Red : defaultcolor;
                //row.DefaultCellStyle.ForeColor =
                //    row.DefaultCellStyle.SelectionForeColor = error ? Color.White : defaulforecolor;
                row.DefaultCellStyle.ForeColor = row.DefaultCellStyle.SelectionForeColor = error ? Color.OrangeRed : Color.DarkGreen;
            }

            
        }

        private void TumLoglar_toggleButton_CheckedChanged(object sender, EventArgs e)
        {
            DatagridGuncelle();
            errorDegerDataGridViewCheckBoxColumn.Visible =
                dateTimePicker1.Visible = dateTimePicker2.Visible = TumLoglar_toggleButton.Checked;
            label1.Text = TumLoglar_toggleButton.Checked ? "Tüm Loglar" : "Aktif Alarmlar";
            Filter_textbox.textBox1.Text = "";
        }
    }
}
