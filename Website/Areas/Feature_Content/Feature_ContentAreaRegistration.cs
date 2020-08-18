using System.Web.Mvc;

namespace Website.Areas.Feature_Content
{
	public class Feature_ContentAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_Content";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			//context.MapRoute(
			//    "Feature_Content_default",
			//    "Feature_Content/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}