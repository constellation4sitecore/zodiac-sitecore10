using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.RelatedContent.Models
{
	public class CallToActionCardModel
	{
		public ImageModel ThumbnailImage { get; set; }

		public HtmlString Heading { get; set; }

		public HtmlString Copy { get; set; }

		public GeneralLinkModel Link { get; set; }
	}
}
