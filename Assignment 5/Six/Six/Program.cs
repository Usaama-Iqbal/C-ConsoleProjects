namespace six
{
    class program
    {
        static void Main(string[] args)
        {
            var arr = new int[5];
            
            
            Console.WriteLine("Input 5 elements in the array :");
            for ( int i = 0; i < 5; i++)
            {
                Console.Write(" Element input : " );
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write( arr[j]+ " ");
            }
            
        }
    
    }
}