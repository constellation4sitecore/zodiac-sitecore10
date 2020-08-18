using System.Web.Mvc;

namespace Website.Areas.ZodiacManual
{
    public class ZodiacManualAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ZodiacManual";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            // Not needed by Sitecore

            //context.MapRoute(
            //    "ZodiacManual_default",
            //    "ZodiacManual/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}