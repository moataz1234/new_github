using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static group28.Form1;


namespace group28
{
    public partial class EmailUpdate : Form
    {
        public OleDbConnection connection = new OleDbConnection();

        public EmailUpdate()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username1 =  LoginInfo.userid;
            string newemail = textBox1.Text.ToString();
            if (string.IsNullOrWhiteSpace(newemail)) { MessageBox.Show("Insert your new E-mail <-->(-_-)"); }
            else
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("update student set Email = '" + newemail + "' WHERE ID = '" + username1 + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EmailUpdate_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            StudentZone szsz = new StudentZone();
            szsz.Show();
        }
    }
}
