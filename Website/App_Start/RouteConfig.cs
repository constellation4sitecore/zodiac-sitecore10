using System.Web.Mvc;
using System.Web.Routing;

namespace Website
{
	// This class is here to ensure that someone doesn't automatically add this route via a wizard and break Sitecore.
	// You can add routes here if you need to, but you should avoid custom routes. Use Sitecore Items with Controllers instead.
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// Sitecore considers this route illegal, do not enable this route.

			//routes.MapRoute(
			//    name: "Default",
			//    url: "{controller}/{action}/{id}",
			//    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}
