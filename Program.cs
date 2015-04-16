using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview
{
    class Program
    {
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

        static void Main(string[] args)
        {
            Program pr = new Program();
            string word = "jkaime";
            bool b = pr.hasAllUniqueCharacters(word);
            Console.WriteLine("hasAllUniqueCharacters:      " + b);
        }
    }
}
