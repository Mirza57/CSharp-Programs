using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_Keyword_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in MathOperations(3,9)) 
            {
                Console.WriteLine(item);
            }
        }


        /*
         *  Yield Keyword is so powerful.
         *  We can change the view of program
         *  we can return more then one thing using Yield Keyword
         */
        public static IEnumerable<double> MathOperations(int num1, int num2)
        {
           yield return num1 + num2;
           yield return num1 * num2;
           yield return num1 - num2;
           yield return Math.Round((double)num1 / (double)num2, 2);

        }
    }
}
