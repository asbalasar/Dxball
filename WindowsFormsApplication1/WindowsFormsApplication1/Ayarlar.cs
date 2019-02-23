using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public class Ayarlar:Button
    {
        public Button btnayar = new Button()
        {
            BackColor = System.Drawing.Color.LightBlue,
            Location = new System.Drawing.Point(307, 7),
            Size = new System.Drawing.Size(130, 27),
            TabIndex = 3,
            UseVisualStyleBackColor = false,
            Text="Ayarlar",
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),

            //Image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Setting.png"),

        };
    }
}
