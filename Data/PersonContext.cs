using Microsoft.EntityFrameworkCore;
using Person.Models;

namespace Person.Data;

public class PersonContext : DbContext
{
    public DbSet<PersonModel> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Person.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}