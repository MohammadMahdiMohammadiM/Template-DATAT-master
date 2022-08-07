namespace ViewModels.Pages.Admin.CultureManagement
{
    public class UpdateRoleViewModel : Base.CultureExtendedViewModel
    {
        public UpdateRoleViewModel() : base()
        {
        }

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = nameof(Resources.DataDictionary.Description),
			ResourceType = typeof(Resources.DataDictionary))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Domain.Culture.DescriptionMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string? Description { get; set; }
		// **********
	}
}
