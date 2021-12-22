using Constellation.Foundation.ModelMapping.MappingAttributes;
using Sitecore.Data;

namespace Feature.Mastheads.Models
{
	public class VideoProviderSetting
	{
		public ID ID { get; set; }

		public string Name { get; set; }

		public string DisplayName { get; set; }

		[RawValueOnly]
		public string ProviderID { get; set; }
	}
}
