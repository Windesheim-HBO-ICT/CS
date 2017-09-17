using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ConstraintDemo
    {
        public static void Demo()
        {
            int maxInt = Maximum<int>(33, 6, 89);
            Console.WriteLine($"Max {maxInt}");

            string maxString = Maximum<string>("charlie", "alpha", "bravo");
            Console.WriteLine($"Max {maxString}");
        }

        public static T Maximum<T>(T first, T second, T third)
            where T : IComparable<T>
        {
            T max = first;
            if (second.CompareTo(first) > 0)
            {
                max = second;
            }
            if (third.CompareTo(max) > 0)
            {
                max = third;
            }
            return max;
        }

    }

   
}
