using LibrarySW;
using Models.MoldelUser;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public static class UserDD
    {
        private static readonly string conexao = @"Data Source = NBDEV07; Initial Catalog = TaskMetric; Integrated Security = True";


        public static User GetUser(int IdUser)
        {
            User user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.GetUser", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@IdUser", System.Data.SqlDbType.NVarChar).Value = IdUser;

                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();

                            user = new User
                            {
                                DataInclusao = Conversao.FieldToDateTime(reader["DataInclusao"]),
                                Name = Conversao.FieldToString(reader["Name"]),
                                Email = Conversao.FieldToString(reader["Email"]),
                                CPF = Conversao.FieldToString(reader["CPF"]),
                              

                            };
                        }   
                    }
                    return user;

                }

            }
            catch (Exception ex)
            {
            
                throw new Exception("Failed: the user was not found.", ex);
            }
        }
        
        public static int AddUser(User user)
        {
            int ResultAdd = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddUser", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = user.Name;
                        command.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar).Value = user.CPF;
                        command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar).Value = user.Email;
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

                throw new Exception("Failed: the user was not found.", ex);
            }
        }

        public static void RemoveUser(int IdUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.RemoveUser", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@IdUser", System.Data.SqlDbType.NVarChar).Value = IdUser;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Failed: User don't removed.", ex);
            }
        }

        public static void UpdateUser(User user)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand command = new SqlCommand("dbo.UpdateUser", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = user.Name;
                        command.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar).Value = user.CPF;
                        command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar).Value = user.Email;
                        command.Parameters.Add("@IdUser", System.Data.SqlDbType.Int).Value = user.IdUser;


                        conn.Open();
                        command.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Failed: the user was not updated.", ex);
            }
        }

    }
}
