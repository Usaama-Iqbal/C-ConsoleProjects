namespace five
{
    public class Calculator
    {
        public static void calcu(int n1,char p,int n2)
        {
            int result = 0;
            switch (p)
            {
                case '+':
                    result = n1 + n2;
                    Console.WriteLine("The addition of two numbers is : " + result);
                    break;

                case '-':
                    result = n1 - n2;
                    Console.WriteLine("The subtraction of two numbers is : " + result);
                    break;

                case '*':
                    result = n1 * n2;
                    Console.WriteLine("The multiplication of two numbers is : " + result);
                    break;

                case '/':
                    result = n1 / n2;
                    Console.WriteLine("The division of two numbers is : " + result);
                    break;
                default:

                    Console.WriteLine("Invalid operator : ");
                    break;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            char op;
            int num1, num2;
            Console.WriteLine("Simple Calculator : ");
            Console.WriteLine("_____________________________________________");
            Console.Write("Enter number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Operator (+, -, *, /) : ");
            op = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Calculator.calcu(num1, op, num2);
        }
    }
}