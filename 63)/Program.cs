namespace _63_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 4 digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int unit = num % 10;
            int tens = (num / 10) % 10;
            int hundreds = (num / 100) % 10;
            int thousands = num / 1000;
            if((unit == 1) || (tens == 1)|| (hundreds == 1) || (thousands == 1))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}