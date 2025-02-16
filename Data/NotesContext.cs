using Microsoft.EntityFrameworkCore;
using NotesApp.Models;
namespace NotesApp.Data;

// Data/NotesContext.cs
public class NotesContext : DbContext
{
    public NotesContext(DbContextOptions<NotesContext> options)
        : base(options)
    {
    }

    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Note>()
            .Property(n => n.Title)
            .IsRequired()
            .HasMaxLength(200);

        modelBuilder.Entity<Note>()
            .Property(n => n.Content)
            .IsRequired();

        modelBuilder.Entity<Note>()
            .Property(n => n.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}
