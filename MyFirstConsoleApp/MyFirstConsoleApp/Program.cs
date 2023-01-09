using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TryAnIf();
             TrySomeLoops();
             TryAnIfElse();*/
            int h = 124;
            int w = 400;
            int num = Multiply(h, w);
            Console.WriteLine(num);
        }

        private static int Multiply(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }

        /*    private static void  TryAnIf()
            {
                int someValue = 4;
                string name = "Bobbo Jr.";
                if ((someValue == 3) && (name == "Joe"))
                {
                    Console.WriteLine("x is 3 and the name is Joe");
                }
                Console.WriteLine("this line runs no matter what");
            }

            private static void TrySomeLoops()
            {
                int x = 5;
                if (x == 10)
                {
                    Console.WriteLine("x must be 10");
                }
                else
                {
                    Console.WriteLine("x isn't 10");
                }
            }

            private static void TryAnIfElse()
            {
                int count = 0;
                while (count < 10)
                {
                    count++;
                }
                for (int i = 0; i < 5; i++)
                {
                    count--;
                }
                Console.WriteLine("The answer is " + count);
            }*/
    }
}
