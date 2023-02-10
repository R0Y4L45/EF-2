using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork_Hw2.Configuration;

public class TeachersConfigure : IEntityTypeConfiguration<Teachers>
{
    public void Configure(EntityTypeBuilder<Teachers> builder)
    {        
        builder.HasOne<Departments>()
            .WithMany()
            .HasForeignKey(x => x.Id_Dep);
    }

}
