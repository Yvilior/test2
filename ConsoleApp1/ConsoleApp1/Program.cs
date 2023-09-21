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
            //Declaration des variables
            string nom;
            double C, F;
            //Demander nom
            Console.WriteLine("Quel est votre nom?");
            nom = Console.ReadLine();
            Console.WriteLine("Bienvenue " + nom + "!");
            //Demander la temperature
            Nb1:
            Console.WriteLine("Quel est la temperature que vous recherchez?");
            try
            {
                C = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex1)
            {

                Console.WriteLine("Votre temperature doit etre un nombre");
                goto Nb1;

            }
            //Convertion de la temperature
            F = C * (9 / 5) + 32;
            Console.WriteLine("Votre temperature en Fahrenheit est: " + F + ".");

            Console.ReadKey();
        }
    }
}
