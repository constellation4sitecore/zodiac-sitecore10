using Constellation.Foundation.ModelMapping.FieldModels;
using Constellation.Foundation.ModelMapping.MappingAttributes;
using Foundation.Videos.Models;
using System.Web;

namespace Feature.PrimaryContent.Models
{
	public class VideoRowModel
	{
		public HtmlString Heading { get; set; }

		public ImageModel SectionImage { get; set; }

		public HtmlString Caption { get; set; }

		[RawValueOnly]
		// ReSharper disable once InconsistentNaming
		public string VideoID { get; set; }

		public VideoProviderSettingModel VideoProvider { get; set; }
	}
}
