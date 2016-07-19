using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Template
{
    public abstract class Meal
    {
		public void Prepare()
		{
			GatherIngredients();
			TemperatureTreatment();
			Adorn();
		}
		public abstract void GatherIngredients();
		public abstract void TemperatureTreatment();
		public abstract void Adorn();
    }
}
