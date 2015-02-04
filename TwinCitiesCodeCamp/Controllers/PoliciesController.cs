using System.Web.Mvc;
using TwinCitiesCodeCamp.Models.Policies;

namespace TwinCitiesCodeCamp.Controllers
{
	public sealed class PoliciesController
		: Controller
	{
		public ActionResult Index()
		{
			return this.View(new PoliciesIndexModel());
		}
	}
}