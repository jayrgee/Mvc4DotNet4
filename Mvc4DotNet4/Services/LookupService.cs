using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4DotNet4.Services
{
    public interface ILookupService
    {
        void LookupValue();
    }

    public class LookupService : ILookupService
    {
        private ITenantService _tenantService;

        public LookupService(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        public void LookupValue()
        {
            _tenantService.GetTenant();
        }
    }
}