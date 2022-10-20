using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityLogin
    {
        private int kID;
        private string kAdi;
        private string sifre;

        public int KID { get => kID; set => kID = value; }
        public string KAdi { get => kAdi; set => kAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
