using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scada.Forms.AnaSayfa
{
    public class TagFormEsleme
    {
        public TagFormEsleme(Tag _tag, Form _form)
        {
            this.Tag = _tag;
            Tag.ContainerFormVisible = false;
            this.Form = _form;
        }
        private Tag tag;
        public Tag Tag
        {
            get => tag;
            set => tag = value;
        }
        private Form form;

        public Form Form
        {
            get => form;
            set
            {
                form = value;
                if (value != null) 
                {
                    form.VisibleChanged += Form_VisibleChanged;
                }
            }
        }

        private void Form_VisibleChanged(object sender, EventArgs e)
        {
            tag.ContainerFormVisible = (bool) ((System.Windows.Forms.Form) sender).Visible;
        }
    }
}
