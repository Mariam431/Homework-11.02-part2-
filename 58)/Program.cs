namespace _58_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 3-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int unit = num % 10;
            int tens = (num / 10) % 10;
            int hundreds = num / 100;

            if(tens + hundreds < 5)
            {
                char f = 'a';
                Console.WriteLine(f);
            }
            else
            {
                char f = 'b';
                Console.WriteLine(f);
            }


        }
    }
}