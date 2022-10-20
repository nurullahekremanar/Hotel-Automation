using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKategori
    {
        private int katID;
        private string katADI;

        public int KatID { get => katID; set => katID = value; }
        public string KatADI { get => katADI; set => katADI = value; }
    }
}
