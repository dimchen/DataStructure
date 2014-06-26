using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverseString
{
    class myStackQueue
    {
        private myQueue _Q1, _Q2;
        private int size;
        public myStackQueue()
        {
            size = 0; 
            _Q1 = new myQueue();
            _Q2 = new myQueue();
        }

        public void push(char a)
        {
            _Q1.push(a);
        }

        public char pop()
        {
            
            while (_Q1.count() > 1)
            {
                _Q2.push(_Q1.pop());
            }
            char temp = _Q1.pop();
            while (_Q2.count() > 0)
            {
                _Q1.push(_Q2.pop());
            }
            return temp;
        }

        public int Count()
        {
            return _Q1.count();
        }
    }
}
