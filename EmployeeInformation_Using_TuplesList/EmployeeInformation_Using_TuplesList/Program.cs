using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation_Using_TuplesList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int,string,string,DateTime>> list = new List<Tuple<int, string, string, DateTime>>();
            list.Add(Tuple.Create(3, "Mirza Arslan",  "CS Engineer", new DateTime(2023,12,9)));
            list.Add(Tuple.Create(6, "Osama Ahmed", "CS Engineer", new DateTime(2022, 11, 3)));
            list.Add(Tuple.Create(9, "Ovais Memon", "CS Engineer", new DateTime(2021, 10, 13)));

            foreach (var info in list) 
            {
                Console.WriteLine("Id of student          : " +info.Item1);
                Console.WriteLine("Name of student        : " + info.Item2);
                Console.WriteLine("Department of student  : " + info.Item3);
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
            }

        }

        
    }


}
