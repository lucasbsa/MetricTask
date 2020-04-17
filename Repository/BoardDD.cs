using LibrarySW;
using Models.ModelBoard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    public class BoardDD
    {
        private static readonly string conexao = @"Data Source = NBDEV07; Initial Catalog = TaskMetric; Integrated Security = True";


        public static Board GetBoard(int IdBoard)
        {
            Board board = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.GetBoard", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@IdBoard", System.Data.SqlDbType.NVarChar).Value = IdBoard;

                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();

                            board = new Board
                            {
                                Name = Conversao.FieldToString(reader["Name"]),
                            };
                        }
                    }
                    return board;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Failed: the board was not found.", ex);
            }
        }

        public static int AddBoard(Board board)
        {
            int ResultAdd = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddBoard", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = board.Name;
                        command.Parameters.Add("@ResultAdd", SqlDbType.Int).Direction = ParameterDirection.Output;

                        conn.Open();
                        command.ExecuteNonQuery();
                        ResultAdd = Convert.ToInt32(command.Parameters["@ResultAdd"].Value);
                    }
                }
                return ResultAdd;

            }
            catch (Exception ex)
            {

                throw new Exception("Failed: the board was not add.", ex);
            }
        }

        public static void RemoveUserBoard(int IdUser, int IdBoard)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.RemoveUserBoard", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@IdUser", System.Data.SqlDbType.NVarChar).Value = IdUser;
                        command.Parameters.Add("@IdBoard", System.Data.SqlDbType.NVarChar).Value = IdBoard;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Failed: User of board don't removed.", ex);
            }
        }

        public static void UpdateBoard(Board board)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.UpdateUser", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = board.Name;
                       
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed: the board was not updated.", ex);
            }
        }

        public static void AddSprintBoard(int IdSprint, int IdBoard)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddSprintBoard", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@IdSprint", System.Data.SqlDbType.Int).Value = IdSprint;
                        command.Parameters.Add("@IdBoard", System.Data.SqlDbType.Int).Value = IdBoard;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed: the sprint was not created.", ex);
            }
        }
        
        public static void AddUserBoard(int IdBoard, int IdUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddUserBoard", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@IdUser", System.Data.SqlDbType.Int).Value = IdUser;
                        command.Parameters.Add("@IdBoard", System.Data.SqlDbType.Int).Value = IdBoard;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed: the sprint was not created.", ex);
            }
        }

    }
}
