using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Strategy
{
    public interface IFormation
    {
		void Play(string teamName);
    }

}
