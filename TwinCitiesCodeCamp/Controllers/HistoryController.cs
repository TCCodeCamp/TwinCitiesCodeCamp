using System.Web.Mvc;
using TwinCitiesCodeCamp.Models.History;

namespace TwinCitiesCodeCamp.Controllers
{
	public sealed class HistoryController
		: Controller
	{
		public ActionResult Index()
		{
			return this.View(new HistoryIndexModel());
		}
	}
}