using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string nom;
            double C, F;
            
            Console.WriteLine("What is your name?");
            nom = Console.ReadLine();
            Console.WriteLine("Welcome " + nom + "!");
            
            Nb1:
            Console.WriteLine("What is the temperature you are looking for?");
            try
            {
                C = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex1)
            {

                Console.WriteLine("Your temperature must be a number.");
                goto Nb1;

            }
            
            F = C * (9 / 5) + 32;
            Console.WriteLine("Your temperature is: " + F + ".");

            Console.ReadKey();
        }
    }
}
