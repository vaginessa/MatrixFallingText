using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAnimation
{
    class Program
    {
        static Random _random = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           
            Console.WriteLine("Hello, world!");

            while (true) {
                int times = _random.Next(20, 30);
                int space = _random.Next(0, 5);
                string s = "";
                string temp = " ";
                for(int j = 0; j < times; j++) { 
                for(int i = 0; i < space; i++)
                {
                    temp += temp;
                }
                    s += GetLetter() + temp;
                    temp = " ";
                }

           
            Console.WriteLine(s);
                System.Threading.Thread.Sleep(50);
            }

           
        }

        public static char GetLetter()
        {
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);

            return let;
        }
    }
}
