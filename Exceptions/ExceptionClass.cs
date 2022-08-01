using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionstypes
{
    public class ExceptionClass
    {
        public static void indexexp()
        {
            //IndexOutOfRange exception
            try
            {
                int[] arr = new int[5] { 10, 30, 25, 45, 65 };
                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[1]);
                Console.WriteLine(arr[2]);
                Console.WriteLine(arr[3]);
                Console.WriteLine(arr[4]);
                Console.WriteLine(arr[5]); // throws IndexOutOfRange exception
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : {0}", ex.Message);
            }
        }
        //NullReferenceException
            public static void Nullexp()
            {
                IList<string> cities = null;
                DisplayCities(cities);
            }

            public static void DisplayCities(IList<string> cities)
            {
                foreach (var city in cities)
                {
                    Console.WriteLine(city);
                }
            }
        //InvalidOperationException
        public static void Withdraw(int amount)
        {
            int Balance = 100;
            Console.WriteLine("Withdrawing {0} from the Hari's account", amount);
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient fund");
            Balance = Balance - amount;
            Console.WriteLine($"Transaction completed. Account Balance is {Balance}");
        }
        //Argument Exception
        public static int DivideByTwo(int num)
        {
            // If num is an odd number, throw an ArgumentException.
            if ((num & 1) == 1)
                throw new ArgumentException("Number must be even", "num");

            // num is even, return half of its value.
            return num / 2;
        }
        //ArgumentNullException
        public static void Argumentnullexp()
        {
            string val = null;
            int res = int.Parse(val); // error is thrown
        }
        //ArgumentOutOfRangeException
        public static void argumentoutofrangeexp()
        {
            try
            {
                var numbers = new List<int>();
                var index = 0;
                Console.WriteLine("Removing item at index {0}", index);

                numbers.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Oh no! Something went wrong");
                Console.WriteLine(ex);
            }
        }
    }
}
