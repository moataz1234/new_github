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
    public partial class Form1 : Form
    {

        public OleDbConnection connection = new OleDbConnection();
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username_text.Focus();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            label5.Text = DateTime.Now.ToShortDateString();
        }
        private void t_Tick(object sender,EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
                time += hh;
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
                time += mm;
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
                time += ss;
            label4.Text = time;

        }
        public static class LoginInfo
        {
            public static string userid;
            public static string user;
            public static string firstname;
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            ManagerZone man = new ManagerZone();
            StudentZone stu = new StudentZone();
            LecturerZone lec = new LecturerZone();
            string user = string.Format(username_text.Text);
            string pass = string.Format(password_text.Text);
            LoginInfo.user = user;
                if (!checkpasswordanduser(pass, user))
                {
                    label1.Text="you must enter username and pass to login";
                }
           
            else if (user[0] == 's')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from student where username='" + username_text.Text + "'and password = '" + password_text.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    LoginInfo.userid = reader["ID"].ToString();
                    LoginInfo.firstname = reader["firstName"].ToString();
                    count++;
                }
                if (count == 1)
                {
                   Hide();
                   stu.Show();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    label1.Text = "username or password Incorrect";
                }
                connection.Close();
            }
           else if (user[0] == 'm')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Manager where username='" + username_text.Text + "'and password = '" + password_text.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    LoginInfo.userid = reader["ID"].ToString();
                    LoginInfo.firstname = reader["firstName"].ToString();
                    count++;
                }
                if (count == 1)
                {
                    Hide();
                    man.Show();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    label1.Text = "username or password Incorrect";
                }
                connection.Close();
            }
            else if (user[0] == 'l')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from lecturer where username='" + username_text.Text + "'and password = '" + password_text.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    LoginInfo.userid = reader["ID"].ToString();
                    LoginInfo.firstname = reader["firstName"].ToString();
                    count++;
                }
                if (count == 1)
                {
                    Hide();
                    lec.Show();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    label1.Text = "username or password Incorrect";
                }
                connection.Close();
            }
            else
            {
                label1.Text = "username or password Incorrect";

            }
        }
        public bool checkpasswordanduser(string pw, string user)
        {
            if (string.IsNullOrWhiteSpace(pw))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(user))
            {
                return false;
            }
            return true;
        }

        private void manzone_Click(object sender, EventArgs e)
        {
            ManagerZone mann = new ManagerZone();
            this.Hide();
            mann.Show();
        }

        private void leczone_Click(object sender, EventArgs e)
        {
            LecturerZone lecc = new LecturerZone();
            this.Hide();
            lecc.Show();
        }

        private void stuzone_Click(object sender, EventArgs e)
        {
            StudentZone stdz = new StudentZone();
            this.Hide();
            stdz.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void aboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application is for registration process for courses in an academic institution,Also,Let Users (Student,Manager,Lecturer) perform many tasks in a simple way", "About Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application is Developed by Yazan,Moataz,Odai,Tarek students at Sami Shamoon College of Engineering ", "About Developer",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Reset_password rr = new Reset_password();
            rr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void username_text_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
