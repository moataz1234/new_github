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
    public partial class Search_lecturer : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public Search_lecturer()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void lecturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);
        }

        private void Search_lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.database23DataSet.lecturer);

        }

        private void btn_search_lecc_Click(object sender, EventArgs e)
        {
            string id = string.Format(textB_id_lec.Text);
            if (id == "")
            {
                MessageBox.Show("You Must Insert an id lecturer!");
            }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from lecturer where ID= '" + id + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    DataView dv = new DataView();
                    dv.Table = database23DataSet.Tables[2];
                    dv.RowFilter = "ID  = " + textB_id_lec.Text;
                    lecturerDataGridView.DataSource = dv;
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if ( ISincorrect(count))
                {
                    MessageBox.Show("Incorrect");
                }
                connection.Close();
            }

        }
        public bool ISincorrect(int c)
        {
            if (c > 1) { return false; }
            if (c == 1) { return false; }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ManagerZone man = new ManagerZone();
            StudentZone stu = new StudentZone();
            LecturerZone lec = new LecturerZone();
            this.Hide();
            string usera = LoginInfo.user;
            if(usera[0] == 's')
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

        private void lecturerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
