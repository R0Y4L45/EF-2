using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork_Hw2.Configuration;

public class S_CardsConfigure : IEntityTypeConfiguration<S_Cards>
{
    public void Configure(EntityTypeBuilder<S_Cards> builder)
    {
        builder.HasNoKey();

        builder.HasOne<Books>()
            .WithMany()
            .HasForeignKey(x => x.Id_Books);


        builder.HasOne<Students>()
            .WithMany()
            .HasForeignKey(x => x.Id_Student);


        builder.HasOne<Libs>()
            .WithMany()
            .HasForeignKey(x => x.Id_Lib);
    }
}
