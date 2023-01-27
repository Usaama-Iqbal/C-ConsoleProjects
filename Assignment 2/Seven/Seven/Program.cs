namespace seven
{
    class program
    {
        static void Main(string[] args)
        {
            byte taimoor, bilal, hassan;
            Console.WriteLine("Enter age of Taimoor=");
            taimoor = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter age if Bilal=");
            bilal = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter age of hassan=");
            hassan = Convert.ToByte(Console.ReadLine());

            if (taimoor <= bilal)
            {
                if (taimoor <= hassan)
                {
                    Console.WriteLine("Taimoor is youngest");
                }
                else
                {
                    Console.WriteLine("Hassan is youngest");
                }
            }
            else if (bilal <= hassan)
            {
                Console.WriteLine("Bilal is youngest");
            }
            else
            {
                Console.WriteLine("Hassan is youngest");
            }
        }
    }
}