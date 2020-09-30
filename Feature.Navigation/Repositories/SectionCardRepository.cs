using Constellation.Foundation.Data;
using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc.Patterns.Repositories;
using Feature.Navigation.Models;
using Sitecore.Data;
using Sitecore.Data.Items;
using System.Collections.Generic;

namespace Feature.Navigation.Repositories
{
	public class SectionCardRepository : IRepository
	{
		private readonly ID SectionCardTemplateID = new ID("{6D282D8E-41CA-4288-820D-92DF9767C3E0}");

		public SectionCardRepository(IModelMapper modelMapper)
		{
			ModelMapper = modelMapper;
		}

		protected IModelMapper ModelMapper { get; }

		public IEnumerable<SectionCardModel> GetModel(Item contextItem)
		{
			var children = contextItem.GetChildren();
			var output = new List<SectionCardModel>();

			foreach (Item child in children)
			{
				if (child.IsDerivedFrom(SectionCardTemplateID))
				{
					output.Add(ModelMapper.MapItemToNew<SectionCardModel>(child));
				}
			}

			return output;
		}

	}
}
