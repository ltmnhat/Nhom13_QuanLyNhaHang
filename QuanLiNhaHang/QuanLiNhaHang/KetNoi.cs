using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLiNhaHang
{
    class KetNoi
    {
        public SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(@"Data Source=MINHNHAT\SQLEXPRESS; Initial Catalog = QUANLI_NHAHANG; Integrated Security = True");
        }
    }
}
