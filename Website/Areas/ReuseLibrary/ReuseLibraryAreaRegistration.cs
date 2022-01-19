using System.Web.Mvc;

namespace Website.Areas.ReuseLibrary
{
	public class ReuseLibraryAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "ReuseLibrary";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			// Sitecore doesn't need this.

			//context.MapRoute(
			//    "ReuseLibrary_default",
			//    "ReuseLibrary/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}