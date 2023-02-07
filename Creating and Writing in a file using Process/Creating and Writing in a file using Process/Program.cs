using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Creating_and_Writing_in_a_file_using_Process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"F:\\C#Projects\notepadeExerciceUsingProcess.txt","I am writing this dummy text using Process");
            System.Diagnostics.Process.Start(@"F:\\C#Projects\notepadeExerciceUsingProcess.txt");
        }
    }
}
