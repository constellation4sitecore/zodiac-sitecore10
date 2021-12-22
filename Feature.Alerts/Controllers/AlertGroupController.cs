using Constellation.Foundation.Mvc;
using Sitecore.Data.Items;

namespace Feature.Alerts.Controllers
{
	public class AlertGroupController : ConventionController
	{
		public AlertGroupController(IViewPathResolver viewPathResolver, AlertRepository repository) : base(viewPathResolver)
		{
			Repository = repository;
		}

		protected AlertRepository Repository { get; }

		protected override object GetModel(Item datasource, Item contextItem)
		{
			return Repository.GetAlerts(datasource.Database, datasource.Language, Sitecore.Context.Site.SiteInfo);
		}
	}
}
