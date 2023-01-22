using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Task 01 : Even numbers");
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");

                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task 02 : Print the triangle");
            for (int x = 0; x <= 10; x++)
            {


                for (int j = 0; j <= x; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }



            Console.WriteLine(" Task 3: Print Upside down triangle");
            for (int i = 0; i <= 10 ; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("0");
                }

                Console.WriteLine();

            }
            }
        }
    }
