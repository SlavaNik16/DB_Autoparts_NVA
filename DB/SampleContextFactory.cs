using Microsoft.EntityFrameworkCore.Design;

namespace DB_Autoparts_NVA.DB
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        => new ApplicationContext(DataBaseHelper.Option());
    }
}
