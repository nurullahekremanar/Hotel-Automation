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
using dataAccessLayer;
using EntityLayer;
using logicotel;

namespace otel
{
    public partial class resepsiyonmusteri : Form
    {
        public resepsiyonmusteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityMusteri mu = new EntityMusteri();
            
            mu.Muskimlikno = textBox2.Text;
            mu.MusAD = textBox3.Text;
            mu.MusSoyad = textBox4.Text;
            mu.OdaNum = textBox5.Text;
            if (textBox6.Text == "Aktif")
            {
                mu.Durum1 = Convert.ToBoolean(label13.Text);
            }
            else if (textBox6.Text == "Pasif")
            {
                mu.Durum1 = Convert.ToBoolean(label12.Text);
            }
            
            mu.MusCinsiyet = textBox7.Text;
            mu.MusMedeni = textBox8.Text;
            mu.MusSayi = int.Parse(textBox9.Text);
            mu.MusCocuk = int.Parse(textBox10.Text);
            mu.MusAdres = textBox11.Text;

            logicmusteri.Lmusekle(mu);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityMusteri mus = new EntityMusteri();
            mus.MusID = Convert.ToInt32(textBox1.Text);
            logicmusteri.LmusSil(mus.MusID);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityMusteri mu = new EntityMusteri();
            mu.MusID = int.Parse(textBox1.Text);
            mu.Muskimlikno = textBox2.Text;
            mu.MusAD = textBox3.Text;
            mu.MusSoyad = textBox4.Text;
            mu.OdaNum = textBox5.Text;
            if (textBox6.Text == "Aktif")
            {
                mu.Durum1 = Convert.ToBoolean(label13.Text);
            }
            else if (textBox6.Text == "Pasif")
            {
                mu.Durum1 = Convert.ToBoolean(label12.Text);
                EntityOda oda = new EntityOda();
                oda.OdaDurum = "True";
            }

            mu.MusCinsiyet = textBox7.Text;
            mu.MusMedeni = textBox8.Text;
            mu.MusSayi = int.Parse(textBox9.Text);
            mu.MusCocuk = int.Parse(textBox10.Text);
            mu.MusAdres = textBox11.Text;

            logicmusteri.LmusGun(mu);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<EntityMusteri> client = logicmusteri.Lmusterliste();
            dataGridView1.DataSource = client;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resanasayfa rs = new resanasayfa();
            rs.Show();
            this.Hide();
        }
    }
}
