using System.Web.Mvc;

namespace Feature.Alerts.Controllers
{
	public class JsonAlertGroupController : Controller
	{
		public JsonAlertGroupController(AlertRepository repository)
		{
			Repository = repository;
		}

		protected AlertRepository Repository { get; }

		public JsonResult Index()
		{
			var model = Repository.GetAlerts(Sitecore.Context.Database, Sitecore.Context.Language, Sitecore.Context.Site.SiteInfo);

			return Json(model, JsonRequestBehavior.AllowGet);
		}
	}
}
