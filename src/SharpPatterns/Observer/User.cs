using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Observer
{
	public class User : IObserver
	{
		public string Name { get; set; }
		public void Notify(string message)
		{
			Console.WriteLine($"User {Name} received message \"{message}\"");
		}
	}
}
