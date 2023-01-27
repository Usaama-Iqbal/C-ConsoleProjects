namespace six
{
    class program
    {
        static void Main(string[] args) 
        {
            int  number;
            Console.WriteLine("Enter a number=");
            number= Convert.ToInt32(Console.ReadLine());
            
            if (number > 0)
            {
                number = number * (1);
            }
            else
            {
                number = number * (-1);
            }
            
            Console.WriteLine("The absolute value=" +number);
        }
    }
}