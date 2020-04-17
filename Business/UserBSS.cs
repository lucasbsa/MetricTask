using Models.MoldelUser;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public static class UserBSS
    {

        public static int AddUser(User user)
        {

            return UserDD.AddUser(user);
        }

        public static User GetUser(int IdUser) {

            return UserDD.GetUser(IdUser);
        }

        public static void RemoveUser(int IdUser)
        {

            UserDD.RemoveUser(IdUser);
        }
        public static void UpdateUser(User user)
        {

             UserDD.UpdateUser(user);
        }
    }
}
