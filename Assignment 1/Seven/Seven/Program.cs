namespace practise
{
    class program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, rem;
            Console.WriteLine("Enter Five Digit Number");
            num = Convert.ToInt32(Console.ReadLine());

            rem = num % 10;
            sum = sum + rem;
            num = num / 10;
            rem = num % 10;
            sum = sum + rem;
            num = num / 10;
            rem = num % 10;
            sum = sum + rem;
            num = num / 10;
            rem = num % 10;
            sum = sum + rem;
            num = num / 10;
            rem = num % 10;
            sum = sum + rem;
            num = num / 10;
            Console.WriteLine("The Sum Of Five Digit Is=" +sum);

        }
    }
}
