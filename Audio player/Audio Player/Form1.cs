//Christian Baack
//3/3/24
//Media app

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataTesting2
{
    public partial class Media : Form
    {
        //Keep track of current logged in user.
        private string logedUser;

        //Gets the logged in user when form is created
        public Media(string logedUser)
        {
            InitializeComponent();
            this.logedUser = logedUser;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserControls();
        }

        
        //Function to get all the entries from the logged in user
        public List<(int, string)> GetEntryDetails()
        {
            List<(int, string)> details = new List<(int, string)>();

            //SQL Connection
            string startupPath = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(startupPath)?.Parent?.FullName;
            string mdfPath = Path.Combine(projectDirectory, "FileBase.mdf");

            string sqlCon =
                            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mdfPath + @";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(sqlCon))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, FileName FROM FileData WHERE Username = @Username"; 
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Username", logedUser);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string fileName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1); //Handling possible NULL values
                            details.Add((id, fileName)); //Adding both ID and FileName to the list
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return details;
        }

        //This Function will pupulate the layout panel with user controls
        private void LoadUserControls()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                var entries = GetEntryDetails();
                foreach (var entry in entries)
                {
                    var (id, fileName) = entry; //Destructuring the tuple
                    PlayerUserControl control = new PlayerUserControl()
                    {
                        ID = id,
                        NAME = fileName 
                    };
                  
                    flowLayoutPanel1.Controls.Add(control);
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            Application.Restart(); //Restarts the application and goes to the login
            Environment.Exit(0);
        }

        //Function will open the file dialog box and upload the selected file details to the database
        private void Upload_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "WAV files (*.wav)|*.wav";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        string fileName = Path.GetFileName(filePath);
                        string fileType = Path.GetExtension(filePath);
                        byte[] fileData = File.ReadAllBytes(filePath);

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
                                       "INSERT INTO [FileData] ([FileData], FileName, Username) VALUES (@FileData, @FileName, @UserName)", conn))
                            {
                                cmd.Parameters.AddWithValue("@FileData", fileData);
                                cmd.Parameters.AddWithValue("@FileName", fileName);
                                cmd.Parameters.AddWithValue("@UserName", logedUser);

                                cmd.ExecuteNonQuery();
                                conn.Close();

                                
                            }
                        }
                        LoadUserControls();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }

        }

        //Iterrate through each user control and stop the audio
        private void StopBT_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PlayerUserControl playerControl)
                {
                    playerControl.StopAudio();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
