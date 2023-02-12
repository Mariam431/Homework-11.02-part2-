namespace _54_
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
            int greatest = unit;
            if(tens > unit)
            {
                greatest = tens;
            }
            if(hundreds > greatest)
            {
                greatest = hundreds;
            }
            Console.WriteLine("The greatest digit is " + greatest);

        }
    }
}