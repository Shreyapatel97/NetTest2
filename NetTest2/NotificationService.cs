using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTest2
{


    public class NotificationService
    {
        
        public void SendNotification(object sender, OrderEventArgs e)
        {
            Console.WriteLine($" Order placed {e.PrdName}");
        }
    }

}