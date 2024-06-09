namespace Module_3.Unit_8
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            int olddata = 6;
            string data = olddata.ToString();
            Console.WriteLine(data);
            Console.WriteLine(olddata);

            //Console.Write("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is {0}", age);

            //Console.Write("Enter your age:");
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your age is {0}", age);

            //Console.Write("Enter your age:");
            //bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine("Your age is {0}", age);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("What is your favorite day of week? ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

        }
    }
}
