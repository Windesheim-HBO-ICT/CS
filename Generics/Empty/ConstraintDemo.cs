using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class ConstraintDemo
    {
        public static void Demo()
        {
            int maxInt = Maximum(33, 6, 89);
            Console.WriteLine($"Max {maxInt}");

        }

        public static int Maximum(int first, int second, int third)
        {
            int max = first;
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
