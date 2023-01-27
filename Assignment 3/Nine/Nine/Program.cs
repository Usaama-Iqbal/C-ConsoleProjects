namespace nine
{
    class program
    {
        static void Main(string[] args)
        {
            int rev = 0, rem;
            Console.WriteLine("Enter five digit number:");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The reverse of five digit number is :" +rev);
        }
    }
}