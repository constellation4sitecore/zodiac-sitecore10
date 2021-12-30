using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.Timeline.Models;

namespace Feature.Timeline.Controllers
{
	public class TimelineContainerController : DatasourceRenderingController<TimelineContainerModel>
	{
		public TimelineContainerController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
