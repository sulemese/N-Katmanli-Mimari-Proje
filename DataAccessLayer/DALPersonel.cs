using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();

            SqlCommand komut1 = new SqlCommand("select * from TBLBİLGİ", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["ŞEHİR"].ToString();
                ent.Gorev = dr["GÖREV"].ToString();               
                ent.Maaş= short.Parse(dr["MAAŞ"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBİLGİ (AD,SOYAD,GÖREV,ŞEHİR,MAAŞ) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", p.Ad);
            komut.Parameters.AddWithValue("@p2", p.Soyad);
            komut.Parameters.AddWithValue("@p3", p.Gorev);
            komut.Parameters.AddWithValue("@p4", p.Sehir);
            komut.Parameters.AddWithValue("@p5", p.Maaş);
            
            int result = komut.ExecuteNonQuery();//satır sayısı döndürür
            return result;
        }

        public static int PersonelSil(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("delete from TBLBİLGİ where ID=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", p.Id);
            int result = komut.ExecuteNonQuery();
            return result;
        }

        public static int PersonelGüncelle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("update  TBLBİLGİ set AD=@P2,SOYAD=@P3,GÖREV=@P4,MAAŞ=@P5,ŞEHİR=@P6 where ID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", p.Id);
            komut.Parameters.AddWithValue("@P2", p.Ad);
            komut.Parameters.AddWithValue("@P3", p.Soyad);
            komut.Parameters.AddWithValue("@P4", p.Gorev);
            komut.Parameters.AddWithValue("@P5", p.Maaş);
            komut.Parameters.AddWithValue("@P6", p.Sehir);
            int result = komut.ExecuteNonQuery();
            return result;
           
        }
    }
}
