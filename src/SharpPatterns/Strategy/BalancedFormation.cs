using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Strategy
{
	public class BalancedFormation : IFormation
	{
		public void Play(string teamName)
		{
			Console.WriteLine($"{teamName} Plays Balanced");
		}
	}
}
