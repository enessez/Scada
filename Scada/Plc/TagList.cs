using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Scada
{
    public class TagList
    {
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public int Time { get; set; } = 5;
        public bool EnableTimer { get; set; } = true;
    }
}
