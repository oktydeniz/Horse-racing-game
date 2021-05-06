using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun_1
{
    public partial class Form1 : Form
    {
        int birinci_at_uzaklik, ikinci_at_uzaklik, ucuntu_at_uzaklik;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int bitis_uzaklik = label5.Left;
            int birinci_at_genislik = pictureBox1.Width;
            int ikinici_at_genslik = pictureBox2.Width;
            int ucuncu_at_genislik = pictureBox3.Width;

            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 15);
            if(pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left >pictureBox3.Left +5)
            {
                label6.Text = " 3 Numaralı At yarışı Önde Götürüyor !";
            }
            if(pictureBox2.Left >pictureBox1.Left+5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = " 2 Numaralı At yarışı Önde Götürüyor !";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = " 1 Numaralı At yarışı Önde Götürüyor !";
            }

            if (birinci_at_genislik + pictureBox1.Left >= bitis_uzaklik)
            {
                timer1.Enabled = false;
                label6.Text = "3 Numaralı At Kazandı !";
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;   
            }
            if (ikinici_at_genslik + pictureBox2.Left >= bitis_uzaklik)
            {
                timer1.Enabled = false;
                label6.Text = "2 Numaralı At Kazandı !";
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
            if(ucuncu_at_genislik +pictureBox3.Left >= bitis_uzaklik)
            {
                timer1.Enabled = false;
                label6.Text = "1 Numaralı At Kazandı !";
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinci_at_uzaklik = pictureBox1.Left;
            ikinci_at_uzaklik = pictureBox2.Left;
            ucuntu_at_uzaklik = pictureBox3.Left;
        }
    }
}
