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

        /**
         * Exercise 1.4 :  
         * Write a method to decide if two strings are anagrams or not.
         */
        bool areAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int length = str1.Length; // == str2.Length
            for (int i = 0; i <= (length / 2); ++i)
            {
                //Check 'anagrism'
                if (str1[i] != str2[((length - 1) - i)])
                {
                    return false; //Found!
                }
            }
            
            return true;
        }

        /*
         * Exercise 1.5 :
         * Write a method to replace all spaces in a string with ‘%20’
         */
        string replaceSpaces(string str)
        {
            return str.Replace(" ", "%20");
        }

        /*
         * Exercise 1.6 :
         * Given an image represented by an NxN matrix, where each pixel in the image is 4 
         * bytes, write a method to rotate the image by 90 degrees Can you do this in place?
         */
        int?[,] rotateImage(int[,] origArray)
        {
            //Check dimensions
            int dimension = origArray.GetLength(0);
            if (dimension != origArray.GetLength(1))
                return null;

            Auxiliar.printArray(origArray);

            int?[,] ret = new int?[dimension, dimension];            

            for (int i = 0; i < dimension; ++i)
            {
                for (int j = 0; j < dimension; ++j)
                {
                    ret[j, dimension - 1 - i] = origArray[i, j];
                }
            }

            Auxiliar.printArray(ret);

            return ret;
        }

        /*
         * Exercise 1.7:
         * Write an algorithm such that if an element in an MxN matrix is 0, its entire row and 
         * column is set to 0.
         */
        void settingToZero(ref int[,] array)
        {
            Console.WriteLine("Before:");
            Auxiliar.printArray(array);

            //looking for zeros
            List<coincidence> listCoinc = new List<coincidence>();
            for (int i = 0; i < array.GetLength(0); ++i) {
                for (int j = 0; j < array.GetLength(1); ++j) {
                    if (array[i, j] == 0)
                    {
                        coincidence co = new coincidence(i,j);
                        listCoinc.Add(co);
                    }
                }
            }

            //Setting to 0
            foreach (coincidence coin in listCoinc) {                                
                for (int i = 0; i < array.GetLength(0); ++i)
                {
                    array[i, coin.j] = 0;
                }

                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    array[coin.i, j] = 0;
                }
            }

            Console.WriteLine("After:");
            Auxiliar.printArray(array);
        }

        //Check array
        public struct coincidence
        {
            public int i;
            public int j;

            public coincidence(int par_i, int par_j)
            {
                i = par_i;
                j = par_j;
            }
        }   

        /*
         * --- MAIN ---
         */
        static void Main(string[] args)
        {
            Chapter1 ch_1 = new Chapter1();
            string word = "holaaaaaa";

            int exercise = 7;

            switch (exercise)
            {
                case 1:
                    bool b = ch_1.hasAllUniqueCharacters(word);
                    Console.WriteLine("hasAllUniqueCharacters:      " + b);
                    break;
                case 2:
                    Console.WriteLine(ch_1.reverse(word));
                break;
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
                                                {12,13,14,15}  } ;                        
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
    }
}
