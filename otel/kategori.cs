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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            EntityKategori r = new EntityKategori();

            
            
            r.KatADI = textBox2.Text;            
            logickategori.Lkatekle(r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityKategori r = new EntityKategori();
            r.KatID = Convert.ToInt32(textBox1.Text);
            logickategori.LkatSil(r.KatID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityKategori r = new EntityKategori();
            r.KatID = int.Parse(textBox1.Text);
            r.KatADI = textBox2.Text;
            
            logickategori.Lkatguncelle(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<EntityKategori> room = logickategori.LkatListesi();
            dataGridView1.DataSource = room;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resanasayfa rs = new resanasayfa();
            rs.Show();
            this.Hide();
        }
    }
}
