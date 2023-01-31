using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList_MovieInfo_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie<double,DateTime>> firstList = new List<Movie<double,DateTime>>();
            List<Movie<float, int>> SecondList = new List<Movie<float, int>>();

            Movie<double,DateTime> movie_1= new Movie<double,DateTime>();
            movie_1.MovieName = "Kabhi Khushi Kabhi Gham";
            movie_1.DirectorName = "Mirza Arslan";
            movie_1.MovieRate = 9.5;
            movie_1.ReleaseDate = new DateTime(2000, 12, 8);
            movie_1.Generes = new List<Generes>();
            movie_1.Generes.Add(Generes.Action);
            movie_1.Generes.Add(Generes.Adventure);
            movie_1.Generes.Add(Generes.Biography);
            movie_1.Generes.Add(Generes.Drama);


            Movie<float, int> movie_2 = new Movie<float, int>();
            movie_2.MovieName = "Need for Speed - x ";
            movie_2.DirectorName = "Mirza Faiq";
            movie_2.MovieRate = 8.7;
            movie_2.ReleaseDate = new DateTime(2005,12, 7);
            movie_2.Generes = new List<Generes>();
            movie_2.Generes.Add(Generes.Action);
            movie_2.Generes.Add(Generes.Fantasy);
            movie_2.Generes.Add(Generes.Sport);
            movie_2.Generes.Add(Generes.Thriller);

            firstList.Add(movie_1);
            SecondList.Add(movie_2);

            
            ShowDetails(firstList);
            ShowDetails(SecondList);
        }

        public static void ShowDetails<T, U>(List<Movie<T, U>> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Movie Name               : "+item.MovieName);
                Console.WriteLine("Director Name            : "+item.DirectorName);
                Console.WriteLine("Movie Rating out of 10   : "+item.MovieRate);
                Console.WriteLine("Movie Release Date       : "+item.ReleaseDate);
                

                if (!(item.Generes == null))
                {
                    if (item.Generes.Count > 0)
                    {
                        Console.Write("Generes                  : ");
                        foreach (var generes in item.Generes)
                        {
                            Console.Write(generes + ", ");
                        }
                    }

                }
                Console.WriteLine("\n ------------------------------------- \n");
            }

        }
    }

    class Movie<T,U> 
    {
        private string movieName;
        private double movieRate;
        private DateTime releaseDate;
        private string directorName;
        private List<Generes> generes;

       

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }
        public double MovieRate
        {
            get { return movieRate; }
            set { movieRate = value; }
        }
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public string DirectorName
        {
            get { return directorName; }
            set { directorName = value; }
        }
        public List<Generes> Generes
        {
            get { return generes; }
            set { generes = value; }
        }

    }

    enum Generes
    {
        Action,
        Adventure,
        Animation,
        Biography,
        Comedy,
        Crime,
        Documentary,
        Drama,
        Family,
        Fantasy,
        History,
        Horror,
        Musical,
        Mystery,
        Romance,
        SciFi,
        Sport,
        Thriller,
        War,
        Western

    }
}
