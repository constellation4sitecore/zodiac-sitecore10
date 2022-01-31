using Constellation.Foundation.Labels;
using Constellation.Foundation.ModelMapping.MappingAttributes;

namespace Feature.Navigation.Models
{
	[Label("{0665CFD0-F4D3-43D9-9AF9-753342C65382}")]
	public class BreadcrumbLabels
	{
		[RawValueOnly]
		public string Breadcrumbs { get; set; }

		[RawValueOnly]
		public string Separator { get; set; }
	}
}
