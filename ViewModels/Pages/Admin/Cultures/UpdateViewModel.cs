namespace ViewModels.Pages.Admin.CultureManagement;

public class UpdateViewModel : IndexItemViewModel
{
	public UpdateViewModel() : base()
	{
	}

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.IsDeletable),
        ResourceType = typeof(Resources.DataDictionary))]
    public bool IsDeletable { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.Description),
        ResourceType = typeof(Resources.DataDictionary))]

    [System.ComponentModel.DataAnnotations.DataType
        (System.ComponentModel.DataAnnotations.DataType.MultilineText)]
    public string? Description { get; set; }
    // **********
}
