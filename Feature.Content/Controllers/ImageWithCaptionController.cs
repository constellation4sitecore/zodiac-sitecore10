using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.Content.Models;
using System;

namespace Feature.Content.Controllers
{
	[Obsolete("This component will be retired in favor of a similar component in Feature.PrimaryContent")]
	public class ImageWithCaptionController : DatasourceRenderingController<ImageWithCaptionModel>
	{
		public ImageWithCaptionController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
