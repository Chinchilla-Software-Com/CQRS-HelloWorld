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
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Entities;

namespace HelloWorld.Domain.Akka.Entities
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public  partial interface IDailyNewConversationsReport : IEntity
	{
		[DataMember]
		int Number { get; set; }

		[DataMember]
		DateTime Date { get; set; }
	}
}
