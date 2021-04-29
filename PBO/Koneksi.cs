using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace PBO
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=LAPTOP-PI7J2QHN;Initial Catalog=Kasir;Integrated Security=True;Pooling=False";
            return Conn;
        } 
        
    }
}
