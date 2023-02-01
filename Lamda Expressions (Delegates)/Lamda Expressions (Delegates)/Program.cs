using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Expressions__Delegates_
{

    public delegate void DisplayData();
    public delegate int MultiplyData(int n);
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayData displayData = () => { Console.WriteLine("Its a Delegate method for showing Upcoming Data"); };
            displayData();
            Console.WriteLine();
            MultiplyData multiplyData = n => n * 10;
            Console.WriteLine($"Your Input is : {10} and output will be : "+multiplyData(10));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("****************************************");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(3);
            list.Add(5);
            list.Add(6);
            list.Add(9);
            list.Add(32);
            list.Add(44);
            list.Add(21); 
            list.Add(97);

            ShowResults(list);

        }

        public static void ShowResults(List<int> list) 
        {
            Console.WriteLine("Total numbers in List are : ");
            foreach (var item in list)
            {
                Console.Write(item+" , ");
            }
            Console.WriteLine();
            Console.WriteLine("***********************************************************");

            /*
             * This is the way to write Lamda Expressions
             */
            var oddList =list.Where(n => n % 2 !=0).ToList();
            var evenList = list.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("These are the odd numbers which are present in your list");
            foreach (var item in oddList)
            {
                Console.WriteLine("Odd number : "+item+" ,");
            }


            Console.WriteLine("***********************************************************");
            Console.WriteLine("These are the even numbers which are present in your list");
            foreach (var item in evenList)
            {
                Console.WriteLine("Even number : "+item+" ,");
            }
        }
    }
}
