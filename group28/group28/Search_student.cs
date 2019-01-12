using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static group28.Form1;
using System.Data.OleDb;

namespace group28
{
    public partial class Search_student : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public Search_student()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Search_student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database23DataSet.student);

        }
        public bool iswhite(string id)
        {
            if (id == "")
                return false;
            return true;
        }
        private void btn_search_lec_Click(object sender, EventArgs e)
        {
            string id = string.Format(textB_id.Text);
            if (!iswhite(id))
            {
                MessageBox.Show("You Must Insert a Student ID !");
            }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from student where ID= '" + id + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    DataView dv = new DataView();
                    dv.Table = database23DataSet.Tables[6];
                    dv.RowFilter = "ID  = " + textB_id.Text;
                    studentDataGridView.DataSource = dv;
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
    }
}
