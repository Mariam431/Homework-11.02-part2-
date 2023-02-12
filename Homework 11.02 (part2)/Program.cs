namespace Homework_11._02__part2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a three-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int unit = num % 10;
            int tens = (num / 10) % 10;
            int hundreds = num / 100;

            bool T = unit == tens + hundreds;

            Console.WriteLine("The boolean value is: " + T);
        }
    }
}