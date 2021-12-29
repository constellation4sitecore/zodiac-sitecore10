using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.PrimaryContent.Models;

namespace Feature.PrimaryContent.Controllers
{
	public class ContentSectionMediaController : DatasourceRenderingController<ContentSectionMediaModel>
	{
		public ContentSectionMediaController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
