using System;
using Circus;
using System.Threading;

class Program
{    public void Run()
    {
        AcrobaticMonkey toto = new AcrobaticMonkey(new List<string> {"Salto arrière", "Culbute", "Salto avant"});
        MusicianMonkey albert = new MusicianMonkey(new List<string> {"Au clair de la lune", "Happy Birthday"});
        Trainer luc = new Trainer(toto);
        Trainer sylvie = new Trainer(albert);
        List<Trainer> trainers = new List<Trainer> {luc, sylvie};
        Random rand = new Random();
        int     index = 0; 
        int     result;
        string  condition = "";

        Console.WriteLine("Un spectateur entre dans un cirque. Il s'installe confortablement et observe des dresseurs entrainer leurs singes.");
        while (condition != null && condition.CompareTo("q") != 0)
        {
            index = rand.Next(0, trainers.Count);
            result = trainers[index].showAMonkeyTrick();
            if (result == 0)
                Console.WriteLine("Le spectateur applaudit");
            else
                Console.WriteLine("Le spectateur siffle");
            Console.WriteLine("Pour arrêter d'observer entrez Q.");
            condition = Console.ReadLine();
        }
    }
    static void Main()
    {
        Program program = new Program();
        program.Run();
    }
}