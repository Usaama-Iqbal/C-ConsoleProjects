namespace nine
{
    class program
    {
        static void Main(string[] args)
        {
            int num, a, b, c, d;
            Console.WriteLine("Enter Four Digit Number=");
            num = Convert.ToInt32(Console.ReadLine());
            d = num % 10;
            c = (num / 10) % 10;
            b = (num / 100) % 10;
            a = (num / 1000) % 10;
            Console.WriteLine("Sum Of First and Last Digit Is=" + (a + d), num);
        }
    }
}
