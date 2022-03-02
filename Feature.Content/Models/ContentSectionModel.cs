using Constellation.Foundation.ModelMapping.FieldModels;
using System;
using System.Web;

namespace Feature.Content.Models
{
	[Obsolete("Use Feature.PrimaryContent.Models.ContentRowModel instead.")]
	public class ContentSectionModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString Copy { get; set; }

		public GeneralLinkModel TrailingLink { get; set; }
	}
}
