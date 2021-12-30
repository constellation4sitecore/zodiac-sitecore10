using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.RelatedContent.Models
{
	public class CallToActionModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString Copy { get; set; }

		public GeneralLinkModel Link { get; set; }

		public ImageModel BackgroundImage { get; set; }

		public ImageModel ThumbnailImage { get; set; }
	}
}
