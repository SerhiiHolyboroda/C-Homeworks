using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src
{
    internal class CheckResults
    {
        public static async void CheckTaskResults(string query) {
           

                string connectionString = "Server=DESKTOP-A8R3DHS;Database=master;Trusted_Connection=True;";

            string sqlExpression = query; 
     
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {

                            string columnName1 = reader.GetName(0);
                            string columnName2 = reader.GetName(1);
                            string columnName3 = reader.GetName(2);

                            Console.WriteLine($"{columnName1}\t{columnName3}\t{columnName2}");

                            while (await reader.ReadAsync())
                            {
                                object ord_id = reader.GetValue(0);
                                object ord_an = reader.GetValue(2);
                                object ord_datetime = reader.GetValue(1);

                                Console.WriteLine($"{ord_id} \t{ord_an} \t{ord_datetime}");
                            }
                        }
                    }
                }

                Console.Read();

            }
        }
    }

    