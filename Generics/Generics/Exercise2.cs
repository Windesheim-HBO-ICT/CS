using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Exercise2
    {
        public static void Demo()
        {
            MijnGenericArray<char> charArray = new MijnGenericArray<char>(7);

            for (int i = 0; i < 7; i++)
            {
                charArray.ZetItem(i, (char)(i + 97));
            }

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{charArray.GeefItem(i)} ");   
            }
            Console.WriteLine();

        }
    }

    public class MijnIntArray
    {
        private int[] array;
        public MijnIntArray(int size)
        {
            array = new int[size];
        }
        public int GeefItem(int index)
        {
            return array[index];
        }
        public void ZetItem(int index, int value)
        {
            array[index] = value;
        }
      
    }

    public class MijnGenericArray<T>
    {
        private T[] array;
        public MijnGenericArray(int size)
        {
            array = new T[size];
        }
        public T GeefItem(int index)
        {
            return array[index];
        }
        public void ZetItem(int index, T value)
        {
            array[index] = value;
        }
    }

}
