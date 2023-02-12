namespace _56_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 3 digit number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double unit = a % 10;
            double tens = (a / 10) % 10;
            double hundreds = a / 100;
            if (a > 300)
            {
                double result = tens / unit;
                Console.WriteLine(result);
            }
            else
            {
                double result = hundreds / unit;
                Console.WriteLine(result);
            }
            
        }
    }
}