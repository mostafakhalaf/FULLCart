using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FullCart.EntityFrameworkCore
{
    public static class FullCartDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FullCartDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FullCartDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
