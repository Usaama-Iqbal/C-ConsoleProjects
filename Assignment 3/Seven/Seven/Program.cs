namespace seven
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Prime number from 1 to 300:");
            Console.WriteLine("The 0 & 1 are not prime number:");
            int max = 300, k;

            for (int i = 1; i <= max ; i++)
            {
                k = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        k = 1;
                        break;
                    }
                }
                if (k == 0 & i != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}