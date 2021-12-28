using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.RelatedContent.Models
{
	public class CallToActionRowWithBackgroundImageModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString Copy { get; set; }

		public GeneralLinkModel Link { get; set; }

		public ImageModel RowBackgroundImage { get; set; }
	}
}
