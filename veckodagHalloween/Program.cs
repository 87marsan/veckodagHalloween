namespace veckodagHalloween
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HalloweenWeeday();
        }

        static public void HalloweenWeeday()
        {
            var halloween = new DateTime(DateTime.Now.Year, 10, 31).DayOfWeek;
            Console.WriteLine(halloween);
        }
    }
}