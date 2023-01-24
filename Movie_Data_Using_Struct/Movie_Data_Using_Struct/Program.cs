using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Data_Using_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies mv= new Movies();
            mv.MovieName = "Kabhi Khushi Kabhi Gham";
            mv.Rate = "9.1 out of 10";
            mv.ReleaseDate = new DateTime(1997, 12, 14);

            mv.Generies = new Generies[4];
            mv.Generies[0] = Generies.Drama;
            mv.Generies[1] = Generies.Romance;
            mv.Generies[2] = Generies.Lovestory;

            mv.Languages = new Languages[3];
            mv.Languages[0] = Languages.English;
            mv.Languages[1] = Languages.Hindi;
            mv.Languages[2] = Languages.Urdu;

            mv.Countries = new Countries[2];
            mv.Countries[0] = Countries.India;
            mv.Countries[1] = Countries.Pakistan;
            mv.display();

        }
    }

    struct Movies
    {
        private string movieName;
        private string rate;
        private DateTime releaseDate;
        private Generies[] generies;
        private Languages[] languages;
        private Countries[] countries;

        

        public string MovieName { 
            get { return movieName; }
            set { movieName = value; }
        }
        public string Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public Generies[] Generies
        {
            get { return generies; }
            set { generies = value; }
        }
        public Languages[] Languages
        {
            get { return languages; }
            set { languages = value; }
        }
        public Countries[] Countries
        {
            get { return countries; }
            set { countries = value; }
        }

        public void display() 
        {
            Console.WriteLine("< Here you can see the Movie Details : >");
            Console.WriteLine("");
            Console.WriteLine($"Movies        : {MovieName}\nRate          : {Rate}\nReleased on   : {releaseDate}");

            Console.Write("Languages     : ");
            for (int i = 0; i < Languages.Length; i++)
            {
                Console.Write(Languages[i]);
                if (i < Languages.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
            Console.Write("Countries     : ");
            for (int i = 0; i < Countries.Length; i++)
            {
                Console.Write(Countries[i]);
                if (i < Countries.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
            Console.Write("Generies      : ");
            for (int i = 0; i < Generies.Length; i++)
            {
                Console.Write(Generies[i]);
                if (i < Generies.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }

        }



    }
    enum Generies 
    {
        Comedy,
        Drama, 
        Thriller,
        Romance,
        Lovestory,
        Mystery,
        Scifi,
    }

    enum Languages 
    {
        English,
        Arabic,
        Hindi,
        Urdu,
        Turkey,
    }

    enum Countries 
    {
        Pakistan,
        Europe,
        Australia,
        Canada,
        England,
        Spain,
        India,
        China
    }
}
