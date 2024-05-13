using HomeWork_Front_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork_Front_Back.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
    }
}
