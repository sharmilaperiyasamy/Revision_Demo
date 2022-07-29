using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConcepts
{
    public class Generics_coreconcepts
    {
        //generic methods
        public static void display(int[] inputArray)
        {
            foreach (var input in inputArray)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine("------------------------------------");
        }
        public static void display(string[] inputArray)
        {
            foreach (string input in inputArray)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine("------------------------------------");
        }
        public static void display(double[] inputArray)
        {
            foreach (double input in inputArray)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine("------------------------------------");
        }
    }
    public class Implementgenericmethod
        {
        //After generic method implementation
        public static void print<T>(T[] inputArray)
        {
            foreach (var input in inputArray)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine("------------------------------------");
        }
    }
    // generic concept in class
    public class GenericClass<T>
    {
        private T[] inputArray;
        // constructor is used
        public GenericClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toPrint()
        {
            foreach (var input in inputArray)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine("------------------------------------");
        }
    }
}

