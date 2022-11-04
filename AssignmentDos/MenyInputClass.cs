using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDos
{
    internal class MenyInputClass
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
            // To const
            string youth = "Ungdomspris: 80kr";
            string oldAge = "Pensionärsprisspris: 90kr";
            string standardAge = "Standardpris: 120kr";
            bool ticketloop = true;
            
            do
            {
                Console.WriteLine();
                Console.Write("Skriv in er ålder: ");
                string age = Console.ReadLine();
                Console.WriteLine();
                bool parsedInt = int.TryParse(age, out int intAge);
                if (parsedInt)
                {
                    if (intAge < 20)
                    {
                        CostInfo(youth, ticketloop);
                        break;
                    }
                    else if (intAge > 64)
                    {
                        CostInfo(oldAge, ticketloop);
                        break;
                    }
                    else if (intAge > 20 && intAge < 65)
                    {
                        CostInfo(standardAge, ticketloop);
                        break;
                    }
                }
                else               
                {
                    Console.WriteLine("Prova att skriva in er ålder igen");
                    Console.WriteLine();
                    continue;
                }               
            } while (true);
        }
        public string CostOutput { get; set; }
        public bool LoopBool { get; set; }

        private static void CostInfo(string costOutput, bool loopBool)
        {
            Console.WriteLine($"{costOutput}");
            Console.WriteLine();
            Console.WriteLine(" - Biljett tillagd -");
            loopBool = true;
        } 
    }
}
