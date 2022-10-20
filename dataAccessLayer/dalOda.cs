using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;

namespace dataAccessLayer
{
    public class dalOda
    {
        public static List<EntityOda> odalistesi()
        {
            List<EntityOda> deger = new List<EntityOda>();
            SqlCommand komut1 = new SqlCommand("select * from oda", dataAccessLayer.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityOda ent = new EntityOda();
                ent.OdaID = int.Parse(dr["odaID"].ToString());
                ent.OdaKat = dr["odaKat"].ToString();
                ent.OdaKategori = int.Parse(dr["odaKategori"].ToString());
                ent.OdaFiyat = dr["odaFiyat"].ToString();
                ent.OdaDurum = dr["odaDurum"].ToString();
                deger.Add(ent);
            }
            dr.Close();
            return deger;
        }

        

        public static int odasec(EntityOda n)
        {
            SqlCommand komut2 = new SqlCommand("insert into oda(odaKat, odaKategori, odaFiyat, odaDurum) values (@e1, @e2, @e3, @e4)", dataAccessLayer.baglanti);
            if (komut2.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut2.Connection.Open();
            }
            
            komut2.Parameters.AddWithValue("@e1", n.OdaKat);
            komut2.Parameters.AddWithValue("@e2", n.OdaKategori);
            komut2.Parameters.AddWithValue("@e3", n.OdaFiyat);
            komut2.Parameters.AddWithValue("@e4", n.OdaDurum);
            return komut2.ExecuteNonQuery();
        }

        public static bool odaguncelle(EntityOda j)
        {
            SqlCommand komut3 = new SqlCommand("update oda set  odaKat = @g1, odaKategori = @g2, odaFiyat = @g3, odaDurum = @g4 where odaID = @g5", dataAccessLayer.baglanti);
            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@g1", j.OdaKat);
            komut3.Parameters.AddWithValue("@g2", j.OdaKategori);
            komut3.Parameters.AddWithValue("@g3", j.OdaFiyat);
            komut3.Parameters.AddWithValue("@g4", j.OdaDurum);
            komut3.Parameters.AddWithValue("@g5", j.OdaID);
            
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool odasil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from oda where odaID = @s1", dataAccessLayer.baglanti);

            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@s1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
    }

    
}
