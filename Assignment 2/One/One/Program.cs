namespace one
{
    class  program
    {
        static void Main(string[] args)
        {
            int pop, popmen, popwomen, poplit, popilit, litmen, ilitmen, litwomen, ilitwomen;
            pop = 80000;
            popmen = (52 * pop) / 100;   //population of men
            popwomen = pop - popmen;    //population of women
            poplit = (48 * pop) / 100;   //literate population
            litmen = (35 * pop) / 100;  //literate population of men
            litwomen = poplit - litmen; //literate population of women
            ilitmen = popmen - litmen;  //iliterate papulation of men
            ilitwomen = popwomen - litwomen;  //iliterate papulation of women

            Console.WriteLine("Population Data=");
            Console.WriteLine("Total population of the city=" +pop);
            Console.WriteLine("Total population of Men=" +popmen);
            Console.WriteLine("Total population of Women=" +popwomen);
            Console.WriteLine("Litertae population of men=" +litmen);
            Console.WriteLine("Literate population of Women=" +litwomen);
            Console.WriteLine("Iliterate population of Men=" +ilitmen);
            Console.WriteLine("Iliterate population of Women=" +ilitwomen);

        }
    }
}