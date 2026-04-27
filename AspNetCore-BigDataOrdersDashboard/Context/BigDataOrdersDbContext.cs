using AspNetCore_BigDataOrdersDashboard.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_BigDataOrdersDashboard.Context
{
    public class BigDataOrdersDbContext:DbContext
    {
        public BigDataOrdersDbContext(DbContextOptions<BigDataOrdersDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}
