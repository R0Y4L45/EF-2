using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EntityFrameWork_Hw2.Models;

namespace EntityFrameWork_Hw2.Configuration;

public class GroupsConfigure : IEntityTypeConfiguration<Groups>
{
    public void Configure(EntityTypeBuilder<Groups> builder)
    {
        builder.HasOne<Faculties>()
            .WithMany()
            .HasForeignKey(x => x.Id_Facultity);
    }
}

