namespace practise
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter worker basic salary=");
            int bs = Convert.ToInt32(Console.ReadLine());
            int da, hra, gs;
            da = (int)(bs * (0.4));
            hra = (int)(bs * (0.2));
            gs = bs + da + hra;
            Console.WriteLine("Basic Salary=" + bs);
            Console.WriteLine("Dearness Allowance=" + da);
            Console.WriteLine("House Rent Allowance=" + hra);
            Console.WriteLine("Gross Salary=" + gs);


        }
    }
}
