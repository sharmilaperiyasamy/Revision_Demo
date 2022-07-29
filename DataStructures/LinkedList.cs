using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        public static void linkedList()
        {
            // Create the link list.
            string[] array = { "Honey", "is", "eating" };
            LinkedList<string> list = new LinkedList<string>(array);
            Display(list, "The Linked List values are : ");

            // Add the word 'Daughter' to the beginning of the linked list.
            list.AddFirst("Daughter");
            Display(list, "Test 1: Add 'Daughter' to beginning of the list: ");

            // Remove the word 'Daughter' to the beginning of the linked list.
            list.Remove("Daughter");
            Display(list, "Test 2: Remove 'Daughter' from the beginning of the list: ");

            // To check if a value is in LinkedList returns boolean value
            Console.WriteLine(list.Contains("is"));

            //isEmpty & size of the list
            if (list.Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.WriteLine("List contains " + list.Count + " elements");
            }
            //Append the item to the list. It gets added as the last item of the list
            list.AddLast("Cookies");
            Display(list, "After Appending  the list becomes : ");

            // displaing the list
            Display(list, "The list is ");

            //index of the item
            Console.WriteLine("Test : Copy the list to an array:");
            // Create an array with the same number of elements as the linked list.
            string[] sArray = new string[list.Count];
            list.CopyTo(sArray, 0);

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }
            string item = "Cookies";
            int index = Array.IndexOf(sArray,item);
            if (index != -1)
            {
                Console.WriteLine(String.Format("Element {0} is found at index {1}", item, index));
            }
            else
            {
                Console.WriteLine("Element not found in the given array.");
            }
            //pop
            if (list.Contains("Today"))
            {
                list.Remove("Today");
                Display(list, "The list contains : ");
            }
            else
            {
                Console.WriteLine("Today is not found in the list");
            }
        }
        private static void Display(LinkedList<string> array, string test)
        {
            Console.WriteLine(test);
            foreach (string word in array)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }
    }
}
