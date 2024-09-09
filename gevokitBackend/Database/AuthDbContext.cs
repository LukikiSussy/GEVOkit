namespace gevokitBackend.Database;

using gevokitBackend.Database.Classes;
using Microsoft.EntityFrameworkCore;

public class AuthDbContext : DbContext
{

    public DbSet<Student> Students { get; set; }

    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Student>(entity => {
            entity.HasKey(e => e.StudentId);
            entity.Property(e => e.StudentId);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Surename).HasMaxLength(20);
            entity.Property(e => e.Class).HasDefaultValue("1").HasMaxLength(5);
            //entity.Property(e => e.Grades).HasMaxLength(5);
            entity.Property(e => e.Ints).HasDefaultValue(new []{5, 2, 2, 2});
            entity.Property(e => e.Email).HasMaxLength(50);

            entity.HasData(new Student {
                StudentId = 1,
                Name = "SussyBaka",
                Surename = "Test",
                Email = "Sussybaka.test@gaymail.com"
            });
        });
    }

}