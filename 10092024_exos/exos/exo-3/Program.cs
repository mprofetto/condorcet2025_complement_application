using System;
using chronomètre_perso;

class Program
{
    private string askForInput()
    {     
        string result = Console.ReadLine();
        
        if (result == null)
            throw new Exception("Pas d'entrée valide donnée par l'utilisateur.");
        return result;
    }
    
    public void run()
    {
        Console.WriteLine("Pour démarrer le chronomètre, veuillez entrer \"start\".");
        Console.WriteLine("Pour arrêter le chronomètre, veuillez entrer \"stop\".");
        Console.WriteLine("Pour interrompre le chronomètre, veuillez entrer \"pause\".");
        Console.WriteLine("Pour comptabiliser un nouveau tour, veuillez entrer \"new\".");
        Console.WriteLine("Pour réinitialiser le chronomètre, veuillez entrer \"reset\".");
        Console.WriteLine("Pour quitter la console, entrez simplement \"q\".");

        string  input = this.askForInput();
        Chrono  mychrono = new Chrono();

        while (input != null && input.CompareTo("q") != 0)
        {
            switch (input)
            {
                case "start":
                    mychrono.start();
                    break;
                case "stop":
                    mychrono.stop();
                    break;
                case "pause":
                    mychrono.pause();
                    break;
                case "new":
                    mychrono.newTurn();
                    break;
                case "reset":
                    mychrono.reset();
                    break;
                default:
                    Console.WriteLine("Entrée non reconnue");
                    break;
            }
            // if (input.CompareTo("start") == 0)
            //     mychrono.start();
            input = this.askForInput();
        }
    }
    
    static void Main()
    {
        Program myprog = new Program();
        myprog.run();
    }
}