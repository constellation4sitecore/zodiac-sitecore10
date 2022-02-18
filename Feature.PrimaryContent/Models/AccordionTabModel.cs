using System.Web;

namespace Feature.PrimaryContent.Models
{
	public class AccordionTabModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString Subheading { get; set; }

		public HtmlString Copy { get; set; }

		public bool Expanded { get; set; }
	}
}
