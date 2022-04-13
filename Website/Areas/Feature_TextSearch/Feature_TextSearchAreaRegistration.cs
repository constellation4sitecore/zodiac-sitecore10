using System.Web.Mvc;

namespace Website.Areas.Feature_TextSearch
{
	public class Feature_TextSearchAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_TextSearch";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			// Sitecore doesn't need this.

			//context.MapRoute(
			//    "Feature_TextSearch_default",
			//    "Feature_TextSearch/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}