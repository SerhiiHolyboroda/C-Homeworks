using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Homework.src
{
    internal static class Program
    {
        static async Task Main(string[] args)
        {



            //    QueryData.QueryDataFromOrders();
            //     await Task.Delay(1000);


           CreateOrderItem.createNewOrder();
           await Task.Delay(1000);

           CheckResults.CheckTaskResults("SELECT * FROM Orders WHERE ord_datetime ='2020-02-07 00:00:00.000'");
           await Task.Delay(2000);


           UpdateOrderItem.updateOldOrder();
           await Task.Delay(1000);


           CheckResults.CheckTaskResults("SELECT * FROM Orders WHERE ord_datetime ='1880-02-07 00:00:00.000'");
           await Task.Delay(3000);


           DeleteOrderItem.DeleteOrder();
           await Task.Delay(1000);


           CheckResults.CheckTaskResults("SELECT * FROM Orders WHERE ord_datetime ='1880-02-07 00:00:00.000'");
           await Task.Delay(5000);


        }
    }
}