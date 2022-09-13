namespace Data.Configurations.Culture;

internal class CultureConfiguration : object,
    Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Culture>
{
    public CultureConfiguration() : base()
    {
    }



    public void Configure
        (Microsoft.EntityFrameworkCore.Metadata
        .Builders.EntityTypeBuilder<Domain.Culture> builder)
    {
        //// **************************************************
        //// **************************************************
        var PersianCulture = new Domain.Culture(name: "fa-IR")
        {
            Flag = "ir",
            Ordering = 0,
            IsActive = true,
            IsDefault = true,
            IsSystemic = true,
            Description = null,
            IsDeletable = false,
        };

        PersianCulture.SetId(id: Domain.Culture.PersianDefaultId);

        builder.HasData(data: PersianCulture);
        //// **************************************************
        //// **************************************************


        //// **************************************************
        //// **************************************************
        var EnglishCulture = new Domain.Culture(name:"en-US")
        {
            Flag = "us",
            Ordering = 1,
            IsActive = true,
            IsDefault = false,
            IsSystemic = true,
            Description = null,
            IsDeletable = false,
        };

        EnglishCulture.SetId(id: Domain.Culture.EnglishDefaultId);

        builder.HasData(data: EnglishCulture);
        //// **************************************************
        //// **************************************************


        // **************************************************
        builder
            .HasIndex(current => new { current.Name })
            .IsUnique(unique: true)
            ;
        // **************************************************

        //// **************************************************
        //builder
        //    .Property(current => current.Flag)
        //    .HasMaxLength(maxLength: Domain.Culture.IconMaxLength)
        //    .IsRequired(required: false)
        //    .IsUnicode(unicode: false)
        //    ;
        //// **************************************************
    }
}
