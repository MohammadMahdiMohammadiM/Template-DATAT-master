namespace Domain;

public class Culture :
    SeedWork.Entity,
    SeedWork.IEntityCanSetId,
    SeedWork.IEntityHasIsActive,
    SeedWork.IEntityHasIsSystemic,
    SeedWork.IEntityHasIsDeletable,
    SeedWork.IEntityHasUpdateDateTime
{
    #region Static Id
    public static readonly System.Guid
        PersianDefaultId = new(g: "FE0B59F9-8034-48B8-BCE9-283C644682AD");

    public static readonly System.Guid
        EnglishDefaultId = new(g: "0E5BC2DB-CF79-4399-8945-45C2BBFA5590");
    #endregion /Static Id

    public Culture(string name) : base()
    {
        Name = name;

        UpdateDateTime = InsertDateTime;

        //Cultures =
        //    new System.Collections.Generic.List<Culture>();
    }

    //// **********
    //[System.ComponentModel.DataAnnotations.Display
    //(ResourceType = typeof(Resources.DataDictionary),
    //Name = nameof(Resources.DataDictionary.Id))]
    //public  System.Guid? Id { get; set; }
    //// **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.Name),
        ResourceType = typeof(Resources.DataDictionary))]
    public string Name { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.IsSystemic),
        ResourceType = typeof(Resources.DataDictionary))]
    public bool IsSystemic { get; set; }
    // **********

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
    public string? Description { get; set; }
    // **********

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

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.Flag),
        ResourceType = typeof(Resources.DataDictionary))]
    public string? Flag { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (Name = nameof(Resources.DataDictionary.UpdateDateTime),
        ResourceType = typeof(Resources.DataDictionary))]
    public System.DateTime UpdateDateTime { get; private set; }
    // **********

    public void SetUpdateDateTime()
    {
        UpdateDateTime =
            Dtat.Utility.Now;
    }

    public void SetId(System.Guid id)
    {
        Id = id;
    }

    //// **********
    //public virtual System.Collections.Generic.IList<Culture> Cultures { get; private set; }
    //// **********
}
