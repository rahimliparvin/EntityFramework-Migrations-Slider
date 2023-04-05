using Microsoft.EntityFrameworkCore;
using SophiaFronttoBack.Models;

namespace SophiaFronttoBack.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

    }
}
