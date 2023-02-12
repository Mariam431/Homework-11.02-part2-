namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-digit number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int unit = a % 10;
            int tens = (a / 10) % 10;
            int hundreds = (a / 100);
            bool t = (unit == tens) || (tens == hundreds) || (hundreds == unit);
            Console.WriteLine(t);
        }
    }
}