using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTest2
{

    public class Program
    {
        static void Main()
        {
            
            Order order = new Order();


            NotificationService notifyService = new NotificationService();

           
            order.OrderPlaced += notifyService.SendNotification;

            
            order.PlaceOrder("Pizza");

            Console.ReadLine();
        }
    }

}