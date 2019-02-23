using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public class SkorButton:Button
    {
        public Button btnskor = new Button()
        {
           BackColor = System.Drawing.Color.PeachPuff,
           Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
           ForeColor = System.Drawing.Color.SaddleBrown,
           Location = new System.Drawing.Point(107, 7),
           Size = new System.Drawing.Size(171, 26),
           TabIndex = 3,
           Text = "YÜKSEK SKORLAR",
           UseVisualStyleBackColor = false
        };
    }
}
