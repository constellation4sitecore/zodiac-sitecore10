using System.Web.Mvc;

namespace Website.Areas.Feature_Timeline
{
	public class Feature_TimelineAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_Timeline";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			// Sitecore doesn't need this.

			//context.MapRoute(
			//    "Feature_Timeline_default",
			//    "Feature_Timeline/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}