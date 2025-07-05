using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentProject> StudentProjects { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>()
            .HasIndex(p => p.ProjectName)
            .IsUnique();

        modelBuilder.Entity<StudentProject>()
            .HasKey(sp => new { sp.StudentId, sp.ProjectId });

        modelBuilder.Entity<StudentProject>()
            .HasOne(sp => sp.Student)
            .WithMany(s => s.StudentProjects)
            .HasForeignKey(sp => sp.StudentId);

        modelBuilder.Entity<StudentProject>()
            .HasOne(sp => sp.Project)
            .WithMany(p => p.StudentProjects)
            .HasForeignKey(sp => sp.ProjectId);
    }
} 