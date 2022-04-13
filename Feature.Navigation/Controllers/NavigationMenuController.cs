using Constellation.Feature.Navigation.Repositories;
using Constellation.Foundation.Mvc;
using Sitecore.Data.Items;

namespace Feature.Navigation.Controllers
{
	public class NavigationMenuController : ConventionController
	{
		#region Constructor
		public NavigationMenuController(IViewPathResolver viewPathResolver, IDeclaredNavigationRepository repository) : base(viewPathResolver)
		{
			Repository = repository;
		}
		#endregion

		#region Properties
		public IDeclaredNavigationRepository Repository { get; }
		#endregion

		protected override object GetModel(Item datasource, Item contextItem)
		{
			return Repository.GetNavigation(datasource);
		}
	}
}