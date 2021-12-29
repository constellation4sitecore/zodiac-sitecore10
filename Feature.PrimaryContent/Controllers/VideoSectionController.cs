using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.PrimaryContent.Models;

namespace Feature.PrimaryContent.Controllers
{
	public class VideoSectionController : DatasourceRenderingController<VideoSectionModel>
	{
		public VideoSectionController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
