namespace three
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(a++);
                }
                Console.WriteLine("");
            }
        }
    }
}