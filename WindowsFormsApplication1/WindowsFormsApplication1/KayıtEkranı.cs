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
    public partial class KayıtEkranı : Form
    {
        public KayıtEkranı(string dk,string sn,int süre)
        {
            InitializeComponent();
            Form1 frm = new Form1();
            lblgızlı.Text = süre.ToString();
            lblskor.Text = dk + ":" + sn;
        }
       SqlConnection baglantı = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|vtb.mdf;");

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            string komut = "INSERT INTO Skor (AdSoyad,Süre) VALUES (@Ad,@Süre)";
            SqlCommand sqlcmd = new SqlCommand(komut, baglantı);
            sqlcmd.Parameters.AddWithValue("@Ad", txtad.Text);
            sqlcmd.Parameters.AddWithValue("@Süre", lblgızlı.Text);
            sqlcmd.ExecuteNonQuery();
            baglantı.Close();

        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void KayıtEkranı_Load(object sender, EventArgs e)
        {
            
        }
    }
}
