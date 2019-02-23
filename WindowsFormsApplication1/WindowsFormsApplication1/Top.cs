using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication1
{
    public class Top:PictureBox
    {
        public PictureBox btntop = new PictureBox
        {
            Width = 55,
            Height = 45,
            Visible = false,
            Image = Image.FromFile(Application.StartupPath + "\\top.png"),
            BackColor=Color.Silver,
        };

        
    }
}
