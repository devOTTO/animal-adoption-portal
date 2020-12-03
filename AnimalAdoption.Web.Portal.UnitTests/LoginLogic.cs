using AnimalAdoption.Common.Logic;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;
using Xunit;

namespace AnimalAdoption.Service.Login.UnitTests
{
    public class LoginTests
    {
        [Fact]
        public void TestGetLoginUserFromId()
        {
            var loginId = "placeholder";

            var memoryCache = new MemoryCache(new MemoryCacheOptions());
            var loginService = new LoginService();

            Assert.Equal("DevOps_Team3", loginService.GetLoginUserFromId(loginId))
        }
    }
}
