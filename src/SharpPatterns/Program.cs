using SharpPatterns.Observer;
using SharpPatterns.Strategy;
using SharpPatterns.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns
{
    public class Program
    {
        public static void Main(string[] args)
		{
			WriteLineColored("Observer");
			#region observer
			IObserver user1 = new User { Name = "Vova" };
			IObserver user2 = new User { Name = "Nina" };
			IObserver user3 = new User { Name = "Stepa" };
			Channel channel = new Channel();
			//subscribe user 1 & 2, not 3
			channel.Subscribe(user1);
			channel.Subscribe(user2);

			//only user 1 and 2 are notified
			channel.NewMessage("Hello");

			#endregion
			WriteLineColored("Strategy");
			#region strategy
			var zaria = new FootballTeam() { Name = "Zarea" };
			var zimbru = new FootballTeam() { Name = "Zimbru" };
			var game = new FootballGame(zaria, zimbru);
			
			while(!game.GameEnded)
			{
				game.Play();
			}
			Console.WriteLine("Game End!");
			Console.WriteLine($"{zaria.Name} {game.Team1Score}:{game.Team2Score} {zimbru.Name}");
			#endregion

			WriteLineColored("Template");
			#region template method
			Meal icecream = new IceCream();
			Meal steak = new Steak();
			Console.WriteLine("\r\nPreparing an icecream");
			icecream.Prepare();
			Console.WriteLine("\r\nPreparing a steak");
			steak.Prepare();

			#endregion


			Console.Read();
		}

		public static void WriteLineColored(string message)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
