using Constellation.Foundation.ModelMapping.MappingAttributes;
using System.Web;

namespace Feature.Content.Models
{
	public class ContentSectionModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString Copy { get; set; }

		[FieldRendererParams("class=btn btn-primary")]
		public HtmlString TrailingLink { get; set; }

		public string TrailingLinkUrl { get; set; }

		public string TrailingLinkText { get; set; }

		public string TrailingLinkTarget { get; set; }
	}
}
