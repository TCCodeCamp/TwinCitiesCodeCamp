using System.Web.Mvc;
using TwinCitiesCodeCamp.Models.Information;

namespace TwinCitiesCodeCamp.Controllers
{
	public sealed class InformationController
		: Controller
	{
		public ActionResult Index()
		{
			return this.View(new InformationIndexModel());
		}
	}
}