using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc.Patterns.Repositories;
using Feature.Alerts.Models;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Data.Query;
using Sitecore.Globalization;
using Sitecore.Web;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Feature.Alerts
{
	public class AlertRepository : IRepository
	{
		private IModelMapper ModelMapper { get; set; }

		public AlertRepository(IModelMapper modelMapper)
		{
			ModelMapper = modelMapper;
		}

		public IEnumerable<AlertModel> GetAlerts(Database database, Language language, SiteInfo site)
		{
			var xPath = GetAlertXpathSuffix();
			var alertItems = new List<Item>();

			var contextItem = database.GetItem(Constants.ContentPath, language);
			AddAlerts(contextItem, xPath, alertItems);

			contextItem = database.GetItem(site.RootPath, language);
			AddAlerts(contextItem, xPath, alertItems);

			var alerts = new List<AlertModel>();

			/*
			 * Normally I would use XPATH to get only date relevant Alerts, but the XPATH support for date
			 * parsing is fairly limited and going to ContentSearch poses similar issues. It would be
			 * exceptional for there to be more than a few Alerts to process at any one time, therefore
			 * looping through the Items after retrieving them from Sitecore is reasonable.
			 *
			 */

			foreach (var item in alertItems)
			{
				var alert = ModelMapper.MapItemToNew<AlertModel>(item);

				if (DateTime.Compare(alert.ValidFrom, DateTime.Now) <= 0 && DateTime.Compare(alert.ValidTo, DateTime.Now) > 0)
				{
					alerts.Add(alert);
				}
			}

			return alerts;
		}

		public static Item GetAlertFolderForSite(Database database, Language language, SiteInfo site)
		{
			var siteRoot = database.GetItem(site.RootPath, language);

			return Query.SelectSingleItem($"./{GetAlertRootFolderName()}", siteRoot);
		}

		private static string GetActiveAlertFolderName()
		{
			var activeAlertFolderName = Sitecore.Configuration.Settings.GetSetting(SettingNames.ActiveAlertFolderName);

			if (string.IsNullOrEmpty(activeAlertFolderName))
			{
				throw new ConfigurationErrorsException($"Feature.Alerts - Missing an XML setting value for {SettingNames.ActiveAlertFolderName} Alerts cannot be resolved without this value.");
			}

			return activeAlertFolderName;
		}

		private static string GetAlertRootFolderName()
		{
			var alertRootFolderName = Sitecore.Configuration.Settings.GetSetting(SettingNames.AlertRootFolderName);

			if (string.IsNullOrEmpty(alertRootFolderName))
			{
				throw new ConfigurationErrorsException($"Feature.Alerts - Missing an XML setting value for {SettingNames.AlertRootFolderName} Alerts cannot be resolved without this value.");
			}

			return alertRootFolderName;
		}

		private static string GetAlertXpathSuffix()
		{
			return $"./{GetAlertRootFolderName()}/{GetActiveAlertFolderName()}/*";
		}

		private void AddAlerts(Item contextItem, string xPath, List<Item> list)
		{
			var items = Query.SelectItems(xPath, contextItem);

			if (items != null && items.Length > 0)
			{
				list.AddRange(items);
			}
		}
	}
}
