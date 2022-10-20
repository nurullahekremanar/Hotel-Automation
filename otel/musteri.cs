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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
       

        //otelEntities1 db = new otelEntities1();

        private void musteri_Load(object sender, EventArgs e)
        {
            textBox1.Text = rezerve.gonderilecekveri;
        }

        private void secbutton_Click(object sender, EventArgs e)
        {

            EntityMusteri mu = new EntityMusteri();
            
            mu.Muskimlikno = kimliktext.Text;
            mu.MusAD = adtext.Text;
            mu.MusSoyad = soyadtext.Text;
            mu.OdaNum = textBox1.Text;
            mu.MusCinsiyet = cinisyettext.Text;
            mu.Durum1 = Convert.ToBoolean(durumlabel.Text);
            mu.MusMedeni = medenidurumtext.Text;
            mu.MusSayi = int.Parse(kisisayisitext.Text);
            mu.MusCocuk = int.Parse(cocuksayisitext.Text);
            mu.MusAdres = adrestext.Text;
            mu.MusGirisTarihi = dateTimePicker1.Value;
            mu.MusCikisTarihi = dateTimePicker2.Value;


            logicmusteri.Lmusekle(mu);


            richTextBox1.Text = "Kimlik Numarası: " + kimliktext.Text + "\n İsim: " + adtext.Text + "\n Soyisim: " + soyadtext.Text + "\n Cinsiyet: " + cinisyettext.Text + "\n Medeni Durum:  " + medenidurumtext.Text + "\n Kişi Sayısı: " + kisisayisitext.Text + "\n Çocuk Sayısı: " + cocuksayisitext.Text + "\n Adres: " + adrestext.Text + "\n Giriş Tarihi: " + dateTimePicker1.Text + "\n Çıkış Tarihi" + dateTimePicker2.Text;

            MessageBox.Show("Rezervasyonunuz Alınmıştır Lütfen Ayırttığınız Zamanda Resepsiyonda Olunuz.");

            
            anaekran rz = new anaekran();
            
            rz.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezerve ana = new rezerve();
            ana.Show();
            this.Hide();
        }
    }
}
