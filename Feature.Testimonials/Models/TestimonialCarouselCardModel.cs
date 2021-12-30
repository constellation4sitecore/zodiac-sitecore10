using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.Testimonials.Models
{
	public class TestimonialCarouselCardModel
	{
		public ImageModel Thumbnail { get; set; }

		public HtmlString FullName { get; set; }

		public HtmlString Title { get; set; }

		public HtmlString Quote { get; set; }
	}
}
