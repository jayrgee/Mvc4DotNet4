using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc4DotNet4.Services.Tenant;

namespace Mvc4DotNet4.Test
{
    [TestClass]
    public class TenantSettingsTest
    {
        [TestMethod]
        public void DefaultTenant_ok()
        {
            var sut = new TenantSettings()
            {
                DefaultTenant = "alpha",
            };

            Assert.IsTrue(sut.DefaultTenant.Equals("alpha"));
        }
    }
}
