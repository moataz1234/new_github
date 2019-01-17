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
    public partial class manager_send_message : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        DataTable dt;
        public manager_send_message()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string text = richTextB_text.Text.ToString();
            string toid = textB_toid.Text.ToString();
            string byid = LoginInfo.userid;
            int counts = 0;
            int countl = 0;
            int countm = 0;
            //---------------------------------------------------------------------------------------------------------------------------
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "select * from student where ID='" + toid + "'";
            OleDbDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                counts++;
            }

            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;
            command2.CommandText = "select * from lecturer where ID='" + toid + "'";
            OleDbDataReader reader2= command2.ExecuteReader();
            while (reader2.Read())
            {
                countl++;
            }

            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = connection;
            command3.CommandText = "select * from Manager where ID='" + toid + "'";
            OleDbDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                countm++;
            }
            connection.Close();

            if (counts == 0 && countl == 0 && countm == 0)
            {
                MessageBox.Show("This user not exsit!");
            }
            //---------------------------------------------------------------------------------------------------------------------------
            if (text == "" || toid == "") { MessageBox.Show("you must enter a id you want to send for him and the text message"); }
            else if(counts!=0 || countl != 0|| countm != 0)
            {
                try
                {
                    connection.Open();
                    string query = "INSERT into messages([sender_id],[reciever_id],[Text])VALUES('" + byid + "','" + toid + "','" + text + "')";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Message Sended (-_-)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

            private void manager_send_message_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.database23DataSet.Manager);

        }

        private void textB_toid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManagerZone man = new ManagerZone();
            StudentZone stu = new StudentZone();
            LecturerZone lec = new LecturerZone();
            this.Hide();
            string usera = LoginInfo.user;
            if (usera[0] == 's')
            {
                stu.Show();
            }
            if (usera[0] == 'l')
            {
                lec.Show();
            }
            if (usera[0] == 'm')
            {
                man.Show();
            }
        }

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sda = new OleDbDataAdapter("SELECT ID,firstName,lastName FROM Manager", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sda = new OleDbDataAdapter("SELECT ID,firstName,lastName FROM student", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sda = new OleDbDataAdapter("SELECT ID,firstName,lastName FROM lecturer", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
