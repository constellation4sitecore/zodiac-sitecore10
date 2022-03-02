using System;
using System.Web;

namespace Feature.Content.Models
{
	[Obsolete("Use Feature.PrimaryContent.Models.ContentRowModel instead.")]
	public class ContextContentModel
	{
		public HtmlString Heading { get; set; }
		public HtmlString IntroCopy { get; set; }
		public HtmlString Copy { get; set; }
	}
}