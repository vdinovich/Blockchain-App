namespace Blockchain_Admin_App
{
    using System;
    using Blockchain_Admin_App.Forms;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Blockchain_Admin_App.Models;

    public partial class Login_Form : Form
    {
        My_Context db;
        public Login_Form()
        {
            InitializeComponent();
            db = new My_Context();
        }

        private void login_btn_Click(object sender, EventArgs e)
        { 
            // Получаем список всех юзеров с таблици:
            List<User> users = ReadFromDatabase.ReadAllUsers();
            bool flag = false;
            string mode = string.Empty;
            string login = login_txt.Text;
            string password = pass_txt.Text;
            if(login == "" && password == "")
                MessageBox.Show("All fields are EMPTY", "1st fill out log & pass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (login == "" || password == "")
                MessageBox.Show("Some fo the field is EMPTY", "1st fill out log & pass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                for(int i = 0; i < users.Count; i++)
                {
                    if(login == users[i].Login && password == users[i].Password && users[i].Role == "admin")
                    {
                        flag = true;
                        mode = users[i].Role;
                        // .. If you are Admin(owner):
                        new Work_Area(mode, users[i].First_Name, users[i].Last_Name).ShowDialog();
                    }
                    else if (login == users[i].Login && password == users[i].Password && users[i].Role == "user")
                    {
                        flag = true;
                        mode = users[i].Role;
                        new Work_Area(mode, users[i].First_Name, users[i].Last_Name).ShowDialog();
                    }
                }
            }

            if (!flag)
                MessageBox.Show("Wrong Login & Password..\nTry again", "User doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
