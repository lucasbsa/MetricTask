using Models.MoldelUser;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public static class UserBSS
    {
        public static List<User> AddUser() {
            List<User> listUsers = new List<User>();
            listUsers.Add(new User { Name = "Barreto"});
            listUsers.Add(new User { Name = "Ivanzin" });
            listUsers.Add(new User { Name = "Ariane" });

            return listUsers.OrderBy( x => x.Name).ToList();

        }
    }
}
