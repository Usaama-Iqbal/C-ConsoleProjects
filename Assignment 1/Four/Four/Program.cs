namespace four
{
    class program
    {
        static void Main(string[] args)
        {
            float farh, cent;
            Console.WriteLine("Enter Temperature  in fahrenheit=");
            farh = Convert.ToSingle(Console.ReadLine());
            cent = ((farh - 32) * 5 / 9);
            Console.WriteLine("The Temperature in Centigrade degree=" + cent);
        }
    }
}
