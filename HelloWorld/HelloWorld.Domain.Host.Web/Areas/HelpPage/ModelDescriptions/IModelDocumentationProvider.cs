using System;
using System.Reflection;

namespace HelloWorld.Domain.Host.Web.Areas.HelpPage.ModelDescriptions
{
	public interface IModelDocumentationProvider
	{
		string GetDocumentation(MemberInfo member);

		string GetDocumentation(Type type);
	}
}