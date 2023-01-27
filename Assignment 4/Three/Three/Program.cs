namespace three
{
    public class Vowel
    {
        public void character( char ch)
        {
            switch (ch)
            {
                case 'A':
                case 'a':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':
                    Console.WriteLine(ch+ " is a vowel letter");
                    break;
                default:
                    Console.WriteLine(ch+ " is a special or consonent character ");
                    break;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the letter : ");
            char ch = Convert.ToChar(Console.ReadLine());

            var vowel = new Vowel();
            vowel.character(ch);   
        }
    }
}