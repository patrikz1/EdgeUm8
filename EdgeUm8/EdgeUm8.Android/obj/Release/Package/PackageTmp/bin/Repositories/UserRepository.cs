using Remote_db.DataBase;
using Remote_db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remote_db.Repositories
{
    public class UserRepository : Repository<ApplicationUser, string>
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public string GetUserIdByEmail(string email) {
            ApplicationUser user = items.First((u) => u.Email.Equals(email));
            return user.Id;
        }
    }
}