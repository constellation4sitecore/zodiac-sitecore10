using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Constellation.Foundation.Mvc.Patterns.Controllers;
using Feature.Testimonials.Models;

namespace Feature.Testimonials.Controllers
{
	public class TestimonialCarouselCardController : DatasourceRenderingController<TestimonialCarouselCardModel>
	{
		public TestimonialCarouselCardController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}
