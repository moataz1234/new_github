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
    public partial class lec_schedule : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        //private OleDbCommandBuilder scb;
        DataTable dt;

        public lec_schedule()
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

        private void lec_schedule_Load(object sender, EventArgs e)
        {
            lecsce();
        }
        private void lecsce()
        {
            sda = new OleDbDataAdapter("SELECT Name,day,Hour,lec_id FROM Course,lecturer_course,lecturer WHERE lecturer_course.lecturer_id='" + LoginInfo.userid + "' AND Course.Number=lecturer_course.course_id", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dt = dt.DefaultView.ToTable(true, "Name", "day", "Hour", "lec_id");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].HeaderText = "Class";
            dataGridView1.Refresh();
        }
    }
}
