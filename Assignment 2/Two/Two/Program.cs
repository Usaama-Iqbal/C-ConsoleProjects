namespace two
{
    class program
    {
        static void Main(string[] args)
        {
            int money;
            byte hundered, fifty, ten;
            Console.Write("enter amount to be withdrawn=");
            money = Convert.ToInt32(Console.ReadLine());
            hundered = Convert.ToByte(money / 100);

            money = money - (hundered * 100);
            fifty = Convert.ToByte(money / 50);

            money = money - (fifty * 50);
            ten = Convert.ToByte(money / 10);

            Console.WriteLine("denomination of hundered=" +hundered);
            Console.WriteLine("denomination of fifty=" +fifty);
            Console.WriteLine("denomination of tens=" +ten);
            
           
        }
    }
}