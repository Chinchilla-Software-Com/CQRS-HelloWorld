using System;

namespace HelloWorld.Domain.Akka.Events.Handlers
{
	public  partial class HelloWorldSaidEventHandler
	{
		partial void OnHandle(HelloWorldSaid @event)
		{
			throw new NotImplementedException();
		}
	}
}
