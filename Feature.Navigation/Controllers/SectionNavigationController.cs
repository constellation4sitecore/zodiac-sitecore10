using Constellation.Feature.Navigation.Repositories;
using Constellation.Foundation.Mvc;
using Sitecore.Data.Items;

namespace Feature.Navigation.Controllers
{
	public class SectionNavigationController : ConventionController
	{
		public SectionNavigationController(IViewPathResolver viewPathResolver, IBranchNavigationRepository repository) : base(viewPathResolver)
		{
			Repository = repository;
		}

		protected IBranchNavigationRepository Repository { get; }

		protected override object GetModel(Item datasource, Item contextItem)
		{
			var startItem = datasource; // allows for manual configuration of the navigation on a deep page that otherwise would not route correctly.

			if (datasource == null)
			{
				startItem = contextItem;
			}

			return Repository.GetNavigation(startItem);
		}
	}
}
