using Constellation.Foundation.ModelMapping.MappingAttributes;
using Sitecore.Data;

namespace Feature.Alerts.Models
{
	public class AlertTypeModel
	{
		public ID ID { get; set; }

		public string DisplayName { get; set; }

		[RawValueOnly]
		public string CssClass { get; set; }

		[RawValueOnly]
		public string DataId { get; set; }
	}
}
