using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.PrimaryContent.Models;

namespace Feature.PrimaryContent.Controllers
{
	public class AccordionTabContentController : DatasourceRenderingController<AccordionTabModel>
	{
		public AccordionTabContentController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
