using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals giraffe = new Animals();
            giraffe.Name = "Giraffe";
            Animals lion    = new Animals();
            lion.Name = "Lion"; 
            Animals tiger   = new Animals();
            tiger.Name = "Tiger";

            Trainers mirza  = new Trainers();
            mirza.TrainerName = "Mirza Arslan";

            ArrayList al = new ArrayList();
            al.Add(giraffe);
            al.Add(lion);
            al.Add(tiger);

            al.Add(mirza);

            foreach (var item in al)
            {
                // for getting two different methods of two different instances

                if (typeof(Animals) == item.GetType())
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                    Console.WriteLine();
                }
                else 
                {
                    ((Trainers)item).SayHi();
                }
            }
        }
    }

    #region Struct 01

    struct Animals 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi() 
        {
            Console.WriteLine("Hi my name is : "+name);
        }
        public void Feed() 
        {
            Console.WriteLine(name + " is eating");

        }

    }
    #endregion

    #region Struct 02
    struct Trainers 
    {
        private string trainerName;

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }
        public void SayHi() 
        {
            Console.WriteLine("Hi from trainer : " + trainerName);
        }

    }
    #endregion
}
