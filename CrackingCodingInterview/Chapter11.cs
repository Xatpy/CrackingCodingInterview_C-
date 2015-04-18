using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    class Chapter11
    {
        /**
         * Exercise 11.1
         * Find the mistake(s) in the following code
         */
        public void findMistake()
        {
            /*The problem is with the finish conditional sign.
             Also, as we're using unsigned integer, we have to use an STRICT > (not >= 0)
             */
             
            bool corrected = true;
            if (!corrected)
            {
                //Original code
                uint i;
                for (i = 100; i <= 0; --i)
                {
                    //printf("%d\n", i);
                    Console.WriteLine(i);
                }
            }
            else
            {
                //Corrected:
                for (uint i = 100; i > 0; --i)
                {
                    Console.WriteLine(i);
                }
            }
        } 
        
        /*
         * Exercise 11.2 :
         * You are given the source to an application which crashes when it is run After running 
         * it ten times in a debugger, you find it never crashes in the same place The application 
         * is single threaded, and uses only the C standard library What programming errors 
         * could be causing this crash? How would you test each one?
         */
        private void debuggingProgram()
        {
            /* Response:
             *      - Leaks
             *      - Input
             */                        
        }

        /*
         * Exercise 11.3 :
         * We have the following method used in a chess game: boolean canMoveTo(int x, int y) 
         * x and y are the coordinates of the chess board and it returns whether or not the piece 
         * can move to that position Explain how you would test this method
         */
        public bool test_canMoveTo(int x, int y)
        {
            // Checking board dimensions
            if ((x < 0) || (x > 8))
                return false;
            if ((y < 0) || (y > 8))
                return false;

            // Also, we'd have to test if it's a correct movement depending on kind of piece.
            // Example: Towers only move horizontally or vertically.

            return true;
        }

        /*
         * Exercise 11.4 :
         * How would you load test a webpage without using any test tools?
         */
        private void test_webpage()
        {
            // Smoke tests: 'More basics' tests to check the basic web-page funcionts.
            // So, I'd create a smoke tests spreadsheet and I'll check it
        }

        /*
         * Exercise 11.5 :
         * How would you test a pen?
         */
        private void test_pen()
        {
            /*
             * - Writing: words, pictures.
             * - The ink is inside, and there's no hole.
             * - The cover fits.
             * - The ink is correctly printed (without spots).
             */
        }

        private void test_ATMDistributedBankingSystem()
        {
            /*
             * - Get money:
             *      # Notes: From minimum (5€) to maximum (500€).
             *      # User limits: Example (600 € per day).
             *      # Get money from several machines AT THE SAME TIME (another person is required).
             *      # Push buttons hard.
             *      # Exceed time limits.
             *      # Insert several object (instead of the card)
             *      # Remove electricity.
             */
        }


    }
}
