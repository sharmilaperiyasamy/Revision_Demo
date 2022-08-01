using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{   
    //using simple delegate function
    public class LambdaExp
    {
        public delegate int Square(int num);
         public static void LambdaExpr()
         {
            Square sq = delegate (int num)
            {
                return num * num;
            };

            Console.WriteLine(sq(5).ToString());
            Console.ReadLine();
         }

        //using lambda function
        public static void usingLambda()
        {
            Func<int, int> square = (i => i * i);
            Console.WriteLine(square(5).ToString());
            Console.ReadLine();
        }
    }
}
