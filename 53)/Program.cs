namespace _53_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a three-digit number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double unit = a % 10;
            double tens = (a / 10) % 10;
            double hundreds = (a / 100);

            if (a > k)
            {
                double result = (unit + tens + hundreds) / a;
                Console.WriteLine(result);
            }
            else
            {
                double result = unit / a;
                Console.WriteLine(result);
            }
        }
    }
}