using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.BusinessServices
{
    public class Users
    {
        public IEnumerable<User> GetUsers()
        {
            var users = new List<User>
            {
                new User() { FirstName = "Chris", LastName = "Fitzsimmons", Id = "123" }
            };
            return users;
        }
    }
}
