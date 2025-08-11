using Microsoft.EntityFrameworkCore;
using Progress.Domain.Entities;

namespace Progress.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<ProgressEntity> Progress { get; set; }
    }
}