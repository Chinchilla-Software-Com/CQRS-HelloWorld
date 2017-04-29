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
using System.CodeDom.Compiler;
using cdmdotnet.Logging;
using Cqrs.Configuration;
using Cqrs.DataStores;

namespace HelloWorld.Domain.Factories
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	/// <summary>
	/// A factory for obtaining <see cref="IDataStore{TData}"/> instances using the built-in simplified Sql
	/// </summary>
	public partial class DomainSimplifiedSqlDataStoreFactory : IDomainDataStoreFactory
	{
		public DomainSimplifiedSqlDataStoreFactory(ILogger logger, IConfigurationManager configurationManager)
		{
			Logger = logger;
			ConfigurationManager = configurationManager;
		}

		protected ILogger Logger { get; private set; }

		protected IConfigurationManager ConfigurationManager { get; private set; }

		#region Implementation of IDomainDataStoreFactory

		public virtual IDataStore<Akka.Entities.DailyNewConversationsReport> GetDailyNewConversationsReportDataStore()
		{
			IDataStore<Akka.Entities.DailyNewConversationsReport> result = new SqlDataStore<Akka.Entities.DailyNewConversationsReport>(ConfigurationManager, Logger);
			OnGetDailyNewConversationsReportDataStore(ref result);
			return result;
		}


		#endregion

		partial void OnGetDailyNewConversationsReportDataStore(ref IDataStore<Akka.Entities.DailyNewConversationsReport> result);

	}
}
