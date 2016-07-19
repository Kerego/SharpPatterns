using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpPatterns.Observer
{
	public class Channel : IObservable
	{
		ICollection<IObserver> observers = new List<IObserver>();

		public void Subscribe(IObserver observer)
		{
			observers.Add(observer);
		}

		//New message received
		public void NewMessage(string message)
		{
			//Notify every user about new message on channel
			foreach (var observer in observers)
			{
				observer.Notify(message);
			}
		}

	}
}
