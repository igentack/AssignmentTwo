using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDos
{
    internal class HelpClassForAssignment2
    {
        public static void MenyText()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("  Välkommen till Biomenyn  ");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("1: Boka en biljett");
            Console.WriteLine("2: Se aktuellt saldo");
            Console.WriteLine("0: Avsluta");
            Console.WriteLine();
            Console.Write("Skriv ert val: ");
            Console.ReadLine();
        }

        public static void TicketPurchases()
        {
            Console.WriteLine();
            Console.Write("Skriv in er ålder: ");
            Console.WriteLine();
            string age = Console.ReadLine();
            bool biljettloop = true;
            while (biljettloop)
            {
                if (int.TryParse(age, out int intAge))
                {
                    if (intAge < 20)
                    {
                        Console.WriteLine("Ungdomspris: 80kr");
                        Console.WriteLine("     . . .");
                        Console.WriteLine("Biljett tillagd");
                        biljettloop = true;
                        break;
                    }
                    else if (intAge > 64)
                    {
                        Console.WriteLine("Pensionärspris: 90kr");
                        Console.WriteLine("     . . .");
                        Console.WriteLine("Biljett tillagd");
                        biljettloop = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Standardpris: 120kr");
                        Console.WriteLine("     . . .");
                        Console.WriteLine("Biljett tillagd");
                        biljettloop = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Prova att skriva in er ålder igen...");
                    continue;
                }
            }
        }
    }
}
