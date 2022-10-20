using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataAccessLayer;
using EntityLayer;
using logicotel;

namespace otel
{
    public partial class resepsiyonoda : Form
    {
        public resepsiyonoda()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<EntityOda> room = logichotel.LodaListesi();
            dataGridView1.DataSource = room;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            EntityOda r = new EntityOda();
            
            r.OdaKat = textBox2.Text;
            r.OdaKategori = int.Parse(textBox3.Text);
            r.OdaFiyat = textBox4.Text;
            if (textBox5.Text == "Boş")
            {
                r.OdaDurum = "True";
            }
            else if (textBox5.Text == "Dolu")
            {
                r.OdaDurum = "False";
            }
            
            
            logichotel.Lodasec(r);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityOda r = new EntityOda();
            r.OdaID = Convert.ToInt32(textBox1.Text);
            logichotel.LodaSil(r.OdaID);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityOda oda = new EntityOda();
            oda.OdaID = int.Parse(textBox1.Text);
            oda.OdaKat = textBox2.Text;
            oda.OdaKategori = int.Parse(textBox3.Text);
            oda.OdaFiyat = textBox4.Text;
            if (textBox5.Text == "Boş")
            {
                oda.OdaDurum = "True";
            }
            else if (textBox5.Text == "Dolu")
            {
                oda.OdaDurum = "False";
            }
            logichotel.Lodaguncelle(oda);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resanasayfa rs = new resanasayfa();
            rs.Show();
            this.Hide();
        }
    }
}
