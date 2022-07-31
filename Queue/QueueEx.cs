using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueEx
    {
        //Queue
        public static void queueExample()
        {
            // creates a queue
            Queue<string> queue1 = new Queue<string>();
            //Adding item to the queue
            queue1.Enqueue("Pencil");
            queue1.Enqueue("Pen");
            queue1.Enqueue("Scale");
            queue1.Enqueue("Eraser");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }

            //Peek operation get the top first element in the queue
            Console.WriteLine("Peek the first item from the queue is:" + queue1.Peek());
            
            //remove the element in the queue
            queue1.Dequeue();

            //display the elements in the queue
            Console.WriteLine("After removal the elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            //check the item contains in the queue
            Console.WriteLine("The element MCA is contain in the queue:" + queue1.Contains("Pencil"));
            Console.WriteLine("The element MCA is contain in the queue:" + queue1.Contains("Pen"));
            queue1.Dequeue();
            Console.WriteLine("Peek the next item from the queue is:" + queue1.Peek());
            //size
            Console.WriteLine("Number of elements in queue1:" + queue1.Count());

            //check queue is empty or not
            if (queue1.Count() == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
                Console.WriteLine("Queue is not empty");
        }
    }
}
