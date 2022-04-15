using Sitecore.Data.Items;
using Sitecore.Layouts;
using Sitecore.Pipelines.ExecutePageEditorAction;

namespace Feature.Client.Pipelines
{
	public class ReplaceRenderingWithDynamicPlaceholders : ReplaceRendering
	{
		protected override RenderingDefinition DoReplaceRendering(
			RenderingDefinition sourceRendering,
			Item targetRenderingItem,
			DeviceDefinition device)
		{
			// Preserve the UID of the original rendering so that dynamic placeholders will continue to work
			var rendering = base.DoReplaceRendering(sourceRendering, targetRenderingItem, device);
			rendering.UniqueId = sourceRendering.UniqueId;
			return rendering;
		}
	}
}
