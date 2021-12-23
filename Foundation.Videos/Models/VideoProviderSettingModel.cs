using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Foundation.Videos.Models
{
	public class VideoProviderSettingModel
	{
		public string DisplayName { get; set; }

		[RawValueOnly]
		// ReSharper disable once InconsistentNaming
		public string ProviderID { get; set; }
	}
}
