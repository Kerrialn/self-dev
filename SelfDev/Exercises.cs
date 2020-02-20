using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDev
{
    class Exercises
    {

        public static void IWontCheatOnTheExam()
        {
            for(var i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}: I won't cheat on the exam!");
            }
        }

        public static void DrawPyramid()
        {  
            int num, height, row, space;
            num = 5;
            for (height = 1; height <= num; height++)
            {
                for (row = 1; row < num - height + 1; row++)
                {
                    Console.Write(" ");
                }
                for (space = 1; space <= height; space++)
                {
                    Console.Write(height);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void ChessBoard()
        {
            var star = "+ ";
            var space = " ";
            int index = 1; 
            int counter = 1; 

            while(index <= 8)
            {
                if(index % 2 != 0)
                {
                    while(counter <= 8)
                    {
                        Console.Write(star);
                        counter++;
                    }
                }
                else
                {
                    Console.Write(space);
                    while (counter <= 8)
                    {
                        Console.Write(star);
                        counter++;
                    }
                }
                counter = 1;
                index++;
                Console.WriteLine();
            }
        }

        public static void Loopy()
        {
            int firstLoop = 0, secondLoop = 0, thirdLoop = 0, fouthLoop=0, fifthLoop=0; 
            for (int i = 1; i <= 5; i++)
            {
                firstLoop++;
                for (int j = 1; j <= 5; j++)
                {
                    
                }
            }
            Console.WriteLine("Outer Loop runs {0} times", firstLoop);
            Console.WriteLine("second Loop runs {0} times", secondLoop);
            Console.WriteLine("thrid Loop runs {0} times", thirdLoop);
            Console.WriteLine("fouth Loop runs {0} times", fouthLoop);
        }


    }


}
