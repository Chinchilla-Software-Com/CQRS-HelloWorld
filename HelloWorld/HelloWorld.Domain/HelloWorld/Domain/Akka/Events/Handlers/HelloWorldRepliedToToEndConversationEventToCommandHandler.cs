using System;
using HelloWorld.Domain.Akka.Commands;

namespace HelloWorld.Domain.Akka.Events.Handlers
{
	/// <summary>
	/// Converts <see cref="HelloWorldRepliedTo"/> to a <see cref="HelloWorld.Domain.Akka.Commands.EndConversationCommand"/> and publish it using <see cref="CommandBus"/>
	/// </summary>
	public partial class HelloWorldRepliedToToEndConversationEventToCommandHandler
	{
		public partial class Actor
		{
			partial void OnHandle(HelloWorldRepliedTo @event, ref EndConversationCommand command)
			{
				if (string.Compare(@event.Message, "GoodBye", StringComparison.InvariantCultureIgnoreCase) == 0)
					command = new EndConversationCommand(@event.Rsn, @event.FirstName);
			}

			partial void OnHandled(HelloWorldRepliedTo @event)
			{
				
			}
		}
	}
}
