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

        private void button1_Click(object sender, EventArgs e)
        {
            // Opens Create Note Frame

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creates The Note

            var mySQL = new MySQL();
            mySQL.Insert();
        }
    }

    public class MySQL
    {
        MySqlConnection cnn;
        public void InitSQL()
        {
            string connectionString = null;

            connectionString = "server=localhost;database=notes;uid=root;pwd=\"\";";

            cnn = new MySqlConnection(connectionString);

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