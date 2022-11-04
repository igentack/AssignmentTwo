namespace AssignmentDos
{   // TODO - DO proper choiceloop 
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = false;
            do
            {
                MenyInputClass.MenyText();
                MenyInputClass.TicketPurchases();

            } while (loop);
        }
    }
}