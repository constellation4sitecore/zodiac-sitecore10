using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.Content.Models;

namespace Feature.Content.Controllers
{
	public class CodeBlockController : DatasourceRenderingController<CodeBlockModel>
	{
		public CodeBlockController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
