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

namespace group28
{
    public partial class delete_course : Form
    {
        private OleDbConnection connection= new OleDbConnection();
        public delete_course()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }
        public bool checkisnull(string id)
        {
            if (id == "")
            {
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textB_num.Text.ToString();
            if (checkisnull(id)) { MessageBox.Show("you must insert a course number"); }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Course where Number='" + id + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    command = new OleDbCommand("DELETE FROM [Course] WHERE Number=?", connection);
                    {
                        command.Parameters.AddWithValue("Number", id);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("The Course Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    MessageBox.Show("Incorrect");
                }
                connection.Close();
            }
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void delete_course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ManagerZone mm = new ManagerZone();
            mm.Show();
        }
    }
}
