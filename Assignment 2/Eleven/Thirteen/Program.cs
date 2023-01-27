namespace eleven
{
    class program
    {
        static void Main(string[] args)
        {
            char gen, Qual;
            int salary;
            byte yos;

            Console.WriteLine("Enter your Gender Please");
            Console.WriteLine("Enter M for Male & F or Female");
            gen = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter your Year of Service = ");
            yos = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter your Qualification Please=");
            Console.WriteLine("Enter P for Post-Graduate and G for Graduate");
            Qual = Convert.ToChar(Console.ReadLine());

            if (gen == 'M')
            {
                if (yos >= 10)
                {
                    if (Qual == 'P')
                    {
                        salary = 15000;
                    }
                    else
                    {
                        salary = 10000;
                    }
                    Console.WriteLine("Your Salary is = " + salary);
                }
                else
                {
                    if (Qual == 'P')
                    {
                        salary = 10000;
                    }
                    else
                    {
                        salary = 7000;
                    }

                    Console.WriteLine("Your Salary is = " + salary);
                }
            }
            else
            {
                if (yos >= 10)
                {
                    if (Qual == 'P')
                    {
                        salary = 12000;
                    }
                    else
                    {
                        salary = 9000;
                    }
                    Console.WriteLine("Your Salary is = " + salary);
                }
                else
                {
                    if (Qual == 'P')
                    {
                        salary = 10000;
                    }
                    else
                    {
                        salary = 6000;
                    }
                }
                Console.WriteLine("Your Salary is = " + salary);
            }
        }
    }
}