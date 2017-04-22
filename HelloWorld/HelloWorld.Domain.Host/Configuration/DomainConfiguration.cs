﻿#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="cdmdotnet Limited">
// // 	Copyright cdmdotnet Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using Cqrs.Authentication;
using Cqrs.Ninject.Configuration;
using Cqrs.Ninject.InProcess.CommandBus.Configuration;
using Cqrs.Ninject.InProcess.EventBus.Configuration;
using Ninject.Modules;

namespace HelloWorld.Domain.Host.Configuration
{
	public class DomainConfiguration<THostModule>
			where THostModule : NinjectModule, new()
	{
		public virtual void Start()
		{
			NinjectDependencyResolver.ModulesToLoad.Add(new THostModule());
			NinjectDependencyResolver.ModulesToLoad.Add(new CqrsModule<SingleSignOnToken, DefaultAuthenticationTokenHelper>(true, false));
			NinjectDependencyResolver.ModulesToLoad.Add(new SimplifiedSqlModule<SingleSignOnToken>());
			NinjectDependencyResolver.ModulesToLoad.Add(new InProcessEventBusModule<SingleSignOnToken>());
			NinjectDependencyResolver.ModulesToLoad.Add(new InProcessCommandBusModule<SingleSignOnToken>());
			// This file will become available once you generate your model.
			NinjectDependencyResolver.ModulesToLoad.Add(new DomainNinjectModule());

			StartResolver();
		}

		protected virtual void StartResolver()
		{
			NinjectDependencyResolver.Start();
		}
	}
}