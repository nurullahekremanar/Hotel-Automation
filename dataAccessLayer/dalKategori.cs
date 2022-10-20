using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;

namespace dataAccessLayer
{
    public class dalKategori
    {
        public static List<EntityKategori> katlistesi()
        {
            List<EntityKategori> deger = new List<EntityKategori>();
            SqlCommand komut1 = new SqlCommand("select * from kategori", dataAccessLayer.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityKategori ent = new EntityKategori();
                ent.KatID = int.Parse(dr["katID"].ToString());
                ent.KatADI = dr["katADI"].ToString();
                
                deger.Add(ent);
            }
            dr.Close();
            return deger;
        }



        public static int katekle(EntityKategori n)
        {
            SqlCommand komut2 = new SqlCommand("insert into kategori (katADI) values (@e1)", dataAccessLayer.baglanti);
            if (komut2.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut2.Connection.Open();
            }

            
            komut2.Parameters.AddWithValue("@e1", n.KatADI);
            
            return komut2.ExecuteNonQuery();
        }

        public static bool katguncelle(EntityKategori j)
        {
            SqlCommand komut3 = new SqlCommand("update kategori set  katADI = @g1 where katID = @g2", dataAccessLayer.baglanti);
            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@g1", j.KatADI);
            komut3.Parameters.AddWithValue("@g2", j.KatID);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool katsil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from kategori where katID = @s1", dataAccessLayer.baglanti);

            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@s1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
    }
}
