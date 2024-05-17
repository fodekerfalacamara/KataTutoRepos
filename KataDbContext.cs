namespace KataTutoCorrection
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class KataDbContext : IdentityDbContext<IdentityUser>
    {
        public KataDbContext(DbContextOptions<KataDbContext> options)
        : base(options)
        {

        }
    }
}
