using System;
using System.Collections.Generic;
using QueueDemo.Models;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a queue of ints
            Queue<int> customerQueue = new Queue<int>();

            customerQueue.Enqueue(1);
            customerQueue.Enqueue(2);
            customerQueue.Enqueue(21);
            customerQueue.Enqueue(35);
            customerQueue.Enqueue(50);
            Console.WriteLine("Customer in front of the queue " + customerQueue.Peek() );

            // remove the first element
            while (customerQueue.Count > 0)
            {
                Console.WriteLine("Removing customer from the queue: " + customerQueue.Dequeue());
                Console.WriteLine("Remaining customers in line: " + customerQueue.Count);
                
            }

            // example with ORDER class
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in ReceiveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                // remove the first element and save it
                Order currentOrder = ordersQueue.Dequeue();
                // process our order
                currentOrder.ProcessOrder();
            }



            static Order[] ReceiveOrdersFromBranch1()
            {
                Order[] orders = new Order[]
                {
                    new Order(1, 5),
                    new Order(2, 4),
                    new Order(6, 10)
                };
                return orders;
            }

            static Order[] ReceiveOrdersFromBranch2()
            {
                Order[] orders = new Order[]
                {
                    new Order(3, 5),
                    new Order(4, 4),
                    new Order(5, 10)
                };
                return orders;
            }

        }
    }
}
