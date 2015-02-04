using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using TwinCitiesCodeCamp.Routes;

namespace TwinCitiesCodeCamp
{
	public class MvcApplication
		: HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfiguration.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfiguration.RegisterRoutes(RouteTable.Routes);

			var container = MvcApplication.CreateContainer();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}

		private static IContainer CreateContainer()
		{
			var builder = new ContainerBuilder();
			new WebContainerBuilderComposition().Compose(builder);
			return builder.Build();
		}
	}
}
