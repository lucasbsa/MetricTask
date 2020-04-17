using Models.ModelCollumn;
using Models.ModelTask;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class CollumnBSS
    {
        public static void addCollumn(Collumn collumn) {

            CollumnDD.addCollumn(collumn);
        }
        public static void DeleteColumn(int IdCollumn) {
            CollumnDD.DeleteColumn(IdCollumn);
        }
        public static void UpdateColumn(Collumn collumn) {
            CollumnDD.UpdateColumn(collumn);
        }
        public static void DeleteTaskColumn(int IdCollumn, int IdTask) {
            CollumnDD.DeleteTaskColumn(IdCollumn, IdTask);
        }
        public static void AddTaskColumn(int IdCollumn,Task task) {
            CollumnDD.AddTaskColumn(IdCollumn, task);
        }

    }
}
