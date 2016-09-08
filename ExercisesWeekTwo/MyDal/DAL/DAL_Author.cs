using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDal.Models;
using System.Data;

namespace MyDal.DAL
{
    public class DAL_Author
    {
        private SqlConnection _sqlConnection = null;

        public void OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }
        public void CloseConnection()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }

        public void InsertAuthor(string firstName, string lastName)
        {
            var sql = $"INSERT INTO Authors(FirstName, LastName) VALUES('{firstName}','{lastName}')";

            using (var cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void InsertAuthor(Author author)
        {
            var sql = $"INSERT INTO Authors(FirstName, LastName) VALUES('{author.FirstName}','{author.LastName}'";

            using (var cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteAuthor(int id)
        {
            var sql = $"DELETE FROM AUTHORS WHERE AuthorID = {id}";

            using(var cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateAuthorLastName(string lastName, int id)
        {
            var sql = $"UPDATE Authors SET LastName = '{lastName}' WHERE AuthorID = {id}";

            using(var cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }

        }
        public List<Author> GetAllAuthorsToList()
        {
            var sql = "SELECT * FROM Authors";
            var authorList = new List<Author>();

            using (var cmd = new SqlCommand(sql, _sqlConnection))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    authorList.Add(new Author
                    {
                        AuthorID = (int)reader["AuthorID"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"]

                    });
                }
            }
            return authorList;
        }
        public DataTable GetAllAuthorsToDataTable()
        {
            var dataTable = new DataTable();
            var sql = "Select * FROM Authors";

            using(var cmd = new SqlCommand(sql, _sqlConnection))
            {
                var reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

    }
}
