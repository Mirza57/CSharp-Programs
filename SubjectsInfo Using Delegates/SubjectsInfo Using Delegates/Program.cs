using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectsInfo_Using_Delegates
{
    /*
     * Below is the delegate which will call the method.
     */
    public delegate void SubjectsInformationByDelegates(Dictionary<string,int> dictionary);
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * This is the declaration of dictionary generic list
             */
            Dictionary<string,int> dicList = new Dictionary<string,int>();
            dicList.Add("Object Oriented OOP", 3);
            dicList.Add("Database Management",3);
            dicList.Add("Operarting  Systems",2);


            /*
             *  Here we are creating an instance of delegate to call the method 
             */
            SubjectsInformationByDelegates subjectInfo = new SubjectsInformationByDelegates(SubjectsDictionary);
            subjectInfo(dicList);    
        }

        public static void SubjectsDictionary(Dictionary<string,int> dictionary) 
        {
           foreach (var info in dictionary) 
           { 
            Console.WriteLine("Subject name: "+info.Key+"\t Subject credit hours: "+info.Value);
            Console.WriteLine();
           }
        }
    }
}
