using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Template
{
	public class Steak : Meal
	{
		public override void Adorn()
		{
			Console.WriteLine("Adding rosemarine");
		}

		public override void GatherIngredients()
		{
			Console.WriteLine("Hunting for meat");
		}

		public override void TemperatureTreatment()
		{
			Console.WriteLine("Frying the meat");
		}
	}
}
