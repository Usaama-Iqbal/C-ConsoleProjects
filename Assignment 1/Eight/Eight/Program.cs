namespace example
{
    class program
    {
        static void Main(string[] args)
        {
            int num, a, b, c, d, e;
            Console.WriteLine("Enter Five Digit Number=");
            num = Convert.ToInt32(Console.ReadLine());
            e = num % 10;
            d = (num / 10) % 10;
            c = (num / 100) % 10;
            b = (num / 1000) % 10;
            a = (num / 10000);
            num = e * 10000 + d * 1000 + c * 100 + b * 10 + a;
            Console.WriteLine("The Reverse Of Five Digit=" +num);
        }
    }
}
