using Models.ModelSprint;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class SprintBSS
    {
        public static void addSprint(Sprint sprint)
        {
            SprintDD.addSprint(sprint);
        }
        public static void RemoveSprint(int IdSprint) {
            SprintDD.RemoveSprint(IdSprint);
        }
        public static void UpdateSprint(Sprint sprint) {
            SprintDD.UpdateSprint(sprint);
        }
        public static void RemoveUserSprint(int IdSprint, int IdUser) {
            SprintDD.RemoveUserSprint(IdSprint, IdUser);
        }


    }
}