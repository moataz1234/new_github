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
    public partial class Reset_password : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public Reset_password()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void Reset_password_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f = new Form1();
            f.Show();
        }
        public bool isnull(string id , string user, string pw)
        {
            if (user == "" || pw == "" || id == "")
            {
                return true;
            }
            return false;
        }
        public bool studentuser(string user)
        {
            if (user[0] == 's')
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username1 = textB_num.Text.ToString();
            string npw = textB_pw.Text.ToString();
            string id = textB_id.Text.ToString();
            if ( isnull(username1,npw,id)) { label3.Text = "insert your id and username and new password!"; }
            else if (studentuser(username1))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from student where username='" + username1 + "'and ID = '" + id + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    OleDbCommand cmd = new OleDbCommand("update student set [password] = '" + npw + "' WHERE ID = '" + id + "' AND username='" + username1 + "'", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PassWord Reseted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    label3.Text = "username or ID Incorrect";
                }
                connection.Close();
            }
            else if (username1[0] == 'l')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from lecturer where username='" + username1 + "'and ID = '" + id + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    OleDbCommand cmd = new OleDbCommand("update lecturer set [password] = '" + npw + "' WHERE ID = '" + id + "' AND username='" + username1 + "'", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PassWord Reseted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    label3.Text = "username or ID Incorrect";
                }
                connection.Close();
            }
            else if (username1[0] == 'm')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Manager where username='" + username1 + "'and ID = '" + id + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    OleDbCommand cmd = new OleDbCommand("update Manager set [password] = '" + npw + "' WHERE ID = '" + id + "' AND username='" + username1 + "'", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PassWord Reseted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    label3.Text = "username or ID Incorrect";
                }
                connection.Close();
            }
            else
            {
                label3.Text = "username or ID Incorrect";
            }
        }
    }
}
