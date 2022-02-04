using Constellation.Feature.Navigation.Repositories;
using Constellation.Foundation.Mvc;
using Sitecore.Data.Items;

namespace Feature.Navigation.Controllers
{
	public class BreadcrumbsController : ConventionController
	{
		public BreadcrumbsController(IViewPathResolver viewPathResolver, IBreadcrumbNavigationRepository repository) : base(viewPathResolver)
		{
			Repository = repository;
		}

		protected IBreadcrumbNavigationRepository Repository { get; }

		protected override object GetModel(Item datasource, Item contextItem)
		{
			return Repository.GetNavigation(contextItem, Sitecore.Context.Site.SiteInfo);
		}
	}
}
