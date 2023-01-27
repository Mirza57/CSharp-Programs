using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plainText = "Mr Z";
            Console.WriteLine("Plain Text = " + plainText);

            char[] cipher = New_Work.Encrypt(plainText, 3);

            Console.WriteLine("Cipher Text is :");
            foreach (char c in cipher)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(c);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();


            // Now I am going to make Decrypt data

            string cipherText = "pu c";
            Console.WriteLine("Cipher Text = " + cipherText);
            char[] plain = New_Work.Decrypt(cipherText, 3);
            Console.WriteLine("Plain Text is ");
            foreach (var item in plain)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();



        }
    }

    class New_Work
    {
        #region Encryption Work
        public static char[] Encrypt(string plainText, int shift)
        {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);

                    }

                }
                cipherArray[i] = letter;

            }
            return cipherArray;

        }
        #endregion

        #region Decryption Work
        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherArray.Length];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);

                    }

                }
                plainArray[i] = letter;

            }
            return plainArray;

        }
        #endregion

    }
}


