using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ayar : Form
    {
        public Ayar()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                nmhız.Enabled = true;
            }
            else
            {
                nmhız.Enabled = false;
            }
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            cdrenk.ShowDialog();
            Color gelenrenk = cdrenk.Color;

        }
    }
}
