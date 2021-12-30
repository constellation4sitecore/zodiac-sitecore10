using Constellation.Foundation.Labels;
using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Feature.Timeline.Models
{
	[Label("{F82BBF8B-3EAE-4698-8CC4-9591F9B90050}")]
	public class TimelineLabels
	{
		[RawValueOnly]
		public string ShowMore { get; set; }

		[RawValueOnly]
		public string ShowLess { get; set; }
	}
}
