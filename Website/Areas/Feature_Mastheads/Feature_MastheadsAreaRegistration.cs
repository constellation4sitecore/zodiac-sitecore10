using System.Web.Mvc;

namespace Website.Areas.Feature_Mastheads
{
	public class Feature_MastheadsAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_Mastheads";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			// Sitecore doesn't need this.
			//context.MapRoute(
			//    "Feature_Mastheads_default",
			//    "Feature_Mastheads/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}