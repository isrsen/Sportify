using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Terminator.Database.Entities;

namespace Terminator.Database.Contexts
{
    public class TerminatorDbContext : IdentityDbContext<DbUser>
    { 
        public TerminatorDbContext(DbContextOptions<TerminatorDbContext> options)
            : base(options)
        {
        }
    }
}
