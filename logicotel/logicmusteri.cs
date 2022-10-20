using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using dataAccessLayer;

namespace logicotel
{
    public class logicmusteri
    {
        public static List<EntityMusteri> Lmusterliste()
        {
            return dalMusteri.musterilistesi();
        }
        public static int Lmusekle(EntityMusteri p)
        {

            return dalMusteri.musekle(p);

        }
        public static bool LmusSil(int s)
        {
            if (s >= 1)
            {
                return dalMusteri.mussil(s);
            }
            else
            {
                return false;
            }
            
        }
        public static bool LmusGun(EntityMusteri j)
        {
            return dalMusteri.musgun(j);
        }
    }
}
