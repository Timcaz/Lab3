namespace Lab3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(500, "Alex", "TM");
            Console.WriteLine(invoice.CalculateValueOrder());
        }
    }
}