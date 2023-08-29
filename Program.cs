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
            int evenOrNot;
            string continueOrNot;
            char character;
            while (true)
            {
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
                        evenOrNot = number;
                        break;
                    }
                }

                if (evenOrNot % 2 == 0)
                    Console.WriteLine("\nPodana liczba jest liczbą parzystą.");
                else
                    Console.WriteLine("\nPodana liczba jest liczbą nieparzystą.");

                Console.WriteLine("\nCzy chcesz podać kolejną liczbę? [Wybierz T/t dla TAK, lub N/n dla NIE.]");
                while (true)
                {
                    

                    if (string.IsNullOrWhiteSpace(continueOrNot = Console.ReadLine()))
                    {
                        Console.WriteLine("\nPodałeś niepoprawne dane. Proszę wybierz T/t dla TAK, lub N/n dla NIE.");
                        continue;
                    }
                    character = (char)continueOrNot[0];
                    if (character != 't' && character != 'T' && character != 'n' && character != 'N')
                    {
                        Console.WriteLine("\nPodałeś niepoprawne dane. Proszę wybierz T/t dla TAK, lub N/n dla NIE.");
                        continue;
                    }
                    else
                        break;
                }
                if (character == 't' || character == 'T')
                    continue;
                else
                    break;
                             
            }
            Console.ReadLine();

        }
    }
}
