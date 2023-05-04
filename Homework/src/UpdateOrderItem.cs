using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src
{
    internal class UpdateOrderItem
    {
        public static async void updateOldOrder()
        {


            string connectionString = "Server=DESKTOP-A8R3DHS;Database=master;Trusted_Connection=True;";
            string sqlExpression = "UPDATE Orders SET ord_datetime = '1880-02-07 00:00:00.000' WHERE ord_datetime  = '2020-02-07 00:00:00.000' ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = await command.ExecuteNonQueryAsync();
                Console.WriteLine($"Оновленно об'єктів: {number}");
            }
            Console.Read();
        }
    }
}