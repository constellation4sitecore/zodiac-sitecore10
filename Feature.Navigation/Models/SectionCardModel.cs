using Constellation.Foundation.ModelMapping.MappingAttributes;
using System.Web;

namespace Feature.Navigation.Models
{
	public class SectionCardModel
	{
		[RawValueOnly]
		public HtmlString NavigationTitle { get; set; }

		[RawValueOnly]
		public HtmlString MetaDescription { get; set; }

		public string Url { get; set; }
	}
}
