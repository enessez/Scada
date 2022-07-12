using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scada.Forms.AnaSayfa;

namespace Scada.Forms.TestForms
{
    public partial class memorysForm : Form
    {
        private FormMain main;
        private List<Tag> Tags = new List<Tag>();
        public memorysForm(FormMain _main)
        {
            this.main = _main;
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 36; j++)
                {
                    var tag = new Tag
                    {
                        BaslangicByteAdresi = j > 28 ? j : j + 3000,
                        BitAddrs = ((byte) (i)),
                        ContainerControl = this,
                        Datatipi = S7.Net.DataType.Memory,
                        Db = 1,
                        DegiskenTipi = S7.Net.VarType.Bit,
                        TaramaSuresi = 50,
                        VarCount = 1, 
                        ErrorTag = j <= 28, 
                        FormGozukmeseDeOku = j <= 28
                    };
                    Tags.Add(tag);

                    PlcButton plcButton = new PlcButton();
                    plcButton.BorderRadius = 8;
                    plcButton.BorderSize = 0;
                    plcButton.FlatAppearance.BorderSize = 0;
                    plcButton.BorderColor = System.Drawing.Color.PaleVioletRed;
                    plcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    plcButton.ForeColor = System.Drawing.Color.White;
                    plcButton.Location = new System.Drawing.Point(0, 0);
                    tableLayoutPanel1.Controls.Add(plcButton, i, j);
                    plcButton.Dock = DockStyle.Fill;
                    plcButton.Name = "plcButton1";
                    plcButton.OffBackColor = System.Drawing.Color.Gray;
                    plcButton.OffBorderColor = System.Drawing.Color.White;
                    plcButton.OnBackColor = System.Drawing.Color.DarkSeaGreen;
                    plcButton.OnBorderColor = System.Drawing.Color.LightSalmon;
                    plcButton.PlcTag = tag;
                    plcButton.Size = new System.Drawing.Size(29, 8);
                    plcButton.TabIndex = 0;
                    plcButton.TabStop = false;
                    plcButton.Text = $"O{j}.{i}{(j < 28 ? "Error" : "")}";
                    plcButton.UseVisualStyleBackColor = true;
                }
            }
        }

        private void memorysForm_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 36; j++)
            //    {
            //        var butn = ((PlcButton)tableLayoutPanel1.GetControlFromPosition(i, j));
            //        butn.PlcTag.Server = main.plcServer1;
            //    }
            //}

            //var deneme = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            //    .Where(f => f.FieldType == typeof(Tag)).Select(f => f.GetValue(this)).Cast<Tag>();

            foreach (Tag tag in Tags)
            {
                tag.Server = main.plcServer1;
                if (tag.ErrorTag)
                {
                    var doubleTag = main.errorTags.Select((er, i) => new {er, i}).Where(er =>
                        er.er.Tag.DegiskenTipi == tag.DegiskenTipi &&
                        er.er.Tag.BaslangicByteAdresi == tag.BaslangicByteAdresi &&
                        er.er.Tag.Db == tag.Db && er.er.Tag.Datatipi == tag.Datatipi &&
                        er.er.Tag.BitAddrs == tag.BitAddrs);
                        
                    if (doubleTag.Any())
                    {
                        var indexler = doubleTag.OrderByDescending(er => er.i).Select(er => er.i);
                        
                        foreach (var index in indexler)
                        {
                            var tagformesleme = main.errorTags.ElementAt(index);
                            main.errorTags.Remove(tagformesleme);
                            tagformesleme.Tag.Dispose();
                        }
                    }

                    main.errorTags.Add(new TagFormEsleme(tag, this));
                    tag.ValueChanged += main.ErrorDegerDegisti;
                }
            }
        }
    }
}
