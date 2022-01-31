using Constellation.Feature.Navigation.Repositories;
using Constellation.Foundation.Mvc;
using Sitecore.Data.Items;

namespace Feature.Navigation.Controllers
{
	public class BreadcrumbsController : ConventionController
	{
		public BreadcrumbsController(IViewPathResolver viewPathResolver, BreadcrumbNavigationRepository repository) : base(viewPathResolver)
		{
			Repository = repository;
		}

		protected BreadcrumbNavigationRepository Repository { get; }

		protected override object GetModel(Item datasource, Item contextItem)
		{
			return Repository.GetNavigation(contextItem, Sitecore.Context.Site.SiteInfo);
		}
	}
}
