using Constellation.Foundation.Labels;
using Constellation.Foundation.ModelMapping.FieldModels;
using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Feature.Navigation.Models
{
	[Label("{F7224DA4-0626-43E6-9499-C6AA843B2BBB}")]
	public class HeaderLabels
	{
		public ImageModel Logo { get; set; }

		[RawValueOnly]
		public string CloseMenu { get; set; }

		[RawValueOnly]
		public string PrimaryNavigation { get; set; }

		[RawValueOnly]
		public string UtilityNavigation { get; set; }
	}
}
