using System.Web.Mvc;
using TwinCitiesCodeCamp.Models.News;

namespace TwinCitiesCodeCamp.Controllers
{
	public sealed class EventController
		: Controller
	{
		public ActionResult Index()
		{
			return this.View(new EventIndexModel());
		}
	}
}