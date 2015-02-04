using System.Web.Mvc;
using System.Web.Routing;

namespace TwinCitiesCodeCamp.Routes
{
	public static class RouteConfiguration
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.Add(new LegacyRoutesHandler());
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}",
				defaults: new { controller = "Event", action = "Index" });
		}
	}
}