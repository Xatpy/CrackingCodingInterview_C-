using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    static class Auxiliar
    {
        public static void printArray(int[,] origArray)
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < origArray.GetLength(0); ++i)
            {
                Console.Write("(");
                for (int j = 0; j < origArray.GetLength(1); ++j)
                {                    
                    Console.Write(String.Format("{0,3}", origArray[i, j].ToString()));
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("--------------");
        }

        public static void printArray(int?[,] origArray)
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < origArray.GetLength(0); ++i)
            {
                Console.Write("(");
                for (int j = 0; j < origArray.GetLength(1); ++j)
                {
                    Console.Write(String.Format("{0,3}", origArray[i, j].ToString()));
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("--------------");
        }

        public static void printListNode(Node nd)
        {
            while (nd != null) 
            { 
                Console.Write(nd.Data + " --> ");
                nd = nd.Next;
            }
            Console.Write(" :NULL ");
            Console.WriteLine("");
        }
    }
}
