using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_Task_Using_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = Enum.GetNames(typeof(Languages)).Length;
            string language;

            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Console.WriteLine(language);

                Directory.CreateDirectory(@"F:\C#Projects\Language");
                Directory.CreateDirectory(@"F:\C#Projects\Language\"+ language);
                StreamWriter sw = new StreamWriter("F:\\C#Projects\\Language\\"+language+ "\\log.txt");
                sw.WriteLine("File no " + i +"created on "+ DateTime.Now);
                sw.Close();
            }
        }
    }

    enum Languages
    {
        English,
        Urdu,
        Sindhi,
        Punjabi,
        Balochi,
        Pakhtuni,
        Italian,
        French,
        German
    }
}
