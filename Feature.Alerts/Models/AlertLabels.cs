using Constellation.Foundation.Labels;
using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Feature.Alerts.Models
{
	[Label("{CC7FE4AC-D639-4694-9510-7B498F6C4F3E}")]
	public class AlertLabels
	{
		[RawValueOnly]
		public string Hide { get; set; }

		[RawValueOnly]
		public string Show { get; set; }

		[RawValueOnly]
		public string Close { get; set; }
	}

}
