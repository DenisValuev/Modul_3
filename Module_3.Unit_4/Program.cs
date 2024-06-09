namespace Module_3.Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool HaveIAPet = true;
            double MyShoeSize = 37.5;
            Console.WriteLine("My name is {0}", MyName);
            Console.WriteLine("My age is {0}", MyAge);
            Console.WriteLine("Do i have a pet? {0}", HaveIAPet);
            Console.WriteLine("My shoe size is {0}", MyShoeSize);

            // Минимальное и максимальное значение типа int
            Console.WriteLine("IntMin {0}", int.MinValue);
            Console.WriteLine("IntMax {0}", int.MaxValue);
        }
    }
}
