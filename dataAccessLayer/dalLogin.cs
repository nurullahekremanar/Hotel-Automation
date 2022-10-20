using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;

namespace dataAccessLayer
{
    public class dalLogin
    {
        SqlCommand giris = new SqlCommand("Select * from girispaneli where kAdi= @p1 and sifre = @p2", dataAccessLayer.baglanti);
    }
}
