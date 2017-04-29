using System;
using HelloWorld.Domain.Akka.Events;

namespace HelloWorld.Domain.Akka
{
	public  partial class HelloWorldExample
	{
		partial void OnSayHelloWorld(string firstName, ref HelloWorldSaid helloWorldSaidEvent)
		{
			helloWorldSaidEvent = new HelloWorldSaid(Guid.NewGuid(), firstName, string.Format("Hi, I'm {0}", firstName));
		}

		partial void OnReplyToHelloWorld(string firstName, ref HelloWorldRepliedTo helloWorldRepliedToEvent)
		{
			helloWorldRepliedToEvent = new HelloWorldRepliedTo(Rsn, firstName, string.Format("Hi {0}. How are you?", firstName));
		}

		partial void OnEndConversation(string firstName, ref ConversationEnded conversationEndedEvent)
		{
			conversationEndedEvent = new ConversationEnded(Rsn, string.Format("{0}. I'm ending this conversations", firstName));
		}
	}
}