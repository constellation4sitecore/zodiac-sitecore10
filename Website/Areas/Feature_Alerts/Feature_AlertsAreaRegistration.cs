using System.Web.Mvc;

namespace Website.Areas.Feature_Alerts
{
	public class Feature_AlertsAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_Alerts";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			// Sitecore doesn't need this.

			//context.MapRoute(
			//    "Feature_Alerts_default",
			//    "Feature_Alerts/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}