using Constellation.Feature.Navigation.Repositories;
using Constellation.Foundation.Caching;
using Constellation.Foundation.Mvc;
using Feature.Navigation.ModelBuilders;
using Sitecore.Data.Items;

namespace Feature.Navigation.Controllers
{
	public class PrimaryNavigationController : ConventionController
	{
		#region Constructor
		public PrimaryNavigationController(IViewPathResolver viewPathResolver, IDeclaredNavigationRepository repository, ICacheManager cache) : base(viewPathResolver)
		{
			Repository = repository;
			Cache = cache;
		}
		#endregion

		#region Properties
		public IDeclaredNavigationRepository Repository { get; }

		public ICacheManager Cache { get; }
		#endregion

		protected override object GetModel(Item datasource, Item contextItem)
		{
			var builder = new PrimaryNavigationModelBuilder(Repository, Cache);

			return builder.GetModel(datasource, contextItem);
		}
	}
}