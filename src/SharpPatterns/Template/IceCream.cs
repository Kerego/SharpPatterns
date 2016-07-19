using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Template
{
	public class IceCream : Meal
	{
		public override void Adorn()
		{
			Console.WriteLine("Adding a horn");
		}

		public override void GatherIngredients()
		{
			Console.WriteLine("Milking a cow");
		}

		public override void TemperatureTreatment()
		{
			Console.WriteLine("Cooling the milk");
		}
	}
}
