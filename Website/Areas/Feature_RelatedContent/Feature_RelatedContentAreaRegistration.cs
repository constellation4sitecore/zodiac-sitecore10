using System.Web.Mvc;

namespace Website.Areas.Feature_RelatedContent
{
	public class Feature_RelatedContentAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_RelatedContent";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			//Sitecore doesn't need this.

			//context.MapRoute(
			//    "Feature_RelatedContent_default",
			//    "Feature_RelatedContent/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}