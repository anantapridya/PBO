using System;
using System.Data;
using System.Data.SqlClient;

namespace PBO
{
    class Program
    {
        static string connectionstring = "Data Source=LAPTOP-PI7J2QHN;Initial Catalog=Kasir;Integrated Security=True;Pooling=False";
        static SqlConnection sqlconn = new SqlConnection(connectionstring);
        static void Main()
        {
            string username;
            string password;
            using (sqlconn)
            {
                try
                {
                    sqlconn.Open();
                    SqlCommand cmd = new SqlCommand("select Count(*) From Login Where Username = @uname and Password=@pass", sqlconn);
                    Console.WriteLine("Masukkan Username  : ");
                    username = Console.ReadLine();
                    Console.WriteLine("Masukkan Username  : ");
                    password = Console.ReadLine();
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    int result = (int)cmd.ExecuteScalar();
                    if (result>0)
                    {
                        Beli b = new Beli();
                        b.Menu();
                        Console.WriteLine("Barang Yang Di Beli");
                        b.hitung();
                    }
                    else
                    {
                        Console.WriteLine("Username atau Password Salah");
                        System.Environment.Exit(0);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}

