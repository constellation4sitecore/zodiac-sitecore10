using System.Web.Mvc;

namespace Website.Areas.Feature_Testimonials
{
	public class Feature_TestimonialsAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Feature_Testimonials";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			// Sitecore doesn't need this

			//context.MapRoute(
			//    "Feature_Testimonials_default",
			//    "Feature_Testimonials/{controller}/{action}/{id}",
			//    new { action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}