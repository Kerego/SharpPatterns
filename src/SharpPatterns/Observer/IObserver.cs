using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Observer
{
    public interface IObserver
    {
		void Notify(string message);
    }
}
