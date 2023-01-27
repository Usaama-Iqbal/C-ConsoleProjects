namespace practise
{
    class program
    {
        static void Main(string[] args)
        {
            float leng, bred, rad, afc, cfc, afr, pfr;

            Console.WriteLine("Enter Length Of Rectangle=");
            leng = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter breadth Of Rectangle=");
            bred = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter radius Of The Circle");
            rad = Convert.ToSingle(Console.ReadLine());

            afr = leng * bred; //(length * bradth) area of rectangle
            pfr = 2 * (leng + bred); //{ 2 * (lenght + breadth)} perimeter of rectangle
            afc = (float)3.14 * rad * rad; //{ 2 pi r where pi = 3.14 } area of circle
            cfc = 2 * (float)3.14 * rad; // 2 pi r circumference of circle

            Console.WriteLine("The Area Of Rectangle=" + afr);
            Console.WriteLine("The Perimeter Of Rectangle=" + pfr);
            Console.WriteLine("The Area Of Circle=" + afc);
            Console.WriteLine("The Circumfrance Of Circle=" + cfc);


        }
    }
}
