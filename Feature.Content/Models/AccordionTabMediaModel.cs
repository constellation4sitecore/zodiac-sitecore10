using Constellation.Foundation.ModelMapping.FieldModels;
using Constellation.Foundation.ModelMapping.MappingAttributes;
using Foundation.Videos.Models;

namespace Feature.Content.Models
{
	public class AccordionTabMediaModel
	{
		public ImageModel TabImage { get; set; }

		[RawValueOnly]
		// ReSharper disable once InconsistentNaming
		public string VideoID { get; set; }

		public VideoProviderSettingModel VideoProvider { get; set; }
	}
}
