using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formatted = "";
            formatted = string.Format(" Date and Time is: {0:MMMM dddd yyyy HH  mm ss tt }", myDate);
            Console.WriteLine(formatted);


            // 1) Format: Saturday of month January 2023

            formatted = string.Format("{0: dddd 'of month' MMMM yyyy  }", myDate);
            Console.WriteLine(formatted);
           

            // Taking Input 

            Console.WriteLine(" Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: {0:} ",name);
            Console.ReadLine() ;    
        }
    }
}
