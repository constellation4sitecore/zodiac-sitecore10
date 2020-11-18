using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.Content.Models
{
	public class ContentSectionModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString Copy { get; set; }

		public GeneralLinkModel TrailingLink { get; set; }
	}
}
