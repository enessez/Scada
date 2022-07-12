using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scada.Forms.LogForms
{
    public partial class KullaniciGirisCikisForm : Form
    {
        private FormMain main;
 
        public EventHandler LogDegisti;
        public KullaniciGirisCikisForm(FormMain _main)
        {
            this.main = _main;

            InitializeComponent();

         
            main.Kullanici.KullaniciTuruChanged +=KullaniciTuruChanged;
        }
        private void KullaniciGirisCikisForm_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value =dt2= DateTime.Now.Add(TimeSpan.FromHours(1));
            dateTimePicker1.Value =dt1= dt2.Subtract(TimeSpan.FromDays(1));
            // TODO: This line of code loads data into the 'normFeedDBDataset1.View_GirisCikisLog' table. You can move, or remove it, as needed
            // TODO: This line of code loads data into the 'normFeedDBDataset1.tbl_Users' table. You can move, or remove it, as needed.
            this.tbl_UsersTableAdapter.Fill(this.normFeedDBDataset1.tbl_Users);

            Filter_textbox.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Filter_textbox.textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            var source = new AutoCompleteStringCollection();
            source.AddRange(
                normFeedDBDataset1.tbl_Users.Select(r => r.KullaniciAdi).ToArray());
            Filter_textbox.textBox1.AutoCompleteCustomSource = source;


        


            DatagridGuncelle();
            KullaniciTuruChanged(main.Kullanici.Kullanici_Turu, EventArgs.Empty);
        }

        private void KullaniciTuruChanged(object sender, EventArgs e)
        {
            
        }

        private DateTime dt1, dt2;
        public void FormAcildi()
        {
            DatagridGuncelle();
        }

        void DatagridGuncelle()
        {
            view_GirisCikisLogTableAdapter.FillByDateTime(this.normFeedDBDataset1.View_GirisCikisLog, dt1, dt2);
            
            dataGridView1.Sort(dataGridView1.Columns["Zaman"],
                ListSortDirection.Descending);
        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            DatagridGuncelle();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value) >= 0)
            {
                dateTimePicker2.Value = dt2 = DateTime.Now.Add(TimeSpan.FromHours(1));
                dateTimePicker1.Value = dt1 = dt2.Subtract(TimeSpan.FromDays(1));
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
            if (dataGridView1.Rows.Count == 0) return;
            Color defaultcolor = dataGridView1.DefaultCellStyle.BackColor;
            Color defaulforecolor = dataGridView1.DefaultCellStyle.ForeColor;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var girisValue = (bool)row.Cells["Giris_Cikis"].Value;
                row.DefaultCellStyle.ForeColor = row.DefaultCellStyle.SelectionForeColor = !girisValue ? Color.OrangeRed : Color.DarkGreen;
            }
        }

        private void btn_filtreleme_CheckedChanged(object sender, EventArgs e)
        {
            bool btnchecked = btn_filtreleme.Checked;
            Filter_textbox.Visible = btnchecked;
            Filter_textbox.textBox1.Text = "";
            if (!btnchecked)
            {
                 GirisCikisLogBindingSource.Filter = "";
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
            if (Filter_textbox.textBox1.Text == "" || normFeedDBDataset1.tbl_Users.All(r => r.KullaniciAdi != Filter_textbox.textBox1.Text))
                GirisCikisLogBindingSource.Filter = "";
            else
                GirisCikisLogBindingSource.Filter = $"KullaniciAdi = '{Filter_textbox.textBox1.Text}'";
        }

        private void KullaniciGirisCikisForm_Shown(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            Color defaultcolor = dataGridView1.DefaultCellStyle.BackColor;
            Color defaulforecolor = dataGridView1.DefaultCellStyle.ForeColor;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var girisValue = (bool)row.Cells["Giris_Cikis"].Value;
                row.DefaultCellStyle.ForeColor = row.DefaultCellStyle.SelectionForeColor = !girisValue ? Color.OrangeRed : Color.DarkGreen;
            }
        }

       

        private void GirisCikisLogBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            Color defaultcolor = dataGridView1.DefaultCellStyle.BackColor;
            Color defaulforecolor = dataGridView1.DefaultCellStyle.ForeColor;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var girisValue = (bool)row.Cells["Giris_Cikis"].Value;
                row.DefaultCellStyle.ForeColor = row.DefaultCellStyle.SelectionForeColor = !girisValue ? Color.OrangeRed : Color.DarkGreen;
            }
        }

       
    }
}
