using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src
{
    internal class CreateOrderItem
    {

        public static async void createNewOrder()
        {
            string connectionString = "Server=DESKTOP-A8R3DHS;Database=master;Trusted_Connection=True;";
            string queryString = "INSERT INTO Orders (ord_id, ord_datetime, ord_an) VALUES (@ord_id, @ord_datetime, @ord_an)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ord_id", new Random().Next(1, 1000000));
                command.Parameters.AddWithValue("@ord_datetime", "2020-02-07 00:00:00.000");
                command.Parameters.AddWithValue("@ord_an", 1);

                try
                {
                    await connection.OpenAsync();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected + " \r\nвставлено рядків.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}