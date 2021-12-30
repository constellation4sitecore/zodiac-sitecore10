using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.RelatedContent.Models;

namespace Feature.RelatedContent.Controllers
{
	public class CallToActionController : DatasourceRenderingController<CallToActionModel>
	{
		public CallToActionController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
