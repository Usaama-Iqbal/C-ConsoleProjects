namespace five
{
    class program
    {
        static void Main(string[] args)
        {
            int  workhour, overtime, overtimep;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter the working hour of the employee : ");
                workhour = Convert.ToInt32(Console.ReadLine());

                if (workhour > 40)
                {
                    overtime = workhour - 40;
                    overtimep = overtime * 200;
                    Console.WriteLine("The employee overtime pay is : " +overtimep);
                }
                else
                {
                    Console.WriteLine("The employee have to work for more than 40 hours to get overtime pay : ");
                }
            }
            
        }
    }
}