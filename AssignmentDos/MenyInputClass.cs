using AssignmentTwo;

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
                        CostInfo(MenyOutputClass.FixedOutput.Youth, ticketloop);
                        break;
                    }
                    else if (intAge > 64)
                    {
                        CostInfo(MenyOutputClass.FixedOutput.OldAge, ticketloop);
                        break;
                    }
                    else if (intAge > 20 && intAge < 65)
                    {
                        CostInfo(MenyOutputClass.FixedOutput.StandardAge, ticketloop);
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
