namespace Module_3.Unit_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            result = 5 % 2;
            Console.WriteLine("5 % 2 = {0}", result);
            int counter = 10;
            Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);
        }
    }
}
