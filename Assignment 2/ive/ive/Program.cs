namespace five
{
    class program
    {
        static void Main(string[] args)
        {
            short year;
            Console.WriteLine("Please enter a year=");
            year = Convert.ToInt16(Console.ReadLine());

            if (year % 100 ==0)
            {
                if (year % 400 ==0)
                {
                    Console.WriteLine("It is leap year=");
                }
                else
                {
                    Console.WriteLine("It is not leap year=");
                }
            }
            else
            {
                if (year % 4== 0)
                {
                    Console.WriteLine("It is a leap year=");
                }
                else
                {
                    Console.WriteLine("It is not leap year=");
                }
            }
        }
    }
}