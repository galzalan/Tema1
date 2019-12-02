using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int rannr = rng.Next(0,100);

            Console.Write("Please enter a number:");
            string input = Console.ReadLine();
            int x = int.Parse(input);

            while(x != rannr)
            {
                if (rannr > x)
                {
                    Console.Write("The number entered is smaller then the one generated. Please try again:");
                    input = Console.ReadLine();
                    x = int.Parse(input);
                }
                else if(rannr < x)
                {
                    Console.Write("The number entered is bigger then the one generated. Please try again:");
                    input = Console.ReadLine();
                    x = int.Parse(input);
                }
            }

            Console.WriteLine("Congratulation the number generated was {0}",input);

        }
    }
}
