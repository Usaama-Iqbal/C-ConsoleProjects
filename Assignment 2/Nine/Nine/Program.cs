namespace nine
{
    class program
    {
        static void Main(string[] args)
        {
            char gen, ms;
            byte age;

            Console.WriteLine("Enter martial status of driver =");
            Console.WriteLine("Enter M for married and U for unmarried =");
            ms = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter gender of driver =");
            Console.WriteLine("Enter M for male and F for female =");
            gen = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter driver age =");
            age = Convert.ToByte(Console.ReadLine());

            if (ms == 'M')
            {
                Console.WriteLine("The driver is insured");
            }
            else
            {
                if (gen == 'M')
                {
                    if (age > 30)
                    {
                        Console.WriteLine("Driver is insured");
                    }
                    else
                    {
                        Console.WriteLine("Driver is not insured");
                    }
                }
                else
                {
                    if (age > 25)
                    {
                        Console.WriteLine("Driver is insured");
                    }
                    else
                    {
                        Console.WriteLine("driver is not insured");
                    }
                }
            }
        }
    }
}