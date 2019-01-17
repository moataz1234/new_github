using group28.Database23DataSetTableAdapters;
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
    public partial class Add_course : Form
    {
        CourseTableAdapter CTA = new CourseTableAdapter();
        private OleDbConnection connection = new OleDbConnection();
        public Add_course()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Add_course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void add_corse_Click(object sender, EventArgs e)
        {

            string num = string.Format(textB_num.Text);
            string name = string.Format(textB_name.Text);
            string lec_id = string.Format(textB_lecid.Text);
            string lec_name = string.Format(textB_lecname.Text);
            string day = string.Format(textB_day.Text);
            string hour= string.Format(textB_hour.Text);
            string points = string.Format(textB_points.Text);
            int count = 0;
            int count3 = 0;
            if (num == "" || name == "" || lec_id == "" || lec_name == "" || day == "" || hour == "" || points == "") { MessageBox.Show("you must enter all information about course"); }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Course where lecturerName='" + lec_name + "'";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    count3++;
                }
                if (count3 == 0)
                {
                    MessageBox.Show("This lecturer not exsit! try again");
                }
                connection.Close();

                if (count3 != 0)
                {

                    for (int rows = 0; rows < (courseDataGridView.Rows.Count) - 1; rows++)
                    {
                        {
                            string value = courseDataGridView.Rows[rows].Cells[0].Value.ToString();
                            if (num == value)
                            {
                                if (isequal(value, num))
                                    count++;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        database23DataSet.Course.AddCourseRow(textB_num.Text, textB_name.Text, textB_lecid.Text, textB_lecname.Text, textB_day.Text, textB_hour.Text, int.Parse(textB_points.Text));
                        CTA.Update(database23DataSet);
                        tableAdapterManager.UpdateAll(database23DataSet);
                        MessageBox.Show("Success!");
                    }
                    else
                        MessageBox.Show("The Course Already Exist!");
                }
            }
        }
        public bool isequal(string val,string id)
        {
            if (val != id)
                throw new ArgumentException("not equal");
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManagerZone man = new ManagerZone();
            LecturerZone lec = new LecturerZone();
            this.Hide();
            string usera = LoginInfo.user;
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
