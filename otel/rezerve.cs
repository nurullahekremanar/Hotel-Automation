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
    public partial class rezerve : Form
    {
        public rezerve()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;
        private void listbutton_Click(object sender, EventArgs e)
        {
            List<EntityOda> room = logichotel.LodaListesi();
            dataGridView1.DataSource = room;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            noLabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            katLabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            turLabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fiyatlabel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            durum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (durum.Text == "True")
            {
                musaitlabel.Text = "Boş";
            }
            else
            {
                musaitlabel.Text = "Dolu";
            }
            
        }

        private void rezerve_Load(object sender, EventArgs e)
        {
            List<EntityOda> room = logichotel.LodaListesi();
            dataGridView1.DataSource = room;
           
        }

        private void tutbutton_Click(object sender, EventArgs e)
        {

            


            EntityOda odagun = new EntityOda();
            odagun.OdaID = int.Parse(noLabel.Text);
            odagun.OdaKat = katLabel.Text;
            odagun.OdaKategori = int.Parse(turLabel.Text);
            odagun.OdaFiyat = fiyatlabel.Text;

            odagun.OdaDurum = "false";
                
            MessageBox.Show("Lütfen Bilgilerinizi Giriniz");
                
            

            

            logichotel.Lodaguncelle(odagun);

            
            gonderilecekveri = noLabel.Text;
            musteri kr = new musteri();
            kr.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri m = new musteri();
            m.Show();
            this.Hide();
        }
    }
}
