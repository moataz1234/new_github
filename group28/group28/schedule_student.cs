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
    public partial class schedule_student : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        DataTable dt;

        public schedule_student()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void schedule_student_Load(object sender, EventArgs e)
        {
            scestu();
        }
        private void scestu()
        {
            sda = new OleDbDataAdapter("SELECT Name,day,Hour,lecturerName,lec_id FROM Course,student,student_course WHERE student_course.StudentID='" + LoginInfo.userid + "' AND Course.Number=student_course.Course_Number", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dt = dt.DefaultView.ToTable(true, "Name", "day", "Hour", "lecturerName", "lec_id");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].HeaderText = "Class";
            dataGridView1.Refresh();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            StudentZone st = new StudentZone();
            st.Show();
        }
    }
}
