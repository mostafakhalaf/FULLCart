using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FullCart.EntityFrameworkCore;
using FullCart.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FullCart.Web.Tests
{
    [DependsOn(
        typeof(FullCartWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FullCartWebTestModule : AbpModule
    {
        public FullCartWebTestModule(FullCartEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FullCartWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FullCartWebMvcModule).Assembly);
        }
    }
}