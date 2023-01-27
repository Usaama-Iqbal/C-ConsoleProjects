namespace four
{
    class proggram
    {
        static void Main(string[] args)
        {
            string userName, passward, user, pass; 
            userName = "Admin";
            passward = "123456789";

            Console.WriteLine("Please Enter your Username : ");
            user = Console.ReadLine();

            Console.WriteLine("Enter your Passward : ");
            pass = Console.ReadLine();

            
            if ((user == userName) && (pass == passward))
            {
                Console.WriteLine("Login Was Successful.");
            }
            else
            {
                Console.WriteLine("Login was UNSUCCESSFUL");
            }


        }
    }
}