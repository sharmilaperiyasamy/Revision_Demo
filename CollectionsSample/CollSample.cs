using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsSample
{
    public class CollSample
    {
        public static void CollectionsSample()
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("List Operations : ");
            List<string> list = new List<string>();
            list.Add("Anitha");
            list.Add("Kavi");
            list.Add("Anitha");
            list.Add("Kavi");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------");
        }
        private static void doStackDemo()
        {
            Console.WriteLine("Stack Operations : ");
            Stack<string> stack = new Stack<string>();
            stack.Push("Shankar");
            stack.Push("Saravan");
            stack.Push("Ragu");
            stack.Push("Savitha");
            stack.Push("Santhosh");
            string pop=stack.Pop();
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Popped Element : " + pop);
            Console.WriteLine("--------------------------------------------");
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("Queue Operations : ");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Sanjay");
            queue.Enqueue("Anisha");
            queue.Enqueue("Prashanth");
            queue.Enqueue("Anu");
            Console.WriteLine("Element at the top of the Queue : " + queue.Peek());
            Console.WriteLine("\nIterating the Queue elements are : ");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element : " + dequeue);
            Console.WriteLine("\n Iterating the Queue elements after the dequeue of one element are : ");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine("--------------------------------------------");
        }
        private static void doSetDemo()
        {
            Console.WriteLine("Set operations are : ");
            var set = new HashSet<string>();
            set.Add("Anitha");
            set.Add("Kavi");
            set.Add("Anitha");
            set.Add("Kavi");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine("--------------------------------------------");
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("Dictionary operations are : ");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(10, "Hello");
            dictionary.Add(11, "Hi");
            dictionary.Add(12, "Welcome");
            dictionary.Add(13, "to");
            dictionary.Add(14, "all");
            Console.WriteLine("Accessing value using key(key = 10) : " + dictionary[10]);
            Console.WriteLine("Iterating Dictionary : ");
            foreach(var item in dictionary)
            {
                Console.WriteLine("key : " + item.Key + " Value : " + item.Value);
            }
        }
    }
}
