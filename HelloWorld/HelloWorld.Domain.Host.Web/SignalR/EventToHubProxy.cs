﻿using cdmdotnet.Logging;
using Cqrs.Authentication;

namespace HelloWorld.Domain.Host.Web.SignalR
{
	public partial class EventToHubProxy : Cqrs.WebApi.Events.Handlers.EventToHubProxy<SingleSignOnToken>
	{
		public EventToHubProxy(ILogger logger, Cqrs.WebApi.SignalR.Hubs.NotificationHub notificationHub, IAuthenticationTokenHelper<SingleSignOnToken> authenticationTokenHelper)
			: base(logger, notificationHub, authenticationTokenHelper)
		{
		}
	}
}