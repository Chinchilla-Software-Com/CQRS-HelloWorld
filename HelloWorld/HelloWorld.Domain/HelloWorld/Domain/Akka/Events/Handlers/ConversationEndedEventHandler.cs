using System;
using cdmdotnet.AutoMapper;
using cdmdotnet.Logging;
using Cqrs.Entities;

namespace HelloWorld.Domain.Akka.Events.Handlers
{
	public  partial class ConversationEndedEventHandler
	{
		partial void OnHandle(ConversationEnded @event)
		{
			throw new NotImplementedException();
		}
	}
}
