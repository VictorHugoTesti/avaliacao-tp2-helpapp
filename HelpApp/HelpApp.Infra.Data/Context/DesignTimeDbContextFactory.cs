using HelpApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HelpApp.Infra.Data.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Data Source= VICTOR-HUGO\\SQLEXPRESS;Initial Catalog=avaliacao_tpII;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
