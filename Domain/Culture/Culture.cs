namespace Domain
{
    public class Culture : SeedWork.Entity,
        SeedWork.IEntityHasIsActive, SeedWork.IEntityHasUpdateDateTime, SeedWork.IEntityHasIsDeletable
    {
        public const byte NameMaxLength = 20;
        public const byte DescriptionMaxLength = 100;
        public Culture() : base()
        {
            IsActive = true;
            IsDefault = true;
            Cultures = new System.Collections.Generic.List<Culture>();
        }

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

        // **********
        [System.ComponentModel.DataAnnotations.Display
            (Name = nameof(Resources.DataDictionary.IsDeleted),
            ResourceType = typeof(Resources.DataDictionary))]
        public bool IsDeleted { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Display
            (Name = nameof(Resources.DataDictionary.IsDeletable),
            ResourceType = typeof(Resources.DataDictionary))]
        public bool IsDeletable { get; set; }
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
        public virtual System.Collections.Generic.IList<Culture> Cultures { get; set; }
        // **********


        // **********
        [System.ComponentModel.DataAnnotations.Display
            (Name = nameof(Resources.DataDictionary.UpdateDateTime),
            ResourceType = typeof(Resources.DataDictionary))]
        public System.DateTime? UpdateDateTime { get; private set; }
        // **********

        public void SetUpdateDateTime()
        {
            UpdateDateTime = SeedWork.Utility.Now;
        }


    }
}
