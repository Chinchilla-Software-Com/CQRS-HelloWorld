﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
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
using HelloWorld.Domain.Akka.Events;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWorld.Domain.Akka.Services.Host
{
	public partial class HelloWorldExampleServiceHost
	{
		public virtual void RegisterDataContracts()
		{
			RegisterAggregateServiceDataContracts();
			RegisterServiceDataContracts();
		}

		partial void RegisterServiceDataContracts();
		partial void RegisterAggregateServiceDataContracts();
		partial void RegisterAggregateServiceDataContracts()
		{
	
			HelloWorldExampleServiceSayHelloWorldParametersResolver.RegisterDataContracts();
			HelloWorldExampleServiceReplyToHelloWorldParametersResolver.RegisterDataContracts();
			HelloWorldExampleServiceEndConversationParametersResolver.RegisterDataContracts();
		}
	}
}
