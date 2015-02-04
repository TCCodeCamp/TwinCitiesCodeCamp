using System.Web.Mvc;

namespace TwinCitiesCodeCamp
{
	public static class FilterConfiguration
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}