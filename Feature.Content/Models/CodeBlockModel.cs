using Constellation.Foundation.ModelMapping.MappingAttributes;
using System.Web;

namespace Feature.Content.Models
{
	public class CodeBlockModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString HeaderText { get; set; }

		[RawValueOnly]
		public string CodeText { get; set; }

		public HtmlString FooterText { get; set; }
	}
}
