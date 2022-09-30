using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace Note_App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Opens Create Note Frame

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creates The Note

            var mySQL = new MySQL();
            mySQL.Insert(newNote);
        }
    }

    public class MySQL
    {
        string connectionString = "server=localhost;database=notes;uid=root;pwd=\"\";";
        public void InitSQL()
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Closed!");
            }
        }

        public void Insert(TextBox text)
        {
           try
           {
                MySqlConnection cnn = new MySqlConnection(connectionString);
                string query = $"INSERT INTO notes(Text) VALUES ({text.Text.ToString()})";

                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader dataReader;

                cnn.Open();
                dataReader = cmd.ExecuteReader();

                MessageBox.Show("Saved Data!");

                while (dataReader.Read())
                {

                }
                cnn.Clone();
           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }
    }

    public class Verify
    {
        public bool VerifyLength(string text)
        {
            if (text.Length <= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}