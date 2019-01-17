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
        public OleDbConnection connection = new OleDbConnection();
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
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
            connection.Open();
            OleDbCommand sc = new OleDbCommand("select Name,Number from Course", connection);
            OleDbDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Number", typeof(string));
            dt.Load(reader);

            comboBox1.ValueMember = "Number";
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = dt;
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboBox1.SelectedValue.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string day="";
            string owncrs = "";
            string hour="";
            string username1 = LoginInfo.userid;
            string countt = comboBox1.SelectedValue.ToString();
            int count5 = 0;
            //----------------------------------------------------------------------
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "select * from Course WHERE Number = '" + countt + "'";
            OleDbDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                hour = reader1["Hour"].ToString();
                day = reader1["day"].ToString();
            }
            connection.Close();
            //----------------------------------------------------------------------
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
            connection.Open();
            OleDbCommand command4 = new OleDbCommand();
            //command1.Connection = connection;
             command4 = new OleDbCommand("select * from student_course WHERE StudentID = '" + username1 + "'", connection);

           // command1.CommandText = "select * from student_course WHERE SutdentID = '" + username1 + "'";
            OleDbDataReader reader2 = command4.ExecuteReader();
            int count2 = 0;
            while (reader2.Read())
            {
                owncrs = reader2["Course_Number"].ToString();
                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connection;
                command5.CommandText = "select * from Course WHERE Number = '" + owncrs + "' AND day= '" + day + "' AND Hour= '" + hour + "'";
                OleDbDataReader reader5 = command5.ExecuteReader();
                while (reader5.Read())
                {
                    count5++;
                }
                count2++;
            }
            //------------------------------------------------------------------------------
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from student_course WHERE Course_Number = '" + countt + "'AND StudentID = '" + username1 + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count < 1 && count5 == 0)
            {
                try
                {
                    string aaa = "1";
                    String my_querry = "INSERT INTO student_course(Course_Number,StudentID,exsit)VALUES('" + countt + "','" + username1 + "','" + aaa + "')";
                    OleDbCommand cmd = new OleDbCommand(my_querry, connection);
                    cmd.ExecuteNonQuery();
                    String my_querry1 = "INSERT INTO StudentInCourse(id_student,num_course)VALUES('" + username1 + "','" + countt + "')";
                    OleDbCommand cmd1 = new OleDbCommand(my_querry1, connection);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Course Added successfuly...!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed due to " + ex.Message);
                }
            }
            if (count !=0)
            {
                MessageBox.Show("You Already have This Course");
            }
            else if (count5 != 0 && count==0) { MessageBox.Show("conflicts with another course"); }
            connection.Close();
        }
    public bool checkcount(int count1, int count2)
        {
            if(count1 !=0 && count2 != 0)
            {
                return false;
            }
          else  if (count1 != 0 && count2 == 0)
            {
                return false;
            }
           else if (count1 == 0 && count2 == 0)
            {
                return false;
            }
           return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            StudentZone ss = new StudentZone();
            ss.Show();
        }
    }
}
