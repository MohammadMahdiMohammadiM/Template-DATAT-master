namespace Infrastructure.Settings
{
	public class CultureManagementSettings : object
	{
		public CultureManagementSettings() : base()
		{
			DisplayDateTimeFormat = "yyyy/MM/dd [HH:mm:ss]";

			TableHeaderStyle = "table-primary";
			TableFooterStyle = "table-warning";
			TableStyle = "table table-bordered table-sm table-striped table-hover";
		}

		//// **********
		//public string ActivatedCulture { get; set; }
		//// **********

		//// **********
		//public bool DefaultCulture { get; set; }
		//// **********

		// **********
		public string TableStyle { get; set; }
		// **********

		// **********
		public string TableHeaderStyle { get; set; }
		// **********

		// **********
		public string TableFooterStyle { get; set; }
		// **********

		// **********
		public string DisplayDateTimeFormat { get; set; }
		// **********

		// **********
		public string? NoIcon { get; set; }
		// **********

		// **********
		public string? YesIcon { get; set; }
		// **********

		// **********
		public string? NextPageIcon { get; set; }
		// **********

		// **********
		public string? PreviousPageIcon { get; set; }
		// **********
	}
}
