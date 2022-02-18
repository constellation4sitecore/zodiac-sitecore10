using Constellation.Foundation.ModelMapping.MappingAttributes;
using System;

namespace Feature.Alerts.Models
{
	public class AlertModel
	{
		[RawValueOnly]
		public string Heading { get; set; }

		[RawValueOnly]
		public string Message { get; set; }

		public bool LoadExpanded { get; set; }

		public bool CanBeDismissed { get; set; }

		public AlertTypeModel AlertType { get; set; }

		/// <summary>
		/// Do not display the alert if this value is in the future. Default value from Sitecore is DateTime.MinValue
		/// </summary>
		public DateTime ValidFrom { get; set; }


		private DateTime _validTo = DateTime.MaxValue;
		/// <summary>
		/// Do not display the alert if this value is in the past. Default value is DateTime.MaxValue.
		/// </summary>
		public DateTime ValidTo
		{
			get { return _validTo; }
			set
			{
				if (value > DateTime.MinValue)
				{
					_validTo = value;
				}
			}
		}
	}
}
