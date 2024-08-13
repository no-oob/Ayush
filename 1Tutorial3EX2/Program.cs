using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Tutorial3EX2
{
    class Geeks
    {
        public static void Main(string[] args)
        {
            List<String> mylist = new List<String>();
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int j = 0; j < cars.Length; j++)
            {
                mylist.Add(cars[j]);
                
            }
            Console.WriteLine("Cars List:");
            foreach (String items in mylist)
            {
            
                Console.WriteLine(items);
            }
            Console.Read();
        }
    }
}
