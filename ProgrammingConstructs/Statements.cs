using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Statements
    {
        public static void Selectionexpression()
        {
            string x = "Apple";
            string y = "Orange";
            if (x.Length > y.Length)
            {
                Console.WriteLine("Apple is Greater.");
            }
            else if (y.Length > x.Length)
            {
                Console.WriteLine("Orange is Greater.");
            }
            else
            {
                Console.WriteLine("Both the strings are equal.");
            }
        }
        public static void conditionalExpression()
        {
            int x = 5;
            int i = 0;
            string a = "Welcome";
            Console.WriteLine("While loop output : ");
            while (i < x)
            {
                Console.WriteLine(a);
                i++;
            }
            Console.WriteLine("For loop output : ");
            for (i = 0; i < x; i++)
            {
                Console.WriteLine(a);
            }
        }
        public static void caseStatements()
        {
            int a = 1;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Apple");
                    break;
                case 2:
                    Console.WriteLine("Orange");
                    break;
                default:
                    Console.WriteLine("Enter the fruit name : ");
                    break;
            }
        }
    }
}
