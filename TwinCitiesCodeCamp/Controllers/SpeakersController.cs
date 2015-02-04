using System.Web.Mvc;
using TwinCitiesCodeCamp.Models.Speakers;

namespace TwinCitiesCodeCamp.Controllers
{
	public sealed class SpeakersController
		: Controller
	{
		public ActionResult CallForSpeakers()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2015()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2014()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2014()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2013()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2013()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2012()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2012()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2011()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2011()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2010()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2010()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2009()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2009()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2008()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Spring2008()
		{
			return this.View(new SpeakersModel());
		}

		public ActionResult Fall2007()
		{
			return this.View(new SpeakersModel());
		}
	}
}