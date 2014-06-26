using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverseString
{
    class myStack
    {
        private int myCount;
        private int size;
        private char thisChar;
        private char[] charArry;
        private int charSize = 100;
        public myStack()
        {
            charArry = new char[charSize];
            size = 0;
        }

        public void Push(char a)
        {
            if (size + 1 < charSize)
            {
                size++;
                charArry[size] = a;
            }
            else
            {
                return;
            }
        }

        public char Pop()
        {
            char temp = charArry[size];
            //if (size > 0)
            size--;
            return temp;
        }

        public int Count()
        {
            return size + 1;
        }
    }
}
