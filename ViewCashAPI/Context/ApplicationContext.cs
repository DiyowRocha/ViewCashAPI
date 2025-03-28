using Microsoft.EntityFrameworkCore;
using ViewCashAPI.Models;

namespace ViewCashAPI.Context;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<CategoryModel> Categories { get; set; }
}