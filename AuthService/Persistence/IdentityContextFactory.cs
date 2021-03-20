using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class IdentityContextFactory : DesignTimeDbContextFactoryBase<IdentityContext>
    {
        protected override IdentityContext CreateNewInstance(DbContextOptions<IdentityContext> options)
        {
            return new IdentityContext(options);
        }
    }
}
