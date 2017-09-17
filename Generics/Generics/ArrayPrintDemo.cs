using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ArrayPrintDemo
    {
        public static void Demo()
        {
            char[] charArray = { 'a', 'D', '%' };
            double[] doubleArray = { 1.9, 3.8, 5.3, 9.3 };

            // Aanroep van de niet-generic versie
            PrintArray(charArray);
            PrintArray(doubleArray);

            // Aanroep van de generic versie
            PrintArray<char>(charArray);
            PrintArray<double>(doubleArray);
        }
    
        public static void PrintArray(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintArray(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

        // Generic versie
        public static void PrintArray<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
