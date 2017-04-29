#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="cdmdotnet Limited">
// // 	Copyright cdmdotnet Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using Cqrs.Ninject.Configuration;
using Ninject;
using Ninject.Extensions.Wcf;
using HelloWorld.Domain.Host.Configuration;

namespace HelloWorld.Domain.Host.Web.Configuration
{
	public class WebDomainConfiguration : DomainConfiguration<WebHostModule>
	{
		#region Overrides of DomainConfiguration<WebHostModule>

		protected override void StartResolver()
		{
			NinjectDependencyResolver.ModulesToLoad.Insert(0, new HostPreHacksModule());
			NinjectDependencyResolver.ModulesToLoad.Add(new HostPostHacksModule());

			// NinjectDependencyResolver.Start();
			var kernel = new StandardKernel();
			// This is only done so the follow Wcf safe method can be called. Otherwise use the commented out line above.
			NinjectDependencyResolver.Start(kernel, true);
			BaseNinjectServiceHostFactory.SetKernel(kernel);
		}

		#endregion
	}
}