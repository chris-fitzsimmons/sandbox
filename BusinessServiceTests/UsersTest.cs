using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.BusinessServices;

namespace Sandbox.BusinessServiceTests
{
    [TestClass]
    public class UsersTest
    {
        [TestMethod]
        public void UserExists_GetUser_ReturnsAtLeastOneUser()
        {
            var service = new Users();
            var users = service.GetUsers();
            Assert.IsTrue(users.Count() > 0);
        }
    }
}
