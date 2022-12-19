using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        
        public static void print_array<T>(T[] result)
        {
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNum = { 10, 20, 30, 40 };

            print_array(cars);
            print_array(myNum);

            Console.ReadKey();
        }

    }
}
