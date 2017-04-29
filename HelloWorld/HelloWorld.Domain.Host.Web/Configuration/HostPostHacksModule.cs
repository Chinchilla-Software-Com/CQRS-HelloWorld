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
	public class HostPostHacksModule : NinjectModule
	{
		public override void Load()
		{
#pragma warning disable 618
			var commandsender = (ICommandPublisher<SingleSignOnToken>)Resolve<ICommandSender<SingleSignOnToken>>();
#pragma warning restore 618

			Bind<ICommandPublisher<SingleSignOnToken>>()
				.ToConstant(commandsender)
				.InSingletonScope();
		}

		protected T Resolve<T>()
		{
			return (T)Resolve(typeof(T));
		}

		protected object Resolve(Type serviceType)
		{
			return Kernel.Resolve(Kernel.CreateRequest(serviceType, null, new Parameter[0], true, true)).SingleOrDefault();
		}
	}
}