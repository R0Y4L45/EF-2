using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameWork_Hw2.Configuration;

public class StudentsConfigure : IEntityTypeConfiguration<Students>
{
    public void Configure(EntityTypeBuilder<Students> builder)
    {

        builder.HasOne<Groups>()
            .WithMany()
            .HasForeignKey(x => x.Id_Group);

    }
}
