using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.Mastheads.Models;

namespace Feature.Mastheads.Controllers
{
	public class MastheadMediaController : DatasourceRenderingController<MastheadMediaModel>
	{
		public MastheadMediaController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
