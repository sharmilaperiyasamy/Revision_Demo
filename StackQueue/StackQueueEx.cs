using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class StackQueueEx
    {
        public static void stackExample()
        {
            //push
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(6);
            st.Push(5);
            // pop
            st.Pop();

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack : " + st.Count);
            Console.WriteLine("Does the stack contain the elements 3 : " + st.Contains(3));
            //peek
            if (st.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("Element at the top = " + st.Peek());
            }
            //isEmpty
            if (st.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("Stack is not empty");
            }

            //size
            if (st.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("Stack size is " + st.Count);
            }

            Console.ReadKey();
        }
    }
}
