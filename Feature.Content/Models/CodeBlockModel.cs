using Constellation.Foundation.ModelMapping.MappingAttributes;
using System;
using System.Web;

namespace Feature.Content.Models
{
	[Obsolete("This component will be retired in favor of a similar component in Feature.PrimaryContent")]
	public class CodeBlockModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString HeaderText { get; set; }

		[RawValueOnly]
		public string CodeText { get; set; }

		public HtmlString FooterText { get; set; }
	}
}
