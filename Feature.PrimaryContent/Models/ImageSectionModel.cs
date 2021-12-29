using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.PrimaryContent.Models
{
	public class ImageSectionModel
	{
		public HtmlString Heading { get; set; }

		public ImageModel SectionImage { get; set; }

		public HtmlString Caption { get; set; }
	}
}
