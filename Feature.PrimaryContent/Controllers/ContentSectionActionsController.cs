using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.PrimaryContent.Models;

namespace Feature.PrimaryContent.Controllers
{
	public class ContentSectionActionsController : DatasourceRenderingController<ContentSectionActionsModel>
	{
		public ContentSectionActionsController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
