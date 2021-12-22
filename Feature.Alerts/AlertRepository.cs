using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc.Patterns.Repositories;
using Feature.Alerts.Models;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Data.Query;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.Web;
using System.Collections.Generic;

namespace Feature.Alerts
{
	public class AlertRepository : IRepository
	{
		private static readonly string AlertPathShort = "./{0}/{1}*";

		private IModelMapper ModelMapper { get; set; }

		public AlertRepository(IModelMapper modelMapper)
		{
			ModelMapper = modelMapper;
		}

		public IEnumerable<AlertModel> GetAlerts(Database database, Language language, SiteInfo site)
		{
			var pathMask = AlertPathShort;

			var alertRootFolderName = Sitecore.Configuration.Settings.GetSetting(SettingNames.AlertRootFolderName);

			if (string.IsNullOrEmpty(alertRootFolderName))
			{
				Log.Warn($"Feature.Alerts - Missing an XML setting value for {SettingNames.AlertRootFolderName} Alerts cannot be resolved without this value.", typeof(AlertRepository));
				return null;
			}

			var activeAlertFolderName = Sitecore.Configuration.Settings.GetSetting(SettingNames.ActiveAlertFolderName);

			if (string.IsNullOrEmpty(activeAlertFolderName))
			{
				Log.Warn($"Feature.Alerts - Missing an XML setting value for {SettingNames.ActiveAlertFolderName} Alerts cannot be resolved without this value.", typeof(AlertRepository));
				return null;
			}

			var xPath = string.Format(pathMask, alertRootFolderName, activeAlertFolderName);
			var alertItems = new List<Item>();

			var contentItem = database.GetItem(Constants.ContentPath, language);
			alertItems.AddRange(Query.SelectItems(xPath, contentItem));

			var startItemPath = $"{site.RootPath}";
			var startItem = database.GetItem(startItemPath, language);
			alertItems.AddRange(Query.SelectItems(xPath, startItem));

			return ModelMapper.MapToEnumerableOf<AlertModel>(alertItems);
		}
	}
}
