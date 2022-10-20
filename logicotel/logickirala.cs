using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using dataAccessLayer;

namespace logicotel
{
    public class logickirala
    {
        public static List<EntityKiralama> LkiraListesi()
        {

            return dalkirala.kiralistesi();

        }

        public static int Lkiraekle(EntityKiralama o)
        {
            return dalkirala.kiraekle(o);
        }

        public static bool Lkiraguncelle(EntityKiralama j)
        {
            return dalkirala.kiraguncelle(j);
        }

        public static bool LkiraSil(int s)
        {
            if (s >= 1)
            {
                return dalkirala.kirasil(s);
            }
            else
            {
                return false;
            }
        }
    }
}

