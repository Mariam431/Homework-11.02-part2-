namespace _59_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-digit number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int unit = a % 10;
            int tens = (a / 10) % 10;
            int hundreds = a / 100;

            int[] digits = new int[] { unit, tens, hundreds };
            Array.Sort(digits);
            Console.WriteLine(100 * digits[0] + 10 * digits[1] + digits[2]);
        }
    }
}