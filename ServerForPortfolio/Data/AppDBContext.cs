using Microsoft.EntityFrameworkCore;
using ServerForPortfolio.Modals;

namespace ServerForPortfolio.Data
{
    public class AppDBContext: DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext>options) : base(options) 
        {


        }



        public DbSet<ProjectData> ProjectDatas { get; set; }
        public DbSet<WorkData> WorkDatas { get; set; }
        public DbSet<TechnologiesData> TechnologiesDatas { get; set; }



    }
}
