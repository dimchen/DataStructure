using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverseString
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Input String FOR reverse\n");
            string myString = Console.ReadLine();
            Console.Write("\nStack Reverse \n");
            reverseStack(myString);
            Console.Write("\nQueue \n");
            pushString_Queue(myString);
            Console.Write("\nReverse String using Queue\n");
            reverseString_Queue(myString);
            Console.ReadLine();
        }

        static void reverseString_Queue(string str)
        {
            myStackQueue _stackQ = new myStackQueue();
            if (!string.IsNullOrEmpty(str))
            {
                foreach (char var in str)
                {
                    _stackQ.push(var);
                }
                while (_stackQ.Count() > 0)
                {
                    Console.Write(_stackQ.pop());
                }
            }
        }

        static void pushString_Queue(string str)
        { 
            myQueue _queue = new myQueue();
            if (!string.IsNullOrEmpty(str))
            {
                foreach (char var in str)
                {
                    _queue.push(var);
                }
                while (_queue.count() > 0)
                {
                    Console.Write(_queue.pop());
                }
            }
        
        }


        static void reverseStack(string str)
        {
            //Stack<char> temp = new Stack<char>();
            myStack _stack = new myStack();
            if (!string.IsNullOrEmpty(str))
            {
                foreach (char var in str)
                {
                    _stack.Push(var);
                }
                while (_stack.Count() > 0)
                {
                    Console.Out.Write(_stack.Pop());
                }
            }
        }
    }

    

    
}
