using Constellation.Foundation.ModelMapping.FieldModels;
using Constellation.Foundation.ModelMapping.MappingAttributes;
using System.Web;

namespace Feature.Mastheads.Models
{
	public class MastheadWithBackgroundModel
	{
		public HtmlString Heading { get; set; }

		public HtmlString Subheading { get; set; }

		public HtmlString IntroText { get; set; }

		public ImageModel MastheadBackground { get; set; }

		[RawValueOnly]
		public string VideoID { get; set; }

		public VideoProviderSettingModel VideoProvider { get; set; }
	}
}
