using System.Web.Mvc;

namespace Website.Areas.Feature_Navigation
{
	public class Feature_NavigationAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_Navigation";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			//context.MapRoute(
			//    "Feature_Navigation_default",
			//    "Feature_Navigation/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}