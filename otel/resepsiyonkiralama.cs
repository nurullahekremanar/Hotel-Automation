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
    public partial class resepsiyonkiralama : Form
    {
        public resepsiyonkiralama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityKiralama kr = new EntityKiralama();

            kr.Oda = int.Parse(textBox2.Text);
            kr.MusteriID = int.Parse(textBox3.Text);
            kr.GirisTarih = dateTimePicker1.Value;
            kr.CikisTarih = dateTimePicker2.Value;

            logickirala.Lkiraekle(kr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<EntityKiralama> kr = logickirala.LkiraListesi();
            dataGridView1.DataSource = kr;
        }

        private void resepsiyonkiralama_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            resanasayfa rs = new resanasayfa();
            rs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
