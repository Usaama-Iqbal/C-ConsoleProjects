namespace four
{
    class program
    {
        static void Main(string[] args)
        {
            int num, pri = 0;
            Console.Write("Enter any number = ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    pri++;
                }
            }
            if (pri == 2)
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }
        }
    }
}