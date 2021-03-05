using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Terminator.Database.Contexts
{
    public class TerminatorDbContext : IdentityDbContext
    {
        public TerminatorDbContext(DbContextOptions<TerminatorDbContext> options)
            : base(options)
        {
        }
    }
}
