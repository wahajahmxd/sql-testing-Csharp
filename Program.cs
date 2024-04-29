// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Data.SqlClient;
using System.Data; 

namespace SqlTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            TestCrud();
        }

        public static void TestCrud()
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=NEWDB;Integrated Security=True;Encrypt=True; TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                string see = "Select * from customers";
                SqlCommand cmd = new SqlCommand(see, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader [0]);
                }
                conn.Close();
            }
        }
    }
}
