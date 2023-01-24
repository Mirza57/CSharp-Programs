using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_08_DogInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GermanShepherd gm= new GermanShepherd();
            gm.Name = "Jack";
            gm.Gender = "Male";
            gm.Weight = 43.2333;
            gm.Size = "Large";
            gm.Date = new DateTime(2020, 7, 12); // year month date

            gm.SayHi();
           
            gm.Display();
            gm.Display(gm.Name);

            gm.Eat();
            gm.Drink();
        }
    }
}
