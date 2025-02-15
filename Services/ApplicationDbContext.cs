using Microsoft.EntityFrameworkCore;
using Villasor_FunRun.Models.Entities;

namespace Villasor_FunRun.Services
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Participant> Participants { get; set; }

    }
}
