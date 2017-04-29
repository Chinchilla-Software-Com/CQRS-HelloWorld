using HelloWorld.Domain.Akka.Commands;

namespace HelloWorld.Domain.Akka.Events.Handlers
{
	/// <summary>
	/// Converts <see cref="HelloWorldSaid"/> to a <see cref="HelloWorld.Domain.Akka.Commands.ReplyToHelloWorldCommand"/> and publish it using <see cref="CommandBus"/>
	/// </summary>
	public partial class HelloWorldSaidToReplyToHelloWorldEventToCommandHandler
	{
		partial void OnHandle(HelloWorldSaid @event, ref ReplyToHelloWorldCommand command)
		{
			if (@event.FirstName == "Bob")
				command = new ReplyToHelloWorldCommand(@event.Rsn, @event.FirstName);
		}
	}
}
