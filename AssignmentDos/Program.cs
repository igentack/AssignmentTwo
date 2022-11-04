using AssignmentTwo;

namespace AssignmentDos
{   // TODO - DO proper choiceloop 
    // using MenyProcessClass;
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = false;
            do
            {
                // TODO - Implement tryParse input function, maybe in Menytext and return int (from) MenyProccessClass?
                
                string menyChoice = MenyInputClass.MenyText();
                // int switchChoice = Int32.Parse(menyChoice); 

                switch (menyChoice)
                {
                    case "0":
                        Console.WriteLine("Fin dag nu!");
                        Environment.Exit(0);
                        break;

                    case "1":
                        MenyInputClass.TicketPurchases();
                        break;

                    case "2":
                        MenyInputClass.PrintFoorLoop();
                        break;

                    default:
                        Console.WriteLine("Somthing went wrong...");
                        break;
                }


                MenyInputClass.TicketPurchases();

            } while (loop);
        }
    }
}