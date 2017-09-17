using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyCollectionDemo
    {
        public static void Demo()
        {
            MyCollection<int> myInts = new MyCollection<int>();
            myInts.Add(44);

            MyCollection<string> myStrings = new MyCollection<string>();
            myStrings.Add("hoi");
        }
    }

    class MyCollection<T>
    {
        private T [] array = new T [10];
        private int cursor = 0;

        public void Add(T n)
        {
            if (cursor < 10)
                array[cursor++] = n;
        }
        
    }

    

}
