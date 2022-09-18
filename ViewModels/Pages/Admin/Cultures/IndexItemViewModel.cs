namespace ViewModels.Pages.Admin.CultureManagement;

public class IndexItemViewModel : object
{
    public IndexItemViewModel() : base()
    {
        Name = string.Empty;
    }

    // **********
    public System.Guid Id { get; set; }
    // **********

    // **********
    public string Name { get; set; }
    // **********

    // **********
    public int Ordering { get; set; }
    // **********

    // **********
    public bool IsActive { get; set; }
    // **********

    // **********
    public bool IsDefault { get; set; }
    // **********

    // **********
    public bool IsSystemic { get; set; }
    // **********

    // **********
    public System.DateTime InsertDateTime { get; set; }
    // **********

    // **********
    public System.DateTime UpdateDateTime { get; set; }
    // **********

    // **********
    public string? Flag { get; set; }
    // **********

}
