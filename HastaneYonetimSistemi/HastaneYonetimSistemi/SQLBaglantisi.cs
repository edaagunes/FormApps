using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneYonetimSistemi
{
    internal class SQLBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3OD251U\\SQLEXPRESS;Initial Catalog=HastaneYonetimSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
