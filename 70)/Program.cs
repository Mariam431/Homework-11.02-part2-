namespace _70_
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
            int y = 1;
            if((unit*tens*hundreds*thousands) > 200)
            {
                y = 0;
            }
            Console.WriteLine(y);
        }
    }
}