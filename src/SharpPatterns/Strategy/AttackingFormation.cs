﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Strategy
{
	public class AttackingFormation : IFormation
	{
		public void Play(string teamName)
		{
			Console.WriteLine($"{teamName} Plays Offensive");
		}
	}
}
