namespace two
{
    class factorial
    {
        public static void fact(int num)
        {
            int f = 1;
            while (num > 1)
            {
                f = f * num;
                num--;
            }
            Console.WriteLine("The factorial of number is :" + f);

        }
    }
        class program
    {
        static void Main(string[] args )
        {
            Console.WriteLine("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
           

            factorial.fact(number);    

        }
    }
}