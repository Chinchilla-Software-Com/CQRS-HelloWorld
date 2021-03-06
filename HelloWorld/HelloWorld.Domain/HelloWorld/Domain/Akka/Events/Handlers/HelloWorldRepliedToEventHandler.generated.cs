﻿//------------------------------------------------------------------------------
// <auto-generated>
// 	This code was generated by a tool
// 	Changes to this file will be lost if the code is regenerated.
// EventAutoHandlerTemplate.t4
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using cdmdotnet.AutoMapper;
using cdmdotnet.Logging;
using Cqrs.Events;
using Cqrs.Domain;

namespace HelloWorld.Domain.Akka.Events.Handlers
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public  partial class HelloWorldRepliedToEventHandler
		
		: IEventHandler<Cqrs.Authentication.SingleSignOnToken, HelloWorldRepliedTo>
	{

		public HelloWorldRepliedToEventHandler(ILogger logger, IAutomapHelper automapHelper)
		{
			Logger = logger;
			AutomapHelper = automapHelper;
		}

		protected ILogger Logger { get; private set; }

		protected IAutomapHelper AutomapHelper { get; private set; }

		#region Implementation of IEventHandler<in HelloWorldRepliedTo>

		public void Handle(HelloWorldRepliedTo @event)
		{
			OnHandle(@event);
		}

		#endregion

		partial void OnHandle(HelloWorldRepliedTo @event);
	}
}
