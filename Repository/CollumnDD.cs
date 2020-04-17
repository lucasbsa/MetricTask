using Models.ModelCollumn;
using Models.ModelTask;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    public static class CollumnDD
    {
        private static readonly string conexao = @"Data Source = NBDEV07; Initial Catalog = TaskMetric; Integrated Security = True";

        public static void addCollumn(Collumn collumn)
        {
            int ResultAdd = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.addCollumn", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@pName", System.Data.SqlDbType.NVarChar).Value = collumn.Name;
                        command.Parameters.Add("@pIdSprint", System.Data.SqlDbType.Int).Value = collumn.IdSprint;
                        ResultAdd = Convert.ToInt32(command.Parameters["@ResultAdd"].Value);

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Failed: the Sprint was not add.", ex);
            }
        }
        public static void DeleteColumn(int IdCollumn)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.DeleteColumn", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@pIdCollumn", System.Data.SqlDbType.Int).Value = IdCollumn;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Failed: Sprint was not delete.", ex);
            }
        }

        public static void UpdateColumn(Collumn collumn) 
        {
            int ResultAdd = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.UpdateColumn", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@pName", System.Data.SqlDbType.NVarChar).Value = collumn.Name;
                        command.Parameters.Add("@pIdSprint", System.Data.SqlDbType.Int).Value = collumn.IdSprint;
                        ResultAdd = Convert.ToInt32(command.Parameters["@ResultAdd"].Value);

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Failed: the Sprint was not update.", ex);
            }
        }

        public static void DeleteTaskColumn(int IdCollumn, int IdTask) 
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.DeleteTaskColumn", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@pIdCollumn", System.Data.SqlDbType.Int).Value = IdCollumn;
                        command.Parameters.Add("@pIdTask", System.Data.SqlDbType.Int).Value = IdTask;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Failed: Task was not delete.", ex);
            }
        }

        public static void AddTaskColumn(int IdCollumn, Task task)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddTaskColumn", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@pIdCollumn", System.Data.SqlDbType.NVarChar).Value = IdCollumn;
                        command.Parameters.Add("@pName", System.Data.SqlDbType.NVarChar).Value = task.Name;
                        command.Parameters.Add("@pDescription", System.Data.SqlDbType.NVarChar).Value = task.Description;
                        command.Parameters.Add("@pEffort", System.Data.SqlDbType.NVarChar).Value = task.effort;
                        command.Parameters.Add("@pStatus", System.Data.SqlDbType.NVarChar).Value = task.Status;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Failed: the Task was not add.", ex);
            }
        }




    }
}
