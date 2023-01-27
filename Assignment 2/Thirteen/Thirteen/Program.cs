namespace thirteen
{
    class program
    {
        static void Main(string[] args)
        {
         int age, premium, max_amount;
            char health, location, gender;
            Console.WriteLine("Enter 'G' for good & 'B' for bad health=");
            health = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter 'C'for city & 'V' for village=");
            location = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter 'F' for female & 'M' for male=");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the age=");
            age = Convert.ToInt32(Console.ReadLine());

            if (health == 'G')
            {
                if ((((age >= 25) && (age <=35)) &&((location == 'C') &&(gender == 'M'))))
                {
                    premium = 40000;
                    max_amount = 200000;
                    Console.WriteLine("The person is insured");
                    Console.WriteLine("The premium is=" +premium);
                    Console.WriteLine("The max-amount is=" +max_amount);
                }
                if (health == 'G')
                {
                    if ((((age >=25) && (age <=35)) &&((location == 'C')&& (gender == 'F'))))
                    {
                        premium = 30000;
                        max_amount = 100000;
                        Console.WriteLine("The person is insured");
                        Console.WriteLine("The premium is =" + premium);
                        Console.WriteLine("The max-amount is+" + max_amount);
                    }
                    
                }
                 if (health == 'B')
                {
                    if ((((age >=25) &&(age <=35)) && ((location =='V') &&(gender == 'M'))))
                    {
                        premium = 60000;
                        max_amount = 10000;
                        Console.WriteLine("The person is insured");
                        Console.WriteLine("The premium is=" + premium);
                        Console.WriteLine("The max-amount is=" + max_amount);
                    }
                }
                    
                
                else
                {
                    Console.WriteLine("the person is not insured:");
                }
            }

        }
    }
}