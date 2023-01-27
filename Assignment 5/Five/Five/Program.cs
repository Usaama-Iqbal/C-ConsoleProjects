namespace five
{
    class program
    {
        static void Main(string[] args)
        {
            var A = new int [2 , 2]
                {
                {3, 4},
                { 6, 7}
                };

            var  B= new int [2, 2]
                {
                { 1, 7},
                { 9, 8}
                };

            var C = new int [2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.WriteLine(C[i,j]+ " ");
                }
                Console.WriteLine('\n');
            }
        }
    }
}