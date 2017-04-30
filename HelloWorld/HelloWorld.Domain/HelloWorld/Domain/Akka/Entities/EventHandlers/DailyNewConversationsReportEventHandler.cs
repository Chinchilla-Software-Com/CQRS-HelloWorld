using System;
using HelloWorld.Domain.Akka.Events;

namespace HelloWorld.Domain.Akka.Entities.EventHandlers
{
	public  partial class DailyNewConversationsReportEventHandler
	{
		#region Implementation of IEventHandler<in HelloWorld.Domain.Akka.Events.HelloWorldSaid> Partials

		partial void GetSingleEntityRsn(HelloWorldSaid @event, ref Guid? rsn, ref bool throwExceptionOnMissingEntity)
		{
			throwExceptionOnMissingEntity = false;
		}

		partial void OnEntityUpdated(HelloWorldSaid @event, ref DailyNewConversationsReport entity)
		{
			entity.Date = @event.TimeStamp.UtcDateTime;
		}

		partial void OnSaveEntity(HelloWorldSaid @event, ref DailyNewConversationsReport entity, ref bool continueWithRepositorySave, ref bool createDontUpdate)
		{
			createDontUpdate = true;
		}

		#endregion
	}
}
