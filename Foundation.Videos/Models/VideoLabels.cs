using Constellation.Foundation.Labels;
using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Foundation.Videos.Models
{
	[Label("{B23D8DCD-3C00-4315-9965-975B9F2E9173}")]
	public class VideoLabels
	{
		[RawValueOnly]
		public string PlayVideo { get; set; }

		[RawValueOnly]
		public string Play { get; set; }

		[RawValueOnly]
		public string Stop { get; set; }

		[RawValueOnly]
		public string Pause { get; set; }

		[RawValueOnly]
		public string Reverse { get; set; }

		[RawValueOnly]
		public string Forward { get; set; }

		[RawValueOnly]
		public string Transcript { get; set; }
	}
}
