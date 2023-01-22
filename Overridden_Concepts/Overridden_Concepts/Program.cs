using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridden_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car_2 car_2= new Car_2();
            car_2.DisplayInfo();
        }
    }
    #region Class 01) Cars - It contain 1 method called DisplayInfo
    class Cars
    {
        private string carPrice;
        protected string carName;
        protected string carColor;

        public string CarPrice {
            get { return carPrice; }
            set { carPrice = value; }
        }

        public virtual void DisplayInfo()
        {

            carPrice = "3,000,000,00";
            carName = "Audi";
            carColor = "Black";

            Console.WriteLine($"The Price is {carPrice} of {carName} whose color is {carColor}");


        }

    }
    #endregion

    #region Class 0) Cars_2 - It contain 1 override method called DisplayInfo
    class Car_2 : Cars
    {
        public override void DisplayInfo()
        {

            base.DisplayInfo();
            CarPrice = "18,000,000,00";
            carName = "Landcruiser";
            carColor = "Dark-Green";

            Console.WriteLine($"The Price is {CarPrice} of {carName} whose color is {carColor}");
        }

    }
    #endregion
}
