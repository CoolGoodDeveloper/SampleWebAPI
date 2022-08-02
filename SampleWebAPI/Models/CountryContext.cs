using Microsoft.EntityFrameworkCore;

namespace SampleWebAPI.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        {
        }

        public DbSet<Country> CountryList { get; set; } = null!;
    }
}
