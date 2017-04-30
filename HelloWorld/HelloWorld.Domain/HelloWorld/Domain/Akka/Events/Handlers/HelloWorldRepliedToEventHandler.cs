using System;

namespace HelloWorld.Domain.Akka.Events.Handlers
{
	public  partial class HelloWorldRepliedToEventHandler
	{
		partial void OnHandle(HelloWorldRepliedTo @event)
		{
			throw new NotImplementedException();
		}
	}
}
