using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_Databse_Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // http://www.connectionstrings.com/sql-server/
                // use "." for local server like: '.\myInstanceName'
                string connectionString = @"Server=192.168.56.101;Database=Cocktail_Project;User Id=Bumsti;Password=3uuabe4A;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string commandstring = "SELECT * FROM Cocktails";
                    SqlCommand command = new SqlCommand(commandstring, connection);
                    SqlDataReader reader;
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["CID"] + "\t" + reader["Preis"] + "\t" + reader["Beschreibung"] + "\t" + reader["Bild"] + "\t" + reader["Bewertung"] + "\t" + reader["KatID"]);

                    }
                    Console.ReadKey();
                }


            }
        }
    }
}
