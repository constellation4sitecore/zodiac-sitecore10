using System.Web.Mvc;
using System.Web.Routing;

namespace Website
{
	/// <summary>
	/// Sitecore will not work without this file. You can modify the Application events if you wish, but
	/// be sure to implement any base logic from Sitecore.Web.Application if you do so to keep Sitecore running.
	/// </summary>
	public class MvcApplication : Sitecore.Web.Application
	{
		protected void Application_Start()
		{
			// Because Zodiac uses Areas for Project-level components and Presentation from Features, you must register Areas.
			AreaRegistration.RegisterAllAreas();

			// Load RouteConfig from App_Start
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}
