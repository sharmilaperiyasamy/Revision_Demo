using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DataStructures
{
    public class HashTable
    {
        public static void Hash()
        {
            //using dictionary 
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht = new Hashtable(dict);
            Console.WriteLine("HashTable are key value pairs");
            foreach (var a in ht.Keys)
            {
                Console.WriteLine("{0}and {1}", a,
                                ht[a]);
            }
            Console.WriteLine("Total elements: {0}", ht.Count);

            // Adding key/value pair in the hashtable Using Add() method
            Hashtable ht1 = new Hashtable();
            
            ht1.Add("A1", "Welcome");
            ht1.Add("A2", "to");
            ht1.Add("A3", "GeeksforGeeks");

            Console.WriteLine("Key and Value pairs from myHT1:");

            foreach (DictionaryEntry x in ht1)
            {
                Console.WriteLine("{0} and {1} ", x.Key, x.Value);
            }
            //remove a pair in the hashtable
            ht1.Remove("A2");
            Console.WriteLine("Total number of elements present" + " in myHT1:{0}", ht1.Count);
            //clear() will remove all the items in the hashtable
            //ht1.Clear();

            // Determine whether the given key present or not using Contains method
            Console.WriteLine(ht1.Contains("A3"));
            Console.WriteLine(ht1.Contains(12));
            Console.WriteLine();

            // Determine whether the given key present or not using ContainsKey method
            Console.WriteLine(ht1.ContainsKey("A1"));
            Console.WriteLine(ht1.ContainsKey(1));
            Console.WriteLine();

            // Determine whether the given value present or not using ContainsValue method
            Console.WriteLine(ht1.ContainsValue("geeks"));
            Console.WriteLine(ht1.ContainsValue("to"));
        }
    }
}
