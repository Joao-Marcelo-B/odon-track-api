using Microsoft.EntityFrameworkCore;

namespace Odon.Track.Application.Data
{
    public class TesteContext : DbContext
    {
        public TesteContext(DbContextOptions<TesteContext> options) : base(options) { }

        public DbSet<TesteTable> TesteTables { get; set; }
    }
}
