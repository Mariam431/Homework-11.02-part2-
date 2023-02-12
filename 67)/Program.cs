namespace _67_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 4 digit number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double unit = num % 10;
            double tens = (num / 10) % 10;
            double hundreds = (num / 100) % 10;
            double thousands = num / 1000;
            double sum = Math.Pow((unit + tens + hundreds + thousands) , 2);
            if (num == sum)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}