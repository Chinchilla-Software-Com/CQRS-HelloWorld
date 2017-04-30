using System;
using System.Linq;
using Ninject.Modules;
using Ninject.Parameters;

namespace HelloWorld.Domain.Host.Web.Configuration
{
	/// <summary>
	/// The <see cref="INinjectModule"/> for use with the domain package.
	/// </summary>
	public class HostPostHacksModule : NinjectModule
	{
		public override void Load()
		{
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