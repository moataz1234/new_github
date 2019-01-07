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
    public partial class AddCourseStu : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public StudentZone mm = new StudentZone();
        public AddCourseStu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mm.Show();
        }

        public void AddCourseStu_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
            conn.Open();
            OleDbCommand sc = new OleDbCommand("select Name,Number from Course", conn);
            OleDbDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Number", typeof(string));
            dt.Load(reader);

            comboBox1.ValueMember = "Number";
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = dt;
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboBox1.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string count = comboBox1.SelectedValue.ToString();
                string aaa = "1";
                string username1 = LoginInfo.userid;
                String my_querry = "INSERT INTO student_course(Course_Number,StudentID,exsit)VALUES('" + count + "','" + username1 + "','"+aaa+"')";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                String my_querry1 = "INSERT INTO StudentInCourse(id_student,num_course)VALUES('" + username1 + "','" + count + "')";
                OleDbCommand cmd1 = new OleDbCommand(my_querry1, conn);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Data saved successfuly...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            StudentZone ss = new StudentZone();
            ss.Show();
        }
    }
}
