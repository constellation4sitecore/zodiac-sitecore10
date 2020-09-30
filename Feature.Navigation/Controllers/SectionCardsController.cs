using Constellation.Foundation.Mvc;
using Feature.Navigation.Repositories;
using Sitecore.Data.Items;

namespace Feature.Navigation.Controllers
{
	public class SectionCardsController : ConventionController
	{
		public SectionCardsController(SectionCardRepository repository, IViewPathResolver viewPathResolver) : base(viewPathResolver)
		{
			Repository = repository;
		}

		protected SectionCardRepository Repository { get; }

		protected override object GetModel(Item datasource, Item contextItem)
		{
			var item = datasource; // This allows the user to specify which Item to query for members.

			if (item == null)
			{
				item = contextItem;
			}

			return Repository.GetModel(item);
		}
	}
}
