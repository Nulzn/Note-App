using MySql.Data.MySqlClient;

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
    }

    public class MySQL
    {
        public void InitSQL()
        {
            string connectionString = null;
            MySqlConnection cnn;

            connectionString = "server=localhost;database=notes;uid=root;pwd=\"\";";

            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Closed!");
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