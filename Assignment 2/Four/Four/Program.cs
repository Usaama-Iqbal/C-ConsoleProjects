namespace four
{
    class program
    {
        static void Main(string[] args)
        {
            float costprice, sellprice, prof, loss;
            Console.WriteLine("Enter the cost price of an item=");
            costprice = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the selling price of an Item=");
            sellprice = Convert.ToSingle(Console.ReadLine());

            if (sellprice > costprice)
            {
                prof = sellprice - costprice;
                Console.WriteLine("The profit is=" +prof);
            }
            else if ( sellprice < costprice) 
            {
                loss = sellprice - costprice;
                Console.WriteLine("The loss is=" +loss);
            }
            else
            {
                Console.WriteLine("There is neither profit nor loss=");
            }
        }
    }
}