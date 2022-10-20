using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;

namespace dataAccessLayer
{
    public class dalkirala
    {
        public static List<EntityKiralama> kiralistesi()
        {
            List<EntityKiralama> deger = new List<EntityKiralama>();
            SqlCommand komut1 = new SqlCommand("select musID, muskimlikno, musAD, musSoyad, odaID, odaKat, odaKategori, odaFiyat  from musteri inner join kiralama on musID = musteriID inner join oda on odaID = oda", dataAccessLayer.baglanti);
            
            
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityKiralama ent = new EntityKiralama();
                //ent.KiraID = int.Parse(dr["kiraID"].ToString());
                //ent.Oda = int.Parse(dr["oda"].ToString());
                
                ent.MusteriID = int.Parse(dr["musID"].ToString());
                //ent.GirisTarih = Convert.ToDateTime(dr["girisTarih"].ToString());
                //ent.CikisTarih = Convert.ToDateTime(dr["cikisTarih"].ToString());
                ent.Muskimlikno = dr["muskimlikno"].ToString();
                ent.MusAD = dr["musAD"].ToString();
                ent.MusSoyad = dr["musSoyad"].ToString(); 
                ent.OdaID = int.Parse(dr["odaID"].ToString());
                ent.OdaKat = dr["odaKat"].ToString();
                ent.OdaKategori = int.Parse(dr["odaKategori"].ToString());
                ent.OdaFiyat = dr["odaFiyat"].ToString();
                //ent.OdaDurum = Convert.ToBoolean(dr["odaDurum"].ToString());

                deger.Add(ent);
            }
            dr.Close();
            return deger;
        }



        public static int kiraekle(EntityKiralama n)
        {
            SqlCommand komut2 = new SqlCommand("insert into kiralama (oda, musteri, girisTarih, cikisTarih) values (@e1, @e2, @e3, @e4)", dataAccessLayer.baglanti);
            if (komut2.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut2.Connection.Open();
            }


            komut2.Parameters.AddWithValue("@e1", n.Oda);
            komut2.Parameters.AddWithValue("@e2", n.MusteriID);
            komut2.Parameters.AddWithValue("@e3", n.GirisTarih);
            komut2.Parameters.AddWithValue("@e4", n.CikisTarih);

            return komut2.ExecuteNonQuery();
        }

        public static bool kiraguncelle(EntityKiralama j)
        {
            SqlCommand komut3 = new SqlCommand("update kiralama set  oda @g1 , musteri @g2 , girisTarih @g3 , cikisTarih @g4 where kiraID = @g5", dataAccessLayer.baglanti);
            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@g1", j.Oda);
            komut3.Parameters.AddWithValue("@g2", j.MusteriID);
            komut3.Parameters.AddWithValue("@g3", j.GirisTarih);
            komut3.Parameters.AddWithValue("@g4", j.CikisTarih);
            komut3.Parameters.AddWithValue("@g5", j.KiraID);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool kirasil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from kiralama where kiraID = @s1", dataAccessLayer.baglanti);

            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@s1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
    }
}
