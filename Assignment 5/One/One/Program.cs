namespace one
{
    public class printReverseArray
    {

        public static void reverse(int[] n)
        {

            for (int i = 9; i > -1; i--)
            {
                Console.Write(n[i] + " , ");
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {


            var num = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            printReverseArray.reverse(num);
;       }
    }
}