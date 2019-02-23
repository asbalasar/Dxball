using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public class Cubuk:Panel
    {
        public Panel cubuk = new Panel
        {
            Width = 200,
            Height = 30,
            Anchor = AnchorStyles.Bottom,
            Location = new System.Drawing.Point(333, 465),
            BackColor = System.Drawing.Color.Orange,
            TabIndex=1
        };
    }
}
