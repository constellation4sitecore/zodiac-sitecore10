using Constellation.Foundation.Labels;
using Constellation.Foundation.ModelMapping.MappingAttributes;
using System;


namespace Feature.Content.Models
{
	[Obsolete("This component will be retired in favor of a similar component in Feature.PrimaryContent")]
	[Label("{05D33548-D7A2-43D7-8214-01A97D178E7A}")]
	public class ImageWithCaptionLabels
	{
		[RawValueOnly]
		public string Expand { get; set; }

		[RawValueOnly]
		public string Close { get; set; }

		[RawValueOnly]
		public string ViewImageInNewTab { get; set; }
	}
}
