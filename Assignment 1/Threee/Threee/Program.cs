namespace practise
{
    class program
    {
        static void Main(string[] args)
        {
            int bio, math, phy, chem, eng, total;
            float perc;


            Console.WriteLine("Enter The Marks In Biology=");
            bio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks In Mathematics=");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks In Physics=");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks In Chemistry=");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks In English=");
            eng = Convert.ToInt32(Console.ReadLine());

            total = bio + math + phy + chem + eng;
            perc = total / 5 * 100;

            Console.WriteLine("Aggragate marks=" + total);
            Console.WriteLine("Percentage marks=" + perc);

        }
    }
}
