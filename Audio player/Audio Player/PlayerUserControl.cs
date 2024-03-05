//Christian Baack
//3/3/24
//Media app

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTesting2
{
    public partial class PlayerUserControl : UserControl
    {
        //Keep track of id and file name
        private int _id;

        private string _name;

        private SoundPlayer _player;

        public string NAME
        {
            get => _name; 
            set
            {
                _name = value;
            }
        }
        public int ID
        {
            get => _id;
            set
            {
                _id = value;
                //Update the control's display or behavior based on the new ID, if necessary.
            }
        }

        public PlayerUserControl()
        {
        
            InitializeComponent();
        }

        private void PlayerUserControl_Load(object sender, EventArgs e)
        {
            ControlLabel.Text = _name; //Set the name
        }

        //Retrieve the file and store it into a byte array
        public byte[] GetAudioData(int audioId)
        {
            string startupPath = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(startupPath)?.Parent?.FullName;
            string mdfPath = Path.Combine(projectDirectory, "FileBase.mdf");

            string sqlCon =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mdfPath + @";Integrated Security=True";

            string query = "SELECT FileData FROM [FileData] WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(sqlCon))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", audioId);

                try
                {
                    connection.Open();
                    var audioData = command.ExecuteScalar();
                    if (audioData != null)
                    {
                        return (byte[])audioData;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }

        //Play the audio 
        public void PlayAudio(byte[] audioData)
        {
            if (audioData == null) return;

            if (_player != null) //Stop any currently playing audio
            {
                _player.Stop();
            }

            using (MemoryStream ms = new MemoryStream(audioData))
            {
                _player = new SoundPlayer(ms); 
                _player.Play();
            }
        }

        public void StopAudio()
        {
            if (_player != null)
            {
                _player.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlayAudio(GetAudioData(_id));
        }

        //Delete User control and delete the file from the database
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();

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
                    string query = "DELETE FROM FileData WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", _id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void PlayBT_MouseDown(object sender, MouseEventArgs e)
        {
            PlayBT.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PlayBT_MouseUp(object sender, MouseEventArgs e)
        {
            PlayBT.BorderStyle= BorderStyle.None;
        }
    }
}
