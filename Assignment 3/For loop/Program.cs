namespace forloop
{
    class program
    {
        static void Main(string[] args)
        {
            int sum=0,num, aver;
            
            Console.WriteLine("Enter 10 number:");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("enter number-" +i+" = ");
                num = Convert.ToInt32(Console.ReadLine());
                
                sum= sum+num;
                

            }
            Console.WriteLine("The sum of 10 digit is=" + sum);
             aver =sum/10;   
            
            Console.WriteLine("The average of 10 digit number is=" +aver);
            

        }
    }
}