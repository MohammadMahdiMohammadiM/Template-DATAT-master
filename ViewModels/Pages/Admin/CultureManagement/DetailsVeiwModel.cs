namespace ViewModels.Pages.Admin.CultureManagement;

public class DetailsVeiwModel
{
	public DetailsVeiwModel() : base()
	{
	}

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resources.DataDictionary),
        Name = nameof(Resources.DataDictionary.Id))]

    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
        (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
    public System.Guid Id { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.Name),
        ResourceType = typeof(Resources.DataDictionary))]
    public string? Name { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.Description),
        ResourceType = typeof(Resources.DataDictionary))]
    public string? Description { get; set; }
    // **********

    //// **********
    //[System.ComponentModel.DataAnnotations.Display
    //    (Name = nameof(Resources.DataDictionary.IsDeletable),
    //    ResourceType = typeof(Resources.DataDictionary))]
    //public bool IsDeletable { get; set; }
    //// **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.IsActive),
        ResourceType = typeof(Resources.DataDictionary))]
    public bool IsActive { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.IsDefault),
        ResourceType = typeof(Resources.DataDictionary))]
    public bool IsDefault { get; set; }
    // **********

    //// **********
    //[System.ComponentModel.DataAnnotations.Display
    //    (Name = nameof(Resources.DataDictionary.Flag),
    //    ResourceType = typeof(Resources.DataDictionary))]
    //public string? Flag { get; set; }
    //// **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resources.DataDictionary),
        Name = nameof(Resources.DataDictionary.InsertDateTime))]
    public System.DateTime InsertDateTime { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resources.DataDictionary),
        Name = nameof(Resources.DataDictionary.UpdateDateTime))]
    public System.DateTime UpdateDateTime { get; set; }
    // **********
}
