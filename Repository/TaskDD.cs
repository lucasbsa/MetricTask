using Models.ModelSprint;
using Models.ModelTask;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public static class TaskDD
    {
        public static void addTask(Task task) { }
        public static void DeleteTask(int IdTask) { }
        public static void UpdateTask(Task task) { }
        public static void DeleteUserTask(int IdTask, int IdUser) { }
        public static void AddUserTask(int IdTask, int IdUser) { }
    }
}
