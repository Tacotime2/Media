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

namespace DataTesting2
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        //Uploads the Username and password to the database
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
                                "INSERT INTO [User] (UserId, [Password]) VALUES (@UserId, @Password)", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();

                        
                    }
                }

                MessageBox.Show("Success");
                    
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            this.Hide();
            loginForm.ShowDialog();
            
        }
    }
}
