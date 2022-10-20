using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKiralama
    {
        private int kiraID;
        private int oda;
        private int musteriID;
        private DateTime girisTarih;
        private DateTime cikisTarih;
        private string muskimlikno;
        private string musAD;
        private string musSoyad;
        private int odaID;
        private string odaKat;
        private int odaKategori;
        private string odaFiyat;
        private bool odaDurum;

        public int KiraID { get => kiraID; set => kiraID = value; }
        public int Oda { get => oda; set => oda = value; }
        public int MusteriID { get => musteriID; set => musteriID = value; }
        public DateTime GirisTarih { get => girisTarih; set => girisTarih = value; }
        public DateTime CikisTarih { get => cikisTarih; set => cikisTarih = value; }
        public string Muskimlikno { get => muskimlikno; set => muskimlikno = value; }
        public string MusAD { get => musAD; set => musAD = value; }
        public string MusSoyad { get => musSoyad; set => musSoyad = value; }
        public int OdaID { get => odaID; set => odaID = value; }
        public string OdaKat { get => odaKat; set => odaKat = value; }
        public int OdaKategori { get => odaKategori; set => odaKategori = value; }
        public string OdaFiyat { get => odaFiyat; set => odaFiyat = value; }
        public bool OdaDurum { get => odaDurum; set => odaDurum = value; }
        
    }
}
