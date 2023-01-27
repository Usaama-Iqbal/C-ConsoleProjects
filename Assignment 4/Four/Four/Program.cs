namespace four
{
    public class Month
    {
        public static void num(int month) 
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 Days ");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days ");
                    break;
                case 2:
                    Console.WriteLine("29 / 28 days");
                    break;
                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Month number (1 to 12) : ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            Month.num(month);
        }
    }
}