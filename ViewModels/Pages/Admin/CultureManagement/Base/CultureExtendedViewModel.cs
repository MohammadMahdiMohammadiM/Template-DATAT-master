namespace ViewModels.Pages.Admin.CultureManagement.Base
{
    public class CultureExtendedViewModel : CultureBaseViewModel
    {
        public CultureExtendedViewModel() : base()  
        {
        }

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = nameof(Resources.DataDictionary.IsActive),
			ResourceType = typeof(Resources.DataDictionary))]
		public bool IsActive { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = nameof(Resources.DataDictionary.IsDeletable),
			ResourceType = typeof(Resources.DataDictionary))]
		public bool IsDeletable { get; set; }
		// **********
	}
}
