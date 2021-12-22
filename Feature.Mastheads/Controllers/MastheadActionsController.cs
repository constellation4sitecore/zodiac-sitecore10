using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.Mastheads.Models;

namespace Feature.Mastheads.Controllers
{
	public class MastheadActionsController : DatasourceRenderingController<MastheadActionsModel>
	{
		public MastheadActionsController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
