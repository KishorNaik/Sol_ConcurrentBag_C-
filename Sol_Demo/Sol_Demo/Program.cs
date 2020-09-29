using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Sol_Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConcurrentBag<int> bag1 = new ConcurrentBag<int>();
            bag1.Add(1);
            bag1.Add(2);
            bag1.Add(3);

            foreach (var item in bag1)
            {
                Console.WriteLine(item); // 3,2,1
            }

            // Convert into List
            List<int> list = bag1.ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // TryPeek method
            // It will return the first element of the concurrent bag found in the collection as an out parameter. Unlike TryTake, this method does not remove the item.
            int item1 = 0;
            bag1.TryPeek(out item1);
            Console.WriteLine($"Bag Value :{item1}");
            Console.WriteLine($"Bag Count :{bag1.Count}");

            // TryTake method
            // It will return the first element of the concurrent bag. The return value is returned as an out parameter. The method also removes the item from the bag.

            int item2 = 0;
            bag1.TryTake(out item2);
            Console.WriteLine($"Bag Value :{item2}");
            Console.WriteLine($"Bag Count :{bag1.Count}");

            List<String> listString = new List<string>();
            listString.Add("Hello");
            listString.Add("Concurrent");
            listString.Add("Bag");

            ConcurrentBag<String> bag2 = new ConcurrentBag<string>(listString);

            foreach (var item in bag2)
            {
                Console.WriteLine(item); // Bag,Concurrent, Hello
            }
        }
    }
}