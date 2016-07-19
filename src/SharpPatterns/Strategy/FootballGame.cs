using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Strategy
{
    public class FootballGame
    {
		FootballTeam _team1;
		FootballTeam _team2;
		Random rand = new Random();

		public int Team1Score { get; set; }
		public int Team2Score { get; set; }

		public TimeSpan Time;

		public bool GameEnded => Time.TotalMinutes == 90;

		public FootballGame(FootballTeam team1, FootballTeam team2)
		{
			_team1 = team1;
			_team2 = team2;
			_team1.SetPlayFormation(new BalancedFormation());
			_team2.SetPlayFormation(new BalancedFormation());
		}

		public void Play()
		{
			Console.WriteLine($"Minute: {Time.TotalMinutes}");
			Time += TimeSpan.FromMinutes(15);
			//check goal for first team
			if (CheckGoal())
			{
				Team1Score++;
				Console.WriteLine("Team 1 Scored");
			}
			//check goal for second team
			if(CheckGoal())
			{
				Team2Score++;
				Console.WriteLine("Team 2 Scored");
			}
			//change teams strategies based on current score
			if(Team1Score > Team2Score)
			{
				_team1.SetPlayFormation(new DefensiveFormation());
				_team2.SetPlayFormation(new AttackingFormation());
			}
			else if(Team1Score < Team2Score)
			{
				_team2.SetPlayFormation(new DefensiveFormation());
				_team1.SetPlayFormation(new AttackingFormation());
			}
			else
			{
				_team1.SetPlayFormation(new BalancedFormation());
				_team2.SetPlayFormation(new BalancedFormation());
			}

			_team1.Play();
			_team2.Play();
		}

		private bool CheckGoal()
		{
			return rand.Next(10) > 5;
		}
    }
}
