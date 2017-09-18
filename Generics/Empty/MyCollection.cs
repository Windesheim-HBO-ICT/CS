using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class MyCollection
    {
        private int[] array = new int[10];
        private int cursor = 0;

        public void Add(int n)
        {
            if (cursor < 10)
            {
                array[cursor++] = n;
            }
        }

        public static void Demo()
        {
            MyCollection mc1 = new MyCollection();
            mc1.Add(33);
        }
    }

}
