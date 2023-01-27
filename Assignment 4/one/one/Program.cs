namespace one
{
    public class Number
    {
        public int n;
        public int p;
        bool flag;
        public bool prime()
        {
            for (int i = 0; i < 100; i++)
            {
               
            }
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    p++;
                }
            }
            if (p == 2)
            {
                flag = true;

            }
            else
            {

                flag = false;

            }
            return flag;

        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter any munber = ");
            int num = Convert.ToInt32(Console.ReadLine());

            Number number = new Number();
            number.n = num;

            bool isprime = number.prime();
            if (isprime == true)
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }




        }
    }
}