using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Website.Areas.Feature_Content.Models;

namespace Website.Areas.Feature_Content.Controllers
{
	public class ContextContentController : DatasourceRenderingController<ContextContentModel>
	{
		public ContextContentController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
