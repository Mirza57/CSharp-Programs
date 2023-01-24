using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Assignment_08_DogInfo_Program
{
    class Animal
    {
       private string name;
       private DateTime date;
       private Origin originD;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Date 
        {
            get { return date; }
            set { date = value;}
        }
        public Origin OriginD
        {
            get { return originD; }
            set { originD = value; }
        }

    }
    class GermanShepherd : Animal,Dog
    {
       private string gender;
       private double weight;
       private string securityGuard;
       private string size;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string SecurityGuard
        {
            get { return securityGuard; }
            set { securityGuard = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public void Eat() 
        {
            Console.WriteLine($"{Name} is eating its meal");
        }
        public void Drink() 
        {
            Console.WriteLine($"{Name} is drinkig some fresh juices");
        }
        public void Sit() 
        {
        }
        public void SayHi() 
        {
            Console.WriteLine($" {Name} wanna say Hi to everyone !!");
        }

        public void Display(string name) {

            Console.WriteLine($"{name} is a {gender} and weights:{weight}Kilos and its size is {size}");
        }
        public void Display() {
            Console.WriteLine($"The Dog name is {Name} from {Origin.Germay}, was born on {Date}");
        }

    }
    enum Origin
    {
        Germay,
        Australia,
        Canada,
        USA,
        Denmark,
        Europe
    }

    interface Dog 
    {
        void Eat();
        void Drink();
        void Sit();
        void SayHi();

    }
}
