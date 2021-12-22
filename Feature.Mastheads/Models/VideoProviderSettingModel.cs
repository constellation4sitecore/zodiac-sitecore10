using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Feature.Mastheads.Models
{
	public class VideoProviderSettingModel
	{
		public string DisplayName { get; set; }

		[RawValueOnly]
		public string ProviderID { get; set; }
	}
}
