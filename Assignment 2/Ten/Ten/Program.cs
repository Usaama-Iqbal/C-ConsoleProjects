namespace ten
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

            if ((ms =='M')  || (gen == 'M') && (age > 30) || ((gen == 'F') && (age > 25)) )

            {
                Console.WriteLine("The driver is insured");
            }
            else
            {
                Console.WriteLine("The driver is not insured");
            }
        }
    }
}