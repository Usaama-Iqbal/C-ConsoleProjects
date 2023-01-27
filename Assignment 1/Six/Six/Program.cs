namespace practise
{
    class program
    {
        static void Main(string[] args)
        {
            int C, D, A;
            Console.WriteLine("Enter The Value Of C=");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Value Of D=");
            D = Convert.ToInt32(Console.ReadLine());

            C = C + D;
            D = C - D;
            C = C - D;

            Console.WriteLine("The Value Of C=" + C);
            Console.WriteLine("The Value Of D=" + D);

        }
    }
}
