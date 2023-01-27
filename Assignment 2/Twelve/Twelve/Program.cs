namespace twelve
{
    class program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5 ;
            float perc, obt;
            int total = 500;
            
            Console.WriteLine("Enter marks of five subject=");
            Console.WriteLine("Enter first subject marks=");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd subject marks=");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd sunject marks=");
            sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 4th subject marks=");
            sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 5th subject marks=");
            sub5 = Convert.ToInt32(Console.ReadLine());
            obt = sub1 + sub2 + sub3 + sub4 + sub5;

            perc  = Convert.ToSingle(((obt) / total) * 100);

            if (perc >= 60)
            {
                Console.WriteLine("1st division");
            }
            else if ((perc >= 50) && (perc <= 59))
            {
                Console.WriteLine("Second division");
            }
            else if ((perc >= 40) && (perc <= 49))
            {
                Console.WriteLine("Third division");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}