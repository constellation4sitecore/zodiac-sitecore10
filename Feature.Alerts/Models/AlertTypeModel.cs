using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Feature.Alerts.Models
{
	public class AlertTypeModel
	{
		[RawValueOnly]
		public string CssClass { get; set; }

		[RawValueOnly]
		public string DataId { get; set; }
	}
}
