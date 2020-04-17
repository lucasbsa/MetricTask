using Models.ModelTask;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class TaskBSS
    {
        public static void addTask(Task task) {
            TaskDD.addTask(task);
        }
        public static void DeleteTask(int IdTask) {
            TaskDD.DeleteTask(IdTask);

        }
        public static void UpdateTask(Task task) {
            TaskDD.UpdateTask(task);
        }
        public static void DeleteUserTask(int IdTask, int IdUser) {
            TaskDD.DeleteUserTask(IdTask, IdUser);
        }
        public static void AddUserTask(int IdTask, int IdUser) {
            TaskDD.AddUserTask(IdTask, IdUser);

        }
    }
}
