using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kitaplık
{

  
    internal class kitapvt
    {
        SqlConnection baglatı = new SqlConnection(@"Data Source=DESKTOP-AJM9AQ8\SQLEXPRESS;Initial Catalog=Kitaplık;Integrated Security=True");

        public List<kitap> liste()
        {
            List<kitap >ktp = new List<kitap>();
            baglatı .Open();
            SqlCommand komut = new SqlCommand("select * from tblkitaplar", baglatı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kitap k = new kitap();
                k.ID = Convert .ToInt16 (dr[0].ToString());
                k.Ad = dr[1].ToString();
                k.Yazar = dr[2].ToString();

                ktp.Add(k);
            }
            baglatı .Close();
            return ktp;


        }

        public void kitapekle(kitap kt)
        {
            baglatı .Open();
            SqlCommand komut = new SqlCommand("insert into tblkitaplar(KİTAPAD,YAZAR) VALUES (@p1,@p2)", baglatı);
            komut.Parameters.AddWithValue("@p1", kt.Ad);
            komut .Parameters .AddWithValue ("@p2",kt.Yazar);
            komut .ExecuteNonQuery ();
            baglatı .Close();

        }
    }
}
