using Constellation.Foundation.ModelMapping.FieldModels;
using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Feature.Mastheads.Models
{
	public class MastheadMediaModel
	{
		public ImageModel MastheadBackground { get; set; }

		public ImageModel MastheadImage { get; set; }

		[RawValueOnly]
		public string VideoID { get; set; }

		public VideoProviderSettingModel VideoProvider { get; set; }
	}
}
