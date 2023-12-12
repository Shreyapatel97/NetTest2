using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTest2
{

    public delegate void OrderEventHandler(object sender, OrderEventArgs e);

    public class Order
    {
       
        public event OrderEventHandler OrderPlaced;

        public void PlaceOrder(string prdName)
        {
            OnOrderPlaced(prdName);
        }

        
        protected virtual void OnOrderPlaced(string productName)
        {
            OrderPlaced?.Invoke(this, new OrderEventArgs(productName));
        }
    }
}

