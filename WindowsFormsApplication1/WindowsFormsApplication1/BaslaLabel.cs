using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public class BaslaLabel
    {
        public Label lblbasla = new Label
        {
           Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))),
           AutoSize = true,
           Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
           Location = new System.Drawing.Point(518, 7),
           Size = new System.Drawing.Size(343, 24),
           TabIndex = 4,
           Text = "Yeni oyun başlatmak için tek tıklayın"
        };
    }
}
