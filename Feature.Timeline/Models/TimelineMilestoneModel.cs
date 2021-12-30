using Constellation.Foundation.ModelMapping.FieldModels;
using System.Web;

namespace Feature.Timeline.Models
{
	public class TimelineMilestoneModel
	{
		public HtmlString MilestoneDate { get; set; }

		public HtmlString Heading { get; set; }

		public HtmlString Copy { get; set; }

		public ImageModel MilestoneImage { get; set; }
	}
}
