using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;

namespace dataAccessLayer
{
    public class dalMusteri
    {
        public static List<EntityMusteri> musterilistesi()
        {
            List<EntityMusteri> deger = new List<EntityMusteri>();
            SqlCommand komut1 = new SqlCommand("select * from musteri", dataAccessLayer.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri mus = new EntityMusteri();
                mus.MusID = int.Parse(dr["musID"].ToString());
                mus.MusAD = dr["musAD"].ToString();
                mus.MusSoyad = dr["musSoyad"].ToString();
                mus.OdaNum = dr["odaNum"].ToString();
                mus.Durum1 = Convert.ToBoolean(dr["Durum"].ToString());
                mus.MusCinsiyet = dr["musCinsiyet"].ToString();
                mus.MusMedeni = dr["musMedeni"].ToString();
                mus.MusSayi = int.Parse(dr["musSayi"].ToString());
                mus.MusCocuk = int.Parse(dr["musCocuk"].ToString());
                mus.MusAdres = dr["musAdres"].ToString();
                deger.Add(mus);
            }
            dr.Close();
            return deger;
        }

        

        public static int musekle(EntityMusteri n)
        {
            SqlCommand komut2 = new SqlCommand("insert into musteri(muskimlikno, musAD, musSoyad, odaNum, Durum, musCinsiyet, musMedeni, musSayi, musCocuk, musAdres, musGirisTarihi, musCikisTarihi) values (@e1, @e2, @e3, @e4, @e5, @e6, @e7, @e8, @e9, @e10, @e11, @e12)", dataAccessLayer.baglanti);
            if (komut2.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut2.Connection.Open();
            }
            
            komut2.Parameters.AddWithValue("@e1", n.Muskimlikno);
            komut2.Parameters.AddWithValue("@e2", n.MusAD);
            komut2.Parameters.AddWithValue("@e3", n.MusSoyad);
            komut2.Parameters.AddWithValue("@e4", n.OdaNum);
            komut2.Parameters.AddWithValue("@e5", n.Durum1);
            komut2.Parameters.AddWithValue("@e6", n.MusCinsiyet);
            komut2.Parameters.AddWithValue("@e7", n.MusMedeni);
            komut2.Parameters.AddWithValue("@e8", n.MusSayi);
            komut2.Parameters.AddWithValue("@e9", n.MusCocuk);
            komut2.Parameters.AddWithValue("@e10", n.MusAdres);
            komut2.Parameters.AddWithValue("@e11", n.MusGirisTarihi);
            komut2.Parameters.AddWithValue("@e12", n.MusCikisTarihi);
            
            return komut2.ExecuteNonQuery();
        }

        public static bool mussil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from musteri where musID = @s1", dataAccessLayer.baglanti);

            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@s1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool musgun(EntityMusteri k)

            
        {
            SqlCommand komut4 = new SqlCommand("update musteri set muskimlikno = @y1, musAD = @y2, musSoyad = @y3, odaNum = @y4, Durum = @y5, musCinsiyet = @y6, musMedeni = @y7, musSayi = @y8, musCocuk = @y9, musAdres = @y10  where musID = @y10", dataAccessLayer.baglanti);
            if (komut4.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut4.Connection.Open();
            }

            komut4.Parameters.AddWithValue("@y1", k.Muskimlikno);
            komut4.Parameters.AddWithValue("@y2", k.MusAD);
            komut4.Parameters.AddWithValue("@y3", k.MusSoyad);
            komut4.Parameters.AddWithValue("@y4", k.OdaNum);
            komut4.Parameters.AddWithValue("@y5", k.Durum1);
            komut4.Parameters.AddWithValue("@y6", k.MusCinsiyet);
            komut4.Parameters.AddWithValue("@y7", k.MusMedeni);
            komut4.Parameters.AddWithValue("@y8", k.MusSayi);
            komut4.Parameters.AddWithValue("@y9", k.MusCocuk);
           komut4.Parameters.AddWithValue("@y10", k.MusAdres);
           komut4.Parameters.AddWithValue("@y11", k.MusID);
            
            
            return komut4.ExecuteNonQuery() > 0;
        }


    }
}
