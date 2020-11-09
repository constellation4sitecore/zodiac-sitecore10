using System.Web.Mvc;

namespace Website.Areas.MySiteCom
{
    public class MySiteComAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MySiteCom";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MySiteCom_default",
                "MySiteCom/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}