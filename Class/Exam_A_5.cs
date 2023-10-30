using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Logical_and_Review_Code.Class
{
	class EventPublisher
	{
		public event EventHandler MyEvent;
		public void RaiseEvent()
		{
			MyEvent?.Invoke(this, EventArgs.Empty);
		}
	}
	/*class EventSubscriber
	{
		public EventSubscriber(EventPublisher publisher)
		{
			publisher.MyEvent += OnMyEvent;
		}
		private void OnMyEvent(object sender, EventArgs e)
		{
			Console.WriteLine("MyEvent raised");
		}
	}*/

	class EventSubscriber : IDisposable
	{
		private readonly EventPublisher _publisher;
		private bool _disposed = false;
		public EventSubscriber(EventPublisher publisher)
		{
			_publisher = publisher;
			_publisher.MyEvent += OnMyEvent;
		}

		private void OnMyEvent(object sender, EventArgs e)
		{
			Console.WriteLine("MyEvent raised");
		}
		protected virtual void Dispose(bool disposing)
		{
			if (_disposed)
				return;

			if (disposing)
			{
				_publisher.MyEvent -= OnMyEvent;
			}

			_disposed = true;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}

}
