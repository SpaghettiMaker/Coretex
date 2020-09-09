using Microsoft.EntityFrameworkCore;
using Coretex.Models;

namespace Coretex.Data
{
    public class CoretexContext : DbContext
    {
        public CoretexContext(DbContextOptions<CoretexContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}