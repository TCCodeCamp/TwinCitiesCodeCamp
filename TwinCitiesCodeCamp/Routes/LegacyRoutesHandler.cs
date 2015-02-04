using System.IO;
using System.Linq;
using System.Web;
using System.Web.Routing;
using SocialPresence.Core;
using SocialPresence.Core.Extensions;

namespace TwinCitiesCodeCamp.Routes
{
	public sealed class LegacyRoutesHandler
		: RouteBase
	{
		private const string MovedPermanentlyStatus = "301 Moved Permanently";

		public override RouteData GetRouteData(HttpContextBase httpContext)
		{
			var request = httpContext.Request;
			var response = httpContext.Response;

			var currentUrl = new ExtendedUri(request.Url);
			var segments = currentUrl.Segments.ToArray();
			var lastSegment = segments.Last();
			var lowerLastSegment = lastSegment.ToLower();

			if (lowerLastSegment.EndsWith(".aspx"))
			{
				// We're getting something like Default.aspx, or Policies.aspx, or Fall2012/Sessions.aspx#s27
				// I think what I want is to remove ".aspx"...and that's it.
				// Except for Default.aspx. That should go to "/News/Index", or really, "/"
				if (lowerLastSegment == "default.aspx")
				{
					response.RedirectPermanent("News/Index", true);
				}
				else if (lowerLastSegment.Contains("contributors") || lowerLastSegment.Contains("schedule") ||
					lowerLastSegment.Contains("sessions") || lowerLastSegment.Contains("speakers"))
				{
					// This needs to take the previous segment with the name of the "file", and do something like this:
					// response.RedirectLocation = {filenamewithoutdotaspx) + "/" + previoussegment
					//response.RedirectLocation = Path.GetFileNameWithoutExtension(lastSegment) + "/" +
					//	segments[segments.Length - 2].Replace("/", string.Empty);
					response.RedirectPermanent("~/" + Path.GetFileNameWithoutExtension(lastSegment) + "/" +
						segments[segments.Length - 2].Replace("/", string.Empty), true);
				}
				else
				{
					response.RedirectPermanent(lastSegment.Substitute(".aspx", string.Empty), true);
				}
			}

			return null;
		}

		public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
		{
			return null;
		}
	}
}
