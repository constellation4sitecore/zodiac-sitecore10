using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.Content.Models
{
	public class CallToActionCardModel
	{
		public ImageModel ImageHeader { get; set; }

		public HtmlString Heading { get; set; }

		public HtmlString CardText { get; set; }

		public GeneralLinkModel ButtonLink { get; set; }
	}
}
