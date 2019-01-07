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
    public partial class students_in_course : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        DataTable dt;

        public students_in_course()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            LecturerZone l = new LecturerZone();
            l.Show();
        }

        private void students_in_course_Load(object sender, EventArgs e)
        {
            stincrs();
        }
        private void stincrs()
        {
            sda = new OleDbDataAdapter("SELECT Name,student.firstName,student.lastName FROM Course,student,StudentInCourse WHERE Course.lecturerName='" + LoginInfo.firstname + "' AND Course.Number=StudentInCourse.num_course AND StudentInCourse.id_student=student.ID", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dt = dt.DefaultView.ToTable(true, "Name", "firstName", "lastName");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Course Name";
            dataGridView1.Refresh();
        }
    }
}
