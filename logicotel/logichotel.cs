using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityLayer;
using dataAccessLayer;


namespace logicotel
{
    public class logichotel
    {
        public static List<EntityOda> LodaListesi()
        {

            return dalOda.odalistesi();

        }

        public static int Lodasec(EntityOda o)
        {
            return dalOda.odasec(o);
        }

        public static bool Lodaguncelle(EntityOda j)
        {
            return dalOda.odaguncelle(j);
        }

        public static bool LodaSil(int s)
        {
            if (s >= 1)
            {
                return dalOda.odasil(s);
            }
            else
            {
                return false;
            }


        }

    }
}