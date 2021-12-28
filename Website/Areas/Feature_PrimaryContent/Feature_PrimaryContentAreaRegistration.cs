using System.Web.Mvc;

namespace Website.Areas.Feature_PrimaryContent
{
	public class Feature_PrimaryContentAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_PrimaryContent";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			// Sitecore does not need this.

			//context.MapRoute(
			//    "Feature_PrimaryContent_default",
			//    "Feature_PrimaryContent/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}