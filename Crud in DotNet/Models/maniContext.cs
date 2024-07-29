using Microsoft.EntityFrameworkCore;

namespace Crud_in_DotNet.Data
{
    public class maniContext : DbContext
    {
        public maniContext(DbContextOptions<maniContext>
            options) : base(options)
        { 

        }

        public DbSet<Product> tbl_product { get; set; }
    }
}
