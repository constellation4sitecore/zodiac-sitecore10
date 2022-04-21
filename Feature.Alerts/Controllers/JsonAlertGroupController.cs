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

		public ActionResult Index()
		{
			// Measure to prevent this controller from crashing when accessed out of context.
			if (Sitecore.Context.Database == null || Sitecore.Context.Language == null || Sitecore.Context.Site == null)
			{
				return new EmptyResult();
			}

			var model = Repository.GetAlerts(Sitecore.Context.Database, Sitecore.Context.Language, Sitecore.Context.Site.SiteInfo);

			return Json(model, JsonRequestBehavior.AllowGet);
		}
	}
}
