using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverseString
{
    class myQueue
    {
        private char[] charArry;
        private int totalLength, size;
        public myQueue()
        {
            totalLength = 100;
            charArry = new char[totalLength];
            size = 0;
        }

        public void push(char a)
        {
            if (size + 1 < totalLength) 
            {
                charArry[size] = a;
                size++;
            }
            else
            {
                return;
            }
        }

        public char pop()
        {
            char temp = charArry[0];
            for (int i = 1; i < size; i++)
            {
                charArry[i - 1] = charArry[i];
            }
            size--;
            return temp;
        }

        public int count()
        {
            return size;
        }

    }
}
