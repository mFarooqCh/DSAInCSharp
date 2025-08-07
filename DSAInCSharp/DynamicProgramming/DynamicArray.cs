using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAInCSharp.DynamicProgramming
{
    public class DynamicArray
    {
        private int[] dArray;
        private int _count = 0;
        public DynamicArray(int capacity)
        {
            if (capacity > 0)
            {
                dArray = new int[capacity];
            }
        }

        public int Get(int i)
        {
            return dArray[i];
        }

        public void Set(int i, int n)
        {
            dArray[i] = n;
        }

        public void PushBack(int n)
        {
            if (_count == dArray.Length)
            {
                Resize();
            }
            dArray[_count] = n;
            _count++;
        }

        public int PopBack()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Array is empty");
            }
            int last = dArray[_count - 1];
            _count--;
            return last;
        }

        private void Resize()
        {
            var newArray = new int[dArray.Length * 2];
            for (int i = 0; i < dArray.Length; i++)
            {
                newArray[i] = dArray[i];
            }
            dArray = newArray;
        }

        public int GetSize()
        {
            return _count;
        }

        public int GetCapacity()
        {
            return dArray.Length;
        }
    }

}
