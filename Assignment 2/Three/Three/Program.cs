namespace three
{
    class program
    {
        static void Main(string[] args) 
        {
            float sell, prof, cost;
            Console.WriteLine("Enter the selling price of 15 items=");
            sell = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the profit on 15 items=");
            prof = Convert.ToSingle(Console.ReadLine());
            
            cost = (sell - prof) / 15;
            Console.WriteLine("The cost price of an item is=" +cost);

        }
    }
}