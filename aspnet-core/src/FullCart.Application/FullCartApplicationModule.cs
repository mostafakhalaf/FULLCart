using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FullCart.Authorization;

namespace FullCart
{
    [DependsOn(
        typeof(FullCartCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FullCartApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FullCartAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FullCartApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
