using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dataAccessLayer
{
    public class dataAccessLayer
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-93NN47V;Initial Catalog=hotel;Integrated Security=True");
    }
}
