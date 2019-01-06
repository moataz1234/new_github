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
using System.Configuration;


namespace group28
{
    public partial class DeleteCourseStu : Form
    {
        public StudentZone asd = new StudentZone();
        private OleDbDataAdapter sda;
        DataTable dt;
        private OleDbConnection connection = new OleDbConnection();

        public DeleteCourseStu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            asd.Show();
        }

        public void DeleteCourseStu_Load(object sender, EventArgs e)
        {
            view_courses();

        }
        private void view_courses()
        {
            string username = LoginInfo.userid;
            sda = new OleDbDataAdapter("SELECT Course_Number FROM student_course WHERE StudentID='" + username + "'", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string username1 = LoginInfo.userid;
            string id = textBox1.Text.ToString();
            if (id == "") { MessageBox.Show("you must insert a course number"); }

            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from student_course WHERE Course_Number = '" + id + "'AND StudentID = '" + username1 + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM student_course WHERE Course_Number = '" + id + "'AND StudentID = '" + username1 + "'", connection);
                    cmd.ExecuteNonQuery();
                    OleDbCommand cmd1 = new OleDbCommand("DELETE FROM StudentInCourse WHERE num_course = '" + id + "'AND id_student = '" + username1 + "'", connection);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
