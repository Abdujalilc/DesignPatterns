using System;

namespace FacadeDesignPattern
{    
    class MyClass
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
