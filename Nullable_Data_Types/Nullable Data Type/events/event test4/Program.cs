using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test4
{
    internal class Program
    {

        public class OrderEventArgs : EventArgs
        {
            public int _OrderID { get; }
            public int _OrderTotalPrice { get; }
            public string _ClientEmail { get; }

            public  OrderEventArgs(int orderID,int orderTotalPrice, string clientEmail)
            {
                this._OrderID = orderID;
                this._OrderTotalPrice = orderTotalPrice;
                this._ClientEmail = clientEmail;
            }
        }
        public class Order
        {
            public event EventHandler<OrderEventArgs> OnOrderAdding;
            public void AddOrder(int orderID, int orderTotalPrice, string clientEmail)
            {
                if (OnOrderAdding != null)
                {
                    OnOrderAdding(this,new OrderEventArgs(orderID,orderTotalPrice,clientEmail));    
                }
            }
           
        }
        public class EmailService
        {
         

            public void Subscriber(Order obj) {

                obj.OnOrderAdding += HandleNewOrder;
            }
            public void UnSubscriber(Order obj)
            {

                obj.OnOrderAdding -= HandleNewOrder;
            }

            public void HandleNewOrder(object obj, OrderEventArgs e) {

                Console.WriteLine($"\n_____________Email Service___________");
                Console.WriteLine($"Email Service Object Received a new Order Event ");
                Console.WriteLine($"Order ID. {e._OrderID}");
                Console.WriteLine($"Total Price : {e._OrderTotalPrice} $");
                Console.WriteLine($"Email : {e._ClientEmail}");
                Console.WriteLine($"Send an Email");
                Console.WriteLine("_____________________________________\n");

            }


        }
        public class SMSService
        {
            
            public void Subscriber(Order obj)
            {

                obj.OnOrderAdding += HandleNewOrder;
            }
            public void UnSubscriber(Order obj)
            {

                obj.OnOrderAdding -= HandleNewOrder;
            }

            public void HandleNewOrder(object obj, OrderEventArgs e)
            {

                Console.WriteLine($"\n________________SMS Service___________");
                Console.WriteLine($"SMS Service Object Received a new Order Event ");
                Console.WriteLine($"Order ID. {e._OrderID}");
                Console.WriteLine($"Total Price : {e._OrderTotalPrice} $");
                Console.WriteLine($"Email : {e._ClientEmail}");
                Console.WriteLine($"Send SMS");
                Console.WriteLine("_____________________________________\n");

            }


        }
        public class ShippingService
        {
          
            public void Subscriber(Order obj)
            {

                obj.OnOrderAdding += HandleNewOrder;
            }
            public void UnSubscriber(Order obj)
            {

                obj.OnOrderAdding -= HandleNewOrder;
            }

            public void HandleNewOrder(object obj, OrderEventArgs e)
            {
                Console.WriteLine($"\n________________Shipping Service___________");
                Console.WriteLine($"Shipping Service Object Received a new Order Event ");
                Console.WriteLine($"Order ID. {e._OrderID}");
                Console.WriteLine($"Total Price : {e._OrderTotalPrice} $");
                Console.WriteLine($"Email : {e._ClientEmail}");
                Console.WriteLine($"Handel Shipping");
                Console.WriteLine("_____________________________________\n");

            }


        }


        static void Main(string[] args)
        {
            Order order1 = new Order();
            EmailService email = new EmailService();
            SMSService sms = new SMSService();
            ShippingService shipping = new ShippingService();



            email.Subscriber(order1);
            sms.Subscriber(order1);
            shipping.Subscriber(order1);

            order1.AddOrder(10, 200, "khalidelmandour2021@gmail.com");


            sms.UnSubscriber(order1);
            shipping.UnSubscriber(order1);


            order1.AddOrder(99, 999, "khalidelmandour2021@gmail.com");

        }
    }
}
