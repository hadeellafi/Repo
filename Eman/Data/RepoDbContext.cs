using Eman.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eman.Data
{
    public class RepoDbContext: DbContext
    {
        public RepoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Owner> Owners { get; set; }


    }
}
