using Constellation.Foundation.ModelMapping.MappingAttributes;
using System.Web;

namespace Feature.Alerts.Models
{
	public class AlertModel
	{
		[RawValueOnly]
		public HtmlString Heading { get; set; }

		[RawValueOnly]
		public HtmlString Message { get; set; }

		public bool LoadExpanded { get; set; }

		public bool CanBeDismissed { get; set; }

		public AlertTypeModel AlertType { get; set; }
	}
}
