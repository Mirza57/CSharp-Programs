using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Remove_UsingListTuples__Assignment_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string, int>> playersInformation = new List<Tuple<int, string, int>>();

            AddPlayer(Tuple.Create(27,"Ronaldo",500),ref playersInformation);
            AddPlayer(Tuple.Create(37, "Neymar", 300), ref playersInformation);
            AddPlayer(Tuple.Create(14, "Messi", 900), ref playersInformation);

            Console.WriteLine("Showing Available List");
            Console.WriteLine();
            foreach (var player in playersInformation)
            {
                Console.WriteLine(player.Item1);
                Console.WriteLine(player.Item2);
                Console.WriteLine(player.Item3);

                Console.WriteLine("------------------");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Insertion");
            Console.WriteLine();
            AddPlayer(Tuple.Create(46, "Mirza Arslan", 200), ref playersInformation, 3);
            foreach (var player in playersInformation)
            {
                Console.WriteLine(player.Item1);
                Console.WriteLine(player.Item2);
                Console.WriteLine(player.Item3);

                Console.WriteLine("------------------");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Remove Operation");
            Console.WriteLine();
            RemovePlayer(2, ref playersInformation);
            foreach (var player in playersInformation)
            {
                Console.WriteLine(player.Item1);
                Console.WriteLine(player.Item2);
                Console.WriteLine(player.Item3);

                Console.WriteLine("------------------");

            }

        }

        public static void AddPlayer(Tuple<int, string, int>player ,ref List<Tuple<int, string, int>> list) 
        {
            list.Add(player);
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list, int index)
        {
            list.Insert(index, player);
        }

        public static void RemovePlayer(int index, ref List<Tuple<int, string, int>> list)
        {
            list.RemoveAt(index);
        }
    }
}
