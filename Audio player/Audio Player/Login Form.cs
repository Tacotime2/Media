//Christian Baack
//3/3/24
//Media app

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataTesting2
{
    public partial class Login_Form : Form
    {

        public Login_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }


        //Check for usernameand password
        private void LoginBT_Click(object sender, EventArgs e)
        {
            var username = UsernameTB.Text;
            var password = PasswordTB.Text;


            try
            {
                string startupPath = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(startupPath)?.Parent?.FullName;
                string mdfPath = Path.Combine(projectDirectory, "FileBase.mdf");

                string sqlCon =
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mdfPath + @";Integrated Security=True";

                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(sqlCon))
                {
                    conn.Open();
                    using (System.Data.SqlClient.SqlCommand cmd =
                    new System.Data.SqlClient.SqlCommand(
                        "SELECT COUNT(1) FROM [User] WHERE UserId = @UserId AND [Password] = @Password", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        //Execute the command and check if it returns any rows
                        int userExists = (int)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            
                            Media form1 = new Media(username);
                            this.Hide();
                            form1.ShowDialog();
                            
                        }
                        else
                        {
                            //If no user is found, show an error message
                            MessageBox.Show("Login failed. Please check your username and password.");
                        }
                    }
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
