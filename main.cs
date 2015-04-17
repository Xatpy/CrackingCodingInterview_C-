using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview
{
    class main
    {
        static void chapt_1()
        {
            Chapter1 ch_1 = new Chapter1();
            int exercise = 7;

            switch (exercise)
            {
                case 1:
                {
                    string word = "holaaaaaa";
                    bool b = ch_1.hasAllUniqueCharacters(word);
                    Console.WriteLine("hasAllUniqueCharacters:      " + b);
                    break;
                }
                case 2:
                {
                    string word = "holaaaaaa";
                    Console.WriteLine(ch_1.reverse(word));
                    break;
                }
                case 3:
                    break;
                case 4:
                    string w1 = "abcd";
                    string w2 = "dcba";
                    Console.WriteLine("anagrams: " + ch_1.areAnagrams(w1, w2));
                    break;
                case 5:
                    string with_spaces = "fas ñasdf fff   asdf";
                    Console.WriteLine(ch_1.replaceSpaces(with_spaces));
                    break;
                case 6:
                    {
                        int[,] arr = new int[,] { { 0, 1, 2, 3}, 
                                                { 4, 5, 6, 7},
                                                { 8, 9,10,11},
                                                {12,13,14,15}  };
                        int?[,] rotated = ch_1.rotateImage(arr);
                    }
                    break;
                case 7:
                    {
                        int[,] arr = new int[,] {  { 66, 10, 2, 3, 25, 50}, 
                                                { 4,  5, 6, 7,  0, 10},
                                                { 8, 40,10,11,  3, 80} };
                        ch_1.settingToZero(ref arr);
                    }
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("::::::::::::::: Cracking the Coding Interview :::::::::::::::"); 
            Console.WriteLine();
            int chapter = 1;

            switch (chapter)
            {
                case 1:
                    chapt_1();
                break;
            }

            Console.WriteLine("Press ENTER to finish...");
            Console.ReadLine();
        }
    }

     
}
