using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NotGiris
{
    class SqlBaglanti
    {
        public SqlConnection  baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6UIKHI6\\MHENDISBEY;Initial Catalog=OgrenciNot;Integrated Security=True");
            baglan.Open();
            return baglan;

            
        }
    }
}
