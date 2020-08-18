using System;

namespace Foundation.Labels
{
	/// <summary>
	/// 
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class LabelAttribute : Attribute
	{
		/// <summary>
		/// Gets or sets the ID of the Item that can be mapped to the annotated class.
		/// </summary>
		public string DatasourceID { get; set; }

		/// <summary>
		/// Gets or sets the ID of the template item that can be mapped to the annotated class.
		/// </summary>
		public string TemplateID { get; set; }
	}
}
