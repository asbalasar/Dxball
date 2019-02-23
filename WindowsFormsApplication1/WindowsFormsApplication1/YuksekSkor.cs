using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class YuksekSkor : Form
    {
        public YuksekSkor()
        {
            InitializeComponent();
        }
        Label lblad;
        SqlConnection baglantı = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|vtb.mdf;");
        int  y=0;
        private void YuksekSkor_Load(object sender, EventArgs e)
        { 
            baglantı.Open();
            string komut = "SELECT * FROM Skor";
            SqlCommand sqlcmd = new SqlCommand(komut, baglantı);
            SqlDataReader verioku = sqlcmd.ExecuteReader();
            while (verioku.Read())
            {
                lblad = new Label()
                {
                    Text = ("          " + verioku[1].ToString() + "              " + verioku[2].ToString()),
                    AutoSize = true,
                    Font = new Font("Segoe UI ", 18, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(0, y),
                   
                };
                y += 30;
                pnlskor.Controls.Add(lblad);


            }
            verioku.Close();
            baglantı.Close();
        }
    }
}
