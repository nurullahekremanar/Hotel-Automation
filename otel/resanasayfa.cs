using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel
{
    public partial class resanasayfa : Form
    {
        public resanasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            resepsiyonmusteri res = new resepsiyonmusteri();
            res.Show();
            this.Hide();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            resepsiyonoda res = new resepsiyonoda();
            res.Show();
            this.Hide();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            kategori kat = new kategori();
            kat.Show();
            this.Hide();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            resepsiyonkiralama kr = new resepsiyonkiralama();
            kr.Show();
            this.Hide();
        }
    }
}
