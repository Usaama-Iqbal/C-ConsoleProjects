namespace practise
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Distance In Kilometers=");
            int km = Convert.ToInt32(Console.ReadLine());
            int m, fe, inch, cm;
            m = (km * 1000);
            fe = (int)(km * 3280.84);
            inch = (int)(km * 39370.08);
            cm = (int)(km * 1000 * 100);
            Console.WriteLine("In Meters=" + m);
            Console.WriteLine("In Feet=" + fe);
            Console.WriteLine("In Inches=" + inch);
            Console.WriteLine("In Centimeters=" +cm);
        }
    }
}
