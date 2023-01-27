namespace three
{
    public class isIdentityMatrix
    {
        public static bool isIdentity(int[ , ] arr)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == j)
                    {
                        if (arr[i,j]==1)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                            
                        }
                    }
                    else
                    {
                        if (arr[i, j] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            return false;

                        }
                    }
                }
            }
            return true;
        }
    }
    class program
    {
        static void Main(string[] args) 
        {
            var arr = new int[2, 2]
            {
                {1,0 },
                {0,1 }
            };
            if(isIdentityMatrix.isIdentity(arr))
            {
                Console.WriteLine("The Matrix is identity matrix . ");
            }
            else
            {
                Console.WriteLine("The Matrix is not identity matrix . ");
            }
        }
    }
}