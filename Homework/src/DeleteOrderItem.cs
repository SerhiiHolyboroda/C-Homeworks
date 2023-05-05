using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src
{
    internal class DeleteOrderItem
    {
        public static async void DeleteOrder()
        {

            string connectionString = "Server=DESKTOP-A8R3DHS;Database=master;Trusted_Connection=True;";
            string sqlExpression = "DELETE  FROM Orders WHERE ord_datetime ='1880-02-07 00:00:00.000'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = await command.ExecuteNonQueryAsync();
                    Console.WriteLine($"Видалено об'єктів: {number}");
                }
                Console.Read();
            }
        }
    }
 
