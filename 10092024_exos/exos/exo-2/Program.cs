using System;
using Identity;

class Program
{
    private string askForInput()
    {
        Console.WriteLine("Veuillez entrer un NAS afin que nous en vérifions la validité.");
        Console.WriteLine("Pour quitter la console, entrez simplement \"q\".");
        
        string result = Console.ReadLine();
        
        if (result == null)
            throw new Exception("Pas d'entrée valide donnée par l'utilisateur.");
        return result;
    }
    
    public void run()
    {
        string input = this.askForInput();

        while (input != null && input.CompareTo("q") != 0)
        {
            NAS nastocheck = new NAS(input);
            if (nastocheck.isValid())
                Console.WriteLine("Le NAS est valide");
            else
                Console.WriteLine("Le NAS n'est pas valide");
            input = this.askForInput();
        }
    }
    
    static void Main()
    {
        Program myprog = new Program();
        myprog.run();
    }
}