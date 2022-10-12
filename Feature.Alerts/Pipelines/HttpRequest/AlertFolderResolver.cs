using Sitecore.Pipelines.HttpRequest;

namespace Feature.Alerts.Pipelines.HttpRequest
{
	/// <summary>
	/// Responds to requests for "/alerts" and sets the Context Item to an Item that can handle the request.
	/// Refer to Feature.Alerts.config in your webroot/App_Config/Includes/ folder for details as to when this
	/// processor will fire.
	/// </summary>
	public class AlertFolderResolver : Constellation.Foundation.Contexts.Pipelines.ContextSensitiveHttpRequestProcessor
	{
		protected override void Execute(HttpRequestArgs args)
		{
			if (!args.RequestUrl.AbsolutePath.EndsWith("/alerts"))
			{
				return; // not a request we need to handle.
			}

			if (Sitecore.Context.Item != null)
			{
				return; // not a request we need to handle.
			}

			if (Sitecore.Context.Language == null)
			{
				return; // not a request we can handle.
			}

			if (Sitecore.Context.Site == null)
			{
				return; // not a request we can handle.
			}

			/*
			 * We need to set the ContextItem to the Site's Alerts folder, which has an ItemController that will
			 * return a JSON response representing all active alerts.
			 */

			Sitecore.Context.Item = AlertRepository.GetAlertFolderForSite(Sitecore.Context.Database,
				Sitecore.Context.Language, Sitecore.Context.Site.SiteInfo);
		}

		protected override void Defer(HttpRequestArgs args)
		{
			// Nothing to do!
		}
	}
}
