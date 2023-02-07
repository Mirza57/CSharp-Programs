using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_First_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataClass dataClass_1= new DataClass();
            DataClass dataClass_2 = new DataClass();

            List<DataClass> alllistRecords = new List<DataClass>();
            


            // for first Employee
            dataClass_1.EmployeeName = "Mirza Arslan";
            dataClass_1.EmployeeAge= 22;
            dataClass_1.EmployeeSalary= 50_000;

            dataClass_1.EmployeeApraisals = new List<int>();
            dataClass_1.EmployeeApraisals.Add(1);
            dataClass_1.EmployeeApraisals.Add(2);
            dataClass_1.EmployeeApraisals.Add(3);

            alllistRecords.Add(dataClass_1);

      
            // for second Employee
            dataClass_2.EmployeeName = "Osama Ahmed";
            dataClass_2.EmployeeAge = 22;
            dataClass_2.EmployeeSalary = 60_000;
           
            dataClass_2.EmployeeApraisals= new List<int>();
            dataClass_2.EmployeeApraisals.Add(6) ;
            dataClass_2.EmployeeApraisals.Add(9);
            dataClass_2.EmployeeApraisals.Add(11);

            alllistRecords.Add(dataClass_2);

            // calling method to show the records
            
            DisplayData(alllistRecords);
            

        }

        /*
         * Method for showing Information related to Employee
         */
        public static void DisplayData(List<DataClass> listOfApraisals)
        {
            /*
             * using LINQ to show data of that employee whose Salary is above 55_000
             */
            listOfApraisals = listOfApraisals.Where(e=> e.EmployeeSalary>=55_000).ToList();

            foreach (var dataClass in listOfApraisals)
            {
                Console.WriteLine("Employee Name        : " + dataClass.EmployeeName);
                Console.WriteLine("Employee Age         : " + dataClass.EmployeeAge);
                Console.WriteLine("Employee Salary      : " + dataClass.EmployeeSalary);
                Console.Write("Employee Appraisals  : ");

                foreach (var item in dataClass.EmployeeApraisals)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
                Console.WriteLine("****************************************************");
            }

            

        }


    }

    class DataClass 
    {
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        private int employeeAge;

        public int EmployeeAge
        {
            get { return employeeAge; }
            set { employeeAge = value; }
        }

        private int employeeSalary;

        public int EmployeeSalary
        {
            get { return employeeSalary; }
            set { employeeSalary = value; }
        }

        private List<int> employeeAppraisals;

        public List<int> EmployeeApraisals
        {
            get { return employeeAppraisals; }
            set { employeeAppraisals = value; }
        }

        public static void SayHi() { }

    }
}
