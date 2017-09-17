using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Exercise1
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Demo()
        {
            int x = 3, y = 9;
            Swap(ref x, ref y);
            Console.WriteLine($"x: {x} y: {y}");

            char a = 'h', b ='I';
            Swap(ref a, ref b);
            Console.WriteLine($"a: {a} b: {b}");

        }
    }
}
