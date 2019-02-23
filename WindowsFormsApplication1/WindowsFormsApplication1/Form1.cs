using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        #region Değişkenler
        SqlConnection baglantı = new SqlConnection(@"Server=(localdb)\v11.0; Integrated Security = true; AttachDbFileName=|DataDirectory|vtb.mdf;");
        int enbuyuk = 0;
        int süre;
        Cubuk ck = new Cubuk();
        PanelAna pnl = new PanelAna();
        PanelUst pnlu = new PanelUst();
        SkorButton sk = new SkorButton();
        BaslaLabel blabel = new BaslaLabel();
        LabelDakika dlbl = new LabelDakika();
        LabelSaniye slbl = new LabelSaniye();
        Top tp = new Top();
        Ayarlar ayr = new Ayarlar();
        SoundPlayer ses = new SoundPlayer();
        int x, y, saniye = 0, dk = 0;


        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            tp.btntop.Left += x;
            tp.btntop.Top -= y;
            if (tp.btntop.Left<=0 || tp.btntop.Right>=pnl.pnlana.ClientSize.Width)
            {

                ses.Play();
                if (x > 0)
                {
                    x++;
                }
                else
                {
                    x--;
                }
                if (y > 0)
                {
                    y++;
                }
                else
                {
                    y--;
                }
                x *= -1;
                
               
            }
            if (tp.btntop.Top <= 45 )
            {

                ses.Play();
                if (x > 0)
                {
                    x++;
                }
                else
                {
                    x--;
                }
                if (y > 0)
                {
                    y++;
                }
                else
                {
                    y--;
                }
                y *= -1;
               
               
            }
            if (tp.btntop.Bottom >= pnl.pnlana.ClientSize.Height-30 &&(tp.btntop.Location.X >= ck.cubuk.Location.X && tp.btntop.Location.X <= ck.cubuk.Location.X + 200))
            {
                ses.Play();
                if (x > 0)
                {
                    x++;
                }
                else
                {
                    x--;
                }
                if (y > 0)
                {
                    y++;
                }
                else
                {
                    y--;
                }
                y *= -1;
               
                
            }
            else if (tp.btntop.Bottom > pnl.pnlana.ClientSize.Height - 30 )
            {
                yenilgi();
            }
            ses.Stop();

        }
        private void yenilgi()
        {

            timer1.Stop();
            timer2.Stop();
            blabel.lblbasla.Visible = true;


            baglantı.Open();
            string komut = "SELECT * FROM Skor";
            SqlCommand sqlcmd = new SqlCommand(komut, baglantı);
            SqlDataReader verioku = sqlcmd.ExecuteReader();
            while (verioku.Read())
            {
                if ((int)verioku[2] > enbuyuk)
                {
                    enbuyuk = (int)verioku[2];
                }

            }
            verioku.Close();
            baglantı.Close();
            if (enbuyuk<=süre)
            {
                
                string path = Application.StartupPath+"\\alkis.wav";
                ses.SoundLocation = path;
                ses.Play();
                KayıtEkranı kyt = new KayıtEkranı(dlbl.lbldk.Text,slbl.lblsaniye.Text,süre);
                kyt.Show();
            }

            


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\duvar.wav";
            ses.SoundLocation = path;
            sk.btnskor.Click += Btnskor_Click;
            pnlu.pnlust.Controls.Add(sk.btnskor);
            pnlu.pnlust.Controls.Add(dlbl.lbldk);
            pnlu.pnlust.Controls.Add(slbl.lblsaniye);
            pnlu.pnlust.Controls.Add(blabel.lblbasla);
            ayr.btnayar.Click += btnayar_Click;
            pnlu.pnlust.Controls.Add(ayr.btnayar);
            pnl.pnlana.Controls.Add(ck.cubuk);
            pnl.pnlana.Controls.Add(pnlu.pnlust);
            pnl.pnlana.Controls.Add(tp.btntop);
            pnl.pnlana.MouseMove += Pnlana_MouseMove;
            pnl.pnlana.Click += Pnlana_Click;
            pnl.pnlana.MouseLeave += pnlana_MouseLeave;
            pnl.pnlana.MouseEnter += pnlana_MouseEnter;
            this.Controls.Add(pnl.pnlana);
          
            
           
           
        }
        void btnayar_Click(object sender, EventArgs e)
        {
            Ayar fayar = new Ayar();
            fayar.Show();
        }
        void pnlana_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
        void pnlana_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
        private void Btnskor_Click(object sender, EventArgs e)
        {
            YuksekSkor yk = new YuksekSkor();
            yk.Show();
        }
        private void Pnlana_Click(object sender, EventArgs e)
        {
            
            tp.btntop.Visible = true;
            tp.btntop.Location = new Point(ck.cubuk.Location.X + 100, pnl.pnlana.Height - 150);
            x = 10;
            y = 10;
            timer1.Start();
            timer2.Start();
            saniye = 0; dk = 0;
            slbl.lblsaniye.Text = "00";
            dlbl.lbldk.Text = "00";
            blabel.lblbasla.Visible = false;
        }
        private void Pnlana_MouseMove(object sender, MouseEventArgs e)
        {
            ck.cubuk.Location = new Point(e.X - 100, pnl.pnlana.Height - 29);
            if (ck.cubuk.Left <= 0)
            {
                ck.cubuk.Left = 0;
                ck.cubuk.Top = pnl.pnlana.ClientSize.Height-30;

            }
            if (ck.cubuk.Location.X + 200 > pnl.pnlana.Width)
            {

                ck.cubuk.Left = pnl.pnlana.Width - 200;
                ck.cubuk.Top = pnl.pnlana.ClientSize.Height - 30;
                
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye<10)
            {
                slbl.lblsaniye.Text = ("0" + saniye.ToString());
            }
            else
            {
                slbl.lblsaniye.Text = saniye.ToString();
            }
            
            if (saniye==60)
            {
                dk++;
                saniye = 0;
            }
            if (dk<10)
            {
                dlbl.lbldk.Text = "0" + dk.ToString();
            }
            else
            {
                dlbl.lbldk.Text =dk.ToString();
            }
            süre = (dk * 60) + saniye;
        }
    }
}
