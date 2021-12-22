using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Feature.Mastheads.Models;
using Sitecore.Data.Items;

namespace Feature.Mastheads.Controllers
{
	public class MastheadWithBackgroundController : ConventionController
	{
		public MastheadWithBackgroundController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver)
		{
			ModelMapper = modelMapper;
		}

		protected IModelMapper ModelMapper { get; }

		protected override object GetModel(Item datasource, Item contextItem)
		{
			// get the Masthead fields off the Context Item
			var model = ModelMapper.MapItemToNew<MastheadWithBackgroundModel>(contextItem);

			// get the Media fields off of the Datasource
			ModelMapper.MapTo(datasource, model);

			return model;
		}
	}
}
