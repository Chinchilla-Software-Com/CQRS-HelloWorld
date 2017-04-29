#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="cdmdotnet Limited">
// // 	Copyright cdmdotnet Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using System;
using System.Linq;
using System.Web;
using cdmdotnet.Logging;
using Cqrs.Authentication;
using Cqrs.Azure.ConfigurationManager;
using Cqrs.Commands;
using Cqrs.Configuration;
using Cqrs.WebApi.SignalR.Hubs;
using Ninject;
using Ninject.Modules;
using Ninject.Parameters;
using Ninject.Web.Common;

namespace HelloWorld.Domain.Host.Web.Configuration
{
	/// <summary>
	/// The <see cref="INinjectModule"/> for use with the domain package.
	/// </summary>
	public class HostPreHacksModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ITelemetryHelper>()
				.To<NullTelemetryHelper>()
				.InSingletonScope();
		}
	}
}