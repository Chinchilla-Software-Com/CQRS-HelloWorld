﻿//------------------------------------------------------------------------------
// <auto-generated>
// 	This code was generated by a tool
// 	Changes to this file will be lost if the code is regenerated.
// CommandHandlerTemplate.t4
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion

using Cqrs.Domain;
using HelloWorld.Domain.Akka;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Commands;
using Cqrs.Configuration;
using Cqrs.Domain;
using Cqrs.Domain.Exceptions;
using Cqrs.Events;
using cdmdotnet.Logging;

namespace HelloWorld.Domain.Akka.Commands.Handlers
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public  partial class ReplyToHelloWorldCommandHandler
		
		: ICommandHandler<Cqrs.Authentication.SingleSignOnToken, ReplyToHelloWorldCommand>
	{

		#region Implementation of ICommandHandler<in ReplyToHelloWorld>

		public void Handle(ReplyToHelloWorldCommand command)
		{
			ICommandValidator<Cqrs.Authentication.SingleSignOnToken, ReplyToHelloWorldCommand> commandValidator = null;
			try
			{
				commandValidator = DependencyResolver.Resolve<ICommandValidator<Cqrs.Authentication.SingleSignOnToken, ReplyToHelloWorldCommand>>();
			}
			catch (Exception exception)
			{
				Logger.LogDebug("Locating an ICommandValidator failed.", "ReplyToHelloWorldCommandHandler\\Handle(ReplyToHelloWorldCommand)", exception);
			}

			if (commandValidator != null && !commandValidator.IsCommandValid(command))
			{
				Logger.LogInfo("The provided command is not valid.", "ReplyToHelloWorldCommandHandler\\Handle(ReplyToHelloWorldCommand)");
				return;
			}

			bool continueExecution = true;
			OnHandle(command, ref continueExecution);
			if (continueExecution)
			{
				Guid rsn = command.Rsn;
				global::Akka.Actor.IActorRef item = AggregateResolver.ResolveActor<HelloWorldExample, Cqrs.Authentication.SingleSignOnToken>(rsn);
				// bool result = global::Akka.Actor.Futures.Ask<bool>(item, command).Result;
				global::Akka.Actor.ActorRefImplicitSenderExtensions.Tell(item, command);
			}
		}

		#endregion

		partial void OnHandle(ReplyToHelloWorldCommand command, ref bool continueExecution);

		partial void OnReplyToHelloWorld(ReplyToHelloWorldCommand command, ref HelloWorldExample item);

		partial void OnReplyToHelloWorldHandled(ReplyToHelloWorldCommand command, HelloWorldExample item);

		partial void OnAddToUnitOfWork(ReplyToHelloWorldCommand command, HelloWorldExample item);

		partial void OnAddedToUnitOfWork(ReplyToHelloWorldCommand command, HelloWorldExample item);

		partial void OnCommit(ReplyToHelloWorldCommand command, HelloWorldExample item);

		partial void OnCommited(ReplyToHelloWorldCommand command, HelloWorldExample item);

		protected ILogger Logger { get; private set; }

		protected IDependencyResolver DependencyResolver { get; private set; }

		protected Cqrs.Akka.Domain.IAkkaAggregateResolver AggregateResolver { get; private set; }

		/// <summary>
		/// Instantiates the <see cref="ReplyToHelloWorldCommandHandler"/> class registering any <see cref="ReceiveActor.Receive{T}(System.Func{T,System.Threading.Tasks.Task})"/> required.
		/// </summary>
		public ReplyToHelloWorldCommandHandler(Cqrs.Akka.Domain.IAkkaAggregateResolver aggregateResolver, IDependencyResolver dependencyResolver, ILogger logger)
			: this (dependencyResolver, logger)
		{
			AggregateResolver = aggregateResolver;
		}

		public ReplyToHelloWorldCommandHandler(IDependencyResolver dependencyResolver, ILogger logger)
		{
			DependencyResolver = dependencyResolver;
			Logger = logger;
		}
	}
}
