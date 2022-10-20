using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using dataAccessLayer;

namespace logicotel
{
    public class logickategori
    {
        public static List<EntityKategori> LkatListesi()
        {

            return dalKategori.katlistesi();

        }

        public static int Lkatekle(EntityKategori o)
        {
            return dalKategori.katekle(o);
        }

        public static bool Lkatguncelle(EntityKategori j)
        {
            return dalKategori.katguncelle(j);
        }

        public static bool LkatSil(int s)
        {
            if (s >= 1)
            {
                return dalKategori.katsil(s);
            }
            else
            {
                return false;
            }
        }
    }
}
