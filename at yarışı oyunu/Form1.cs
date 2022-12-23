using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsonauzaklık, ucuncuatsonauzaklık,dorduncuatuzunluk;

        Random radtgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenişliği = pictureBox1.Width;
            int ikinciatıngenişliği = pictureBox2.Width;
            int üçüncüatıngenişliği = pictureBox3.Width;
            int dorduncuatgenişliği = pictureBox4.Width;

            int bitişuzaklığı = label6.Left;

            pictureBox1.Left = pictureBox1.Left + radtgele.Next(5,15);
            pictureBox2.Left = pictureBox2.Left + radtgele.Next(5,15);
            pictureBox3.Left = pictureBox3.Left + radtgele.Next(5,15);
            pictureBox4.Left = pictureBox4.Left + radtgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5&&pictureBox1.Left>pictureBox4.Left+5)
            {
                label5.Text = "BİRİNCİ AT KAZANMAYA GELİYOOOOR";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox4.Left + 5)
            {
                label5.Text = "İKİNCİ AT YARIŞI BENDEN BAŞKASI KAZANAMAZ DERCESİNE KOŞUP ÖNDERLİĞİ KAPIYOR";
            }
            if (pictureBox3.Left>pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox4.Left + 5)
            {
                label5.Text = "ÜÇÜNCÜ AT ANİ ATAK YAPARAK RAKİPLERİNİ GERİDE BİRAKTI";
            }
            if(pictureBox4.Left>pictureBox1.Left+5&&pictureBox4 .Left>pictureBox2.Left+5&&pictureBox4.Left>pictureBox3.Left+5)
            {
                label5.Text = "4. AT AYRIŞI KAZANMAYA GELİYOR";
            }

            if (birinciatıngenişliği + pictureBox1.Left >= bitişuzaklığı) 
            {
                timer1.Enabled = false;
                label5.Text = ("BİRİNCİ AT YARIŞI KAZANDI");
            }
            if(ikinciatıngenişliği + pictureBox2.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;
                label5.Text = ("İKİNCİ AT YARIŞI KAZANDI");
            }

            if (üçüncüatıngenişliği + pictureBox3.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;
                label5.Text=("ÜÇÜNCÜ AT AYRIŞI KAZANDI");
            }
            if (dorduncuatgenişliği + pictureBox4.Left >= bitişuzaklığı)
            {
                label5.Text=("DÖRDÜNCÜ AT AYRIŞI KAZANDI");
            }
            button1.Enabled = false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsonauzaklık = pictureBox2.Left;
            ucuncuatsonauzaklık = pictureBox3.Left;
            dorduncuatuzunluk = pictureBox4.Left;

        }
       
    }
}
