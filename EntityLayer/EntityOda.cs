using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOda
    {
        private int odaID;
        private string odaKat;
        private int odaKategori;
        private string odaFiyat;
        private string odaDurum;
        

        public int OdaID { get => odaID; set => odaID = value; }
        public string OdaKat { get => odaKat; set => odaKat = value; }
        public int OdaKategori { get => odaKategori; set => odaKategori = value; }
        public string OdaFiyat { get => odaFiyat; set => odaFiyat = value; }
        public string OdaDurum { get => odaDurum; set => odaDurum = value; }
        
    }
}
