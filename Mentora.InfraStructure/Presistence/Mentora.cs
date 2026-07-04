using Mentora.Domin.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mentora.InfraStructure.Presistence
{
    public class Mentora : IdentityDbContext<ApplicationUser>
    {
        

        public Mentora(DbContextOptions<Mentora> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(Mentora).Assembly);
        }
    }
}
