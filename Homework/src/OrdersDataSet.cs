using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;


namespace Homework.src
{
    internal static class OrdersDataSet
    {
        static async Task Main(string[] args)
        {
            InitializeComponent();

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        string sql = "SELECT * FROM Users";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
    // Создаем объект Dataset
    DataSet ds = new DataSet();
    // Заполняем Dataset
    adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}