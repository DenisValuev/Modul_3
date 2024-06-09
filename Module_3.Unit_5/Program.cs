namespace Module_3.Unit_5
{
    internal class Program
    {
        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        static void Main(string[] args)
        {
            const byte Monday = 1;
            const byte Tuesday = 2;
            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine(MyFavoriteDay);
        }
    }
}
