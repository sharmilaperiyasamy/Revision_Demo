using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Single Cast Delegates

// for giving static input and single parameter passed inside the function
delegate int ArithmeticOperation(int num);
namespace Delegates
{
     public class DelegatesEx
    {
        static int num = 20;
        public static int Addition(int p)
        {
            num = num + p;
            return num;
        }
        public static int Multiplication(int p)
        {
            num = num * p;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
    }
}
