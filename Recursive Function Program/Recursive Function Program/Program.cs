using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Function_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine($"Input is equal to : {x}");

            Console.WriteLine("Output of the factorial will be : " + RecursiveFunction(x));
            var player = (7, "Mirza", 7.8);
            Console.WriteLine(player);


        }
        public static int RecursiveFunction(int input) 
        {
            if (input == 0)
            return 1;
            
            return input * RecursiveFunction(input - 1);

           
        }
    }
}
