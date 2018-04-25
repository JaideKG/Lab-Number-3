using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter an integer between 1 and 100.");
            int Anumber;
            Anumber = int.Parse(Console.ReadLine());
            if (Anumber % 2 == 0 && Anumber >= 2 && Anumber <= 25)
            {
                Console.WriteLine("even and less than 25");
            }

            else if (Anumber % 2 != 0)
            {
                Console.WriteLine($"{Anumber} odd");
            }
            else if (Anumber % 2 == 0 && Anumber >= 26 && Anumber <= 60)
            {
                Console.WriteLine($"\neven");
            }
            else if (Anumber % 2 == 0 && Anumber > 60)
            {
                Console.WriteLine($"\neven");
            }
            else if (Anumber % 2 != 0 && Anumber > 60)
            {
                Console.WriteLine($"{Anumber} odd");
                Console.ReadLine();
            }
        }

    }
}
