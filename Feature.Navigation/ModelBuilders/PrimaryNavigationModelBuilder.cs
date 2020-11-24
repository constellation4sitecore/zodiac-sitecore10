using Constellation.Feature.Navigation.Models;
using Constellation.Feature.Navigation.Repositories;
using Constellation.Foundation.Caching;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using System;

namespace Feature.Navigation.ModelBuilders
{
	public class PrimaryNavigationModelBuilder
	{
		#region Constructor
		public PrimaryNavigationModelBuilder(IDeclaredNavigationRepository repository, ICacheManager cache)
		{
			Repository = repository;
			Cache = cache;
		}
		#endregion

		#region Properties
		protected IDeclaredNavigationRepository Repository { get; }

		protected ICacheManager Cache { get; }
		#endregion

		public NavigationMenu GetModel(Item datasource, Item contextItem)
		{
			Assert.ArgumentNotNull(datasource, "datasource");
			Assert.ArgumentNotNull(contextItem, "contextItem");

			/* Rendering Datasource should be the root level Navigation Menu Item,
			 * example: sitecore/content/ExampleSite/Navigation/Primary
			 * We want to know which menu item to highlight, so we also have to pass in the Context Item.
			 *
			 * We can't cache this Item by Datasource, because we'll lose context highlighting, but we don't
			 * want to generate this model from scratch for every request, so we're going to cache it by the
			 * contextItem's ID
			 */

			var key = GetCacheKey(contextItem);

			var model = Cache.Get<NavigationMenu>(key);

			if (model == null)
			{
				model = Repository.GetNavigation(datasource, contextItem);

				Cache.Add(key, model, DateTime.Now.AddMinutes(Sitecore.Configuration.Settings.Caching.HtmlLifetime.TotalMinutes));
			}

			return model;
		}

		private string GetCacheKey(Item contextItem)
		{
			return this.GetType().FullName + contextItem.ID;
		}
	}
}