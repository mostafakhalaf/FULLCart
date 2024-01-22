using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FullCart.Authorization.Roles;
using FullCart.Authorization.Users;
using FullCart.MultiTenancy;

namespace FullCart.EntityFrameworkCore
{
    public class FullCartDbContext : AbpZeroDbContext<Tenant, Role, User, FullCartDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FullCartDbContext(DbContextOptions<FullCartDbContext> options)
            : base(options)
        {
        }
    }
}
