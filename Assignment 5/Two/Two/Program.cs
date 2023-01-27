namespace two
{
    public class sortArrayDescending
    {
        public static void descending(int[] n)
        {
            for (int i = 0; i <= 8 - 1; i++)
            {
                Console.Write(n[i] + " , ");
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            var number = new int[8] { 10, 65, 34, 32, 67, 54, 12, 90 };
            Array.Sort(number);
            Array.Reverse(number);
            sortArrayDescending.descending(number);

        }
    }
}