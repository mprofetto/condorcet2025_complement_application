using System;
using System.Collections.Generic;

namespace chronomètre_perso
{
    public class Chrono
    {
        bool        started = false;
        DateTime    last_start_time;
        TimeSpan    current_turn = TimeSpan.Zero;
        List<TimeSpan> turns = new List<TimeSpan> {};

        public void start()
        {
            if (started == false)
            {
                started = true;
                last_start_time = DateTime.Now;
                Console.WriteLine($"Chronomètre démarré à {last_start_time}");
            }
        }

		public void stop()
		{
			int i = 0;
			
			foreach(TimeSpan turn in turns)
			{
				double duree = turn.TotalSeconds;
				Console.WriteLine($"Tour n°{i + 1}: temps en secondes {duree}");
				i++;
			}
		}

        public void pause()
        {
			if (started == true)
			{
	            started = false;
                current_turn += DateTime.Now - last_start_time;
           		Console.WriteLine($"Durée du tour au moment de la pause: {current_turn}");
			}
        }

		public void reset()
        {
            started = false;
			current_turn = TimeSpan.Zero;
            turns.Clear();
			Console.WriteLine($"Le chronomètre a été réinitialisé");
        }

        public void newTurn()
        {
			if (started == true)
			{
				current_turn += DateTime.Now - last_start_time;
				last_start_time = DateTime.Now;
				turns.Add(current_turn);
				Console.WriteLine($"Durée du tour terminé: {current_turn}");
				current_turn = TimeSpan.Zero;
			}
        }
    }
}