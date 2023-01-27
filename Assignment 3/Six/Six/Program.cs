namespace six
{
    class program
    {
        static void Main(string[] args) 
        {
            int num, fact = 1;
            Console.WriteLine("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 1)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("The factorial of number is :" +fact);
        }
    }
}