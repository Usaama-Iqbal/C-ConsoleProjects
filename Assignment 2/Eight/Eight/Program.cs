namespace eight
{
    class program
    {
        static void Main(string[] args)
        {
            short year;
            Console.WriteLine("Please enter a year");
            year = Convert.ToInt16(Console.ReadLine());

            if((year % 4== 0) || ((year % 400==0) && (year %100 ==0)))
            {
                Console.WriteLine("It is leap year=" + year);
            }
            else
            {
                Console.WriteLine("It is Not leap year=" + year);
            }
        }
    }
}