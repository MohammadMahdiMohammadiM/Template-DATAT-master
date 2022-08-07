using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations.Culture
{
    internal class CultureConfiguration :
        object, Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Culture>
    {
        public CultureConfiguration() : base()
        {
        }

        public void Configure
            (Microsoft.EntityFrameworkCore.Metadata
            .Builders.EntityTypeBuilder<Domain.Culture> builder)
        {
        }
    }
}
