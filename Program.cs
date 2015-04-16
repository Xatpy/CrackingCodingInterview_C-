using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview
{
    class Chapter1
    {
        /* Exercise 1.1:
         * Implement an algorithm to determine if a string has all unique characters What if you 
           can not use additional data structures?
         */
        bool hasAllUniqueCharacters(string str)
        {
            char?[] aux = new char?[str.Length];

            for (int i = 0; i < aux.Length; ++i)
            {
                aux[i] = null;
            }

            for (int i = 0; i < str.Length; ++i)
            {
                //Go through aux array
                for (int j = 0; j < aux.Length; j++)
                {
                    if (aux[j] == null)
                    {
                        aux[j] = str[i];
                        break;
                    }
                    else
                    {
                        //Check if we have that char
                        if (aux[j] == str[i])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        /**
         * Exercise 1.2:
         * Write code to reverse a C-Style String (C-String means that “abcd” is represented as 
         * five characters, including the null character )
         */
        string reverse(string str)
        {
            string str_rever = "";
            for (int i = str.Length - 1; i >= 0; --i)
            {
                str_rever += str[i];
            }
            return str_rever;
        }

        static void Main(string[] args)
        {
            Chapter1 ch_1 = new Chapter1();
            string word = "holaaaaaa";

            int exercise = 2;

            switch (exercise)
            {
                case 1:
                    bool b = ch_1.hasAllUniqueCharacters(word);
                    Console.WriteLine("hasAllUniqueCharacters:      " + b);
                    break;
                case 2:
                    Console.WriteLine(ch_1.reverse(word));
                    break;
            }           
        }
    }
}
