using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace Website.Pipelines
{
	public class LoadRoutes
	{
		public void Process(PipelineArgs args)
		{
			//Register Custom Routes
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			MvcHandler.DisableMvcResponseHeader = true;
		}
	}
}