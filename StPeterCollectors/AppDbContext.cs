using StPeterCollectors.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<sp_collectors_main> sp_collectors_main { get; set; }

    public DbSet<sp_total_all> sp_total_all { get; set; }
    public object Collectors { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=db_stPeter.db"); // SQLite database file
    }
}