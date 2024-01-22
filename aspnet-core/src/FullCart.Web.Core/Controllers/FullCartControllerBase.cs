using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FullCart.Controllers
{
    public abstract class FullCartControllerBase: AbpController
    {
        protected FullCartControllerBase()
        {
            LocalizationSourceName = FullCartConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
