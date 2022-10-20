using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMusteri
    {
        
        private int musID;
        private string muskimlikno;
        private string musAD;
        private string musSoyad;
        private string odaNum;
        private bool Durum;
        private string musCinsiyet;
        private string musMedeni;
        private int musSayi;
        private int musCocuk;
        private string musAdres;
        private DateTime musGirisTarihi;
        private DateTime musCikisTarihi;

        public int MusID { get => musID; set => musID = value; }
        public string Muskimlikno { get => muskimlikno; set => muskimlikno = value; }
        public string MusAD { get => musAD; set => musAD = value; }
        public string MusSoyad { get => musSoyad; set => musSoyad = value; }
        public string OdaNum { get => odaNum; set => odaNum = value; }
        public bool Durum1 { get => Durum; set => Durum = value; }
        public string MusCinsiyet { get => musCinsiyet; set => musCinsiyet = value; }
        public string MusMedeni { get => musMedeni; set => musMedeni = value; }
        public int MusSayi { get => musSayi; set => musSayi = value; }
        public int MusCocuk { get => musCocuk; set => musCocuk = value; }
        public string MusAdres { get => musAdres; set => musAdres = value; }
        public DateTime MusGirisTarihi { get => musGirisTarihi; set => musGirisTarihi = value; }
        public DateTime MusCikisTarihi { get => musCikisTarihi; set => musCikisTarihi = value; }
    }

}
