namespace seven
{
    class program
    {
        static void Main(string[] args)
        {
            string str;
            int i, length, vowel, cons;

            Console.Write("Count total number of vowel or consonant : ");

            str = Console.ReadLine();

            vowel = 0;
            cons = 0;
            length = str.Length;

            for (i = 0; i < length; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    cons++;
                }
            }
            Console.WriteLine("The total number of vowel in the string is : " + vowel);
            Console.WriteLine("The total number of consonant in the string is : " + cons);
        
        }
    }
}