using APII.Entities;
using Microsoft.EntityFrameworkCore;

namespace APII.Data;
public class DataContext : DbContext
{

public DataContext(DbContextOptions options) : base(options)
{

}

public DbSet<AppUser> Users {get; set;}

}