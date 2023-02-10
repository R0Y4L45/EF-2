using EntityFrameWork_Hw2.Configuration;
using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Context;

public class ContexApp:DbContext
{
#nullable disable
    public DbSet<Authors> Authors { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Departments> Departments { get; set; }
    public DbSet<Faculties> Faculties { get; set; }
    public DbSet<Groups> Groups { get; set; }
    public DbSet<Libs> Libs { get; set; }
    public DbSet<Press> Press { get; set; }
    public DbSet<S_Cards> S_Cards { get; set; }
    public DbSet<Students> Students { get; set; }
    public DbSet<T_Cards> T_Cards { get; set; }
    public DbSet<Teachers> Teachers { get; set; }
    public DbSet<Themes> Themes { get; set; }

#nullable enable

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=R0Y4L;Initial Catalog=Bibliotheca;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BooksConfigure());
        modelBuilder.ApplyConfiguration(new GroupsConfigure());
        modelBuilder.ApplyConfiguration(new S_CardsConfigure());
        modelBuilder.ApplyConfiguration(new StudentsConfigure());
        modelBuilder.ApplyConfiguration(new T_CardsConfigure());
        modelBuilder.ApplyConfiguration(new TeachersConfigure());
    }
}
