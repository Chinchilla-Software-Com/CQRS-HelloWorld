using System.Runtime.Serialization;

namespace HelloWorld.Domain.Akka.Services
{


	/// <summary>
	/// A <see cref="DataContractResolver"/> for using <see cref="IHelloWorldExampleService.SayHelloWorld"/> via WCF
	/// </summary>
	public partial class HelloWorldExampleServiceSayHelloWorldParametersResolver
	{
	}

	/// <summary>
	/// A <see cref="DataContractResolver"/> for using <see cref="IHelloWorldExampleService.ReplyToHelloWorld"/> via WCF
	/// </summary>
	public partial class HelloWorldExampleServiceReplyToHelloWorldParametersResolver
	{
	}

	/// <summary>
	/// A <see cref="DataContractResolver"/> for using <see cref="IHelloWorldExampleService.EndConversation"/> via WCF
	/// </summary>
	public partial class HelloWorldExampleServiceEndConversationParametersResolver
	{
	}
}
