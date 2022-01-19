using Constellation.Foundation.ModelMapping.FieldModels;
using Constellation.Foundation.ModelMapping.MappingAttributes;
using Foundation.Videos.Models;

namespace Feature.PrimaryContent.Models
{
	public class ContentRowMediaModel
	{
		public ImageModel SectionImage { get; set; }

		[RawValueOnly]
		// ReSharper disable once InconsistentNaming
		public string VideoID { get; set; }

		public VideoProviderSettingModel VideoProvider { get; set; }
	}
}
