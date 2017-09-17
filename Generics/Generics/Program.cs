using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ArrayPrint Demo ===");
            ArrayPrintDemo.Demo();

            Console.WriteLine("=== MyCollection Demo ===");
            MyCollectionDemo.Demo();

            Console.WriteLine("=== Exercise 1 ===");
            Exercise1.Demo();

            Console.WriteLine("=== Exercise 2 ===");
            Exercise2.Demo();

            Console.WriteLine("=== Constraint Demo ===");
            ConstraintDemo.Demo();

            Console.ReadKey();
        }


    }
}
