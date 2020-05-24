namespace Blockchain_Admin_App.Models
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Collections.Generic;

    public static class ReadFromDatabase
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        static SqlDataReader dReader;

        public static List<User> ReadAllUsers()
        {
            List<User> users = new List<User>();
            //string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\vdino\Downloads\C# - Andrei\Blockchain_Admin_App\Blockchain_Admin_App\DATA\Blockchain.mdf'; Integrated Security = True"))
            {
                using (cmd = new SqlCommand("select * from Users", conn)) 
                {
                    conn.Open();
                    dReader = cmd.ExecuteReader();

                    while (dReader.Read())
                    {
                        User user = new User();
                        user.Id = Convert.ToInt32(dReader["Id"]);
                        user.Last_Name = dReader["Last_Name"].ToString();
                        user.First_Name = dReader["First_Name"].ToString();
                        user.Login = dReader["Login"].ToString();
                        user.Password = dReader["Password"].ToString();
                        user.Age = Convert.ToInt32(dReader["Age"]);
                        user.Role = dReader["Role"].ToString();
                        user.Date_Register = Convert.ToDateTime(dReader["Date_Register"]);
                        user.Phone = dReader["Phone"].ToString();

                        users.Add(user);
                    }
                    dReader.Close();
                }
                conn.Close();
            }

            return users;
        }
    }
}
