using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CardCloud.EntityFramework;

namespace CardCloud.Migrator
{
    [DependsOn(typeof(CardCloudDataModule))]
    public class CardCloudMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CardCloudDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}