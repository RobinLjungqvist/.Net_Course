using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NETdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString =
                    @"Data Source=(local);Initial Catalog=books;User ID=Ropplon; Password=robin;Integrated Security = True";
                con.Open();

                string sql = "Select * from Authors";
                SqlCommand myCommand = new SqlCommand(sql, con);

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    ShowConnectionStatus(con);
                    while (myDataReader.Read())
                    {
                        Console.WriteLine("FirstName: " + myDataReader["FirstName"] + " | LastName: " + myDataReader["LastName"]);
                    }
                }
            }
            AddAuthor();
            Console.ReadKey();
        }

        private static void ShowConnectionStatus(SqlConnection con)
        {
            Console.WriteLine("Databae location: " + con.DataSource);
            Console.WriteLine("Database name: " + con.Database);
            Console.WriteLine("Timeout: " + con.ConnectionTimeout);
            Console.WriteLine("Connection state: " + con.State);
        }

        private static void AddAuthor()
        {
            Console.WriteLine("Enter FirstName of the author to add:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter LastName of the author to add:");
            string lName = Console.ReadLine();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString =
                    @"Data Source=(local);Initial Catalog=books;User ID=Ropplon; Password=robin;Integrated Security = True";
                con.Open();

                string sql =
                //$"Insert Into Authors (FirstName, LastName) Values('{fName}','{lName}')";

                $"Delete from Authors where FirstName = '{fName}' and LastName = '{lName}'";
                SqlCommand insertCmd = new SqlCommand(sql, con);

                if (insertCmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Author table is updated!");
                }
                else
                {
                    Console.WriteLine("Couldn't add the author, no rows were effected.");
                }
            }
        }
    }
}
