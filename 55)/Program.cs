namespace _55_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Entr a three-digit number; ");
            a = Convert.ToInt32(Console.ReadLine());

            int unit = a % 10;
            int tens = (a / 10) % 10;
            int hundreds = (a / 100);
            int smallest = unit;
            if (tens > unit)
            {
                smallest = tens;
            }
            if (hundreds > smallest)
            {
                smallest = hundreds;
            }
            Console.WriteLine("The smallest digit is " + smallest);
        }
    }
}