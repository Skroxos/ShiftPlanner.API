using Microsoft.EntityFrameworkCore;
using ShiftsApi.Models;

namespace ShiftsApi.Data;

public class ShiftsDbContext : DbContext
{
    public ShiftsDbContext(DbContextOptions<ShiftsDbContext> options) : base(options)
    {
    }
    
    public DbSet<Nurse> Nurses { get; set; }
    public DbSet<Shift> Shifts { get; set; }
}