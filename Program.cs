using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tydz04praca02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            while (true)
            {
                Console.WriteLine("\nPodaj proszę liczbę całkowitą:");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("\nPodałeś niepoprawne dane. Spóbuj jeszcze raz.");
                    continue;
                }
                else
                { 
                    liczba = number;
                    break;
                }
            }

            if (liczba % 2 == 0)
                Console.WriteLine("Podana liczba jest liczbą parzystą.");
            else
                Console.WriteLine("Podana liczba jest liczbą nieparzystą.");

            Console.ReadLine();
        }
    }
}
