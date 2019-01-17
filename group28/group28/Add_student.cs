using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group28
{
    public partial class Add_student : Form
    {
        public Add_student()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Add_student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database23DataSet.student);

        }

        private void button_add_Click(object sender, EventArgs e)
        {

            string id = string.Format(textBox_ID.Text);
            string user = string.Format(textBox_un.Text);
            string fn = string.Format(textBox_fn.Text);
            string ln = string.Format(textBox_ln.Text);
            string pw = string.Format(textBox_pw.Text);
            string mail = string.Format(textBox_mail.Text);
            string dp = string.Format(comboBox2.Text);
            string gender = string.Format(comboBox1.Text);
            int count = 0;
            int count2 = 0;
            if (id == "" || user == "" || fn == "" || ln == "" || pw == "" || mail == "" || gender == "" || dp == "") { MessageBox.Show("you must enter all information about student"); }

                if (checkuser(user))
                {
                    MessageBox.Show("First Letter in username must be (s)");
                }
            
            else
            {
                for (int rows = 0; rows < (studentDataGridView.Rows.Count) - 1; rows++)
                {
                    {
                        string value = studentDataGridView.Rows[rows].Cells[0].Value.ToString();
                        if (id == value)
                            count++;
                    }
                }
                for (int rows = 0; rows < (studentDataGridView.Rows.Count) - 1; rows++)
                {
                    {
                        string value = studentDataGridView.Rows[rows].Cells[3].Value.ToString();
                        if (user == value)
                            count2++;
                    }
                }

                if (count == 0 && count2 == 0)
                {
                    database23DataSet.student.AddstudentRow(textBox_ID.Text, textBox_fn.Text, textBox_ln.Text, textBox_un.Text, textBox_pw.Text, textBox_mail.Text, dateTimePicker1.Value, comboBox1.Text, comboBox2.Text);
                    studentTableAdapter.Update(database23DataSet);
                    studentBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(database23DataSet);

                    MessageBox.Show("Success!");
                }
                else if (count == 1)
                    MessageBox.Show("The student Already Exist!");
                else if (count2 == 1)
                    MessageBox.Show( "Username is taken,choose another one!!");
            }
        }
        public bool checkuser(string user)
        {
            if (user[0] != 's')
                return true;
            return false;
        }
        public bool isStudentExist(string id)
        {
            //int count = 0;
            //for (int rows = 0; rows < (studentDataGridView.Rows.Count) - 1; rows++)
            //{

            //    string value = studentDataGridView.Rows[rows].Cells[0].Value.ToString();
            //    if (id == value)
            //        count++;

            //}
            //if (count != 0)
            //    throw new ArgumentException("student is exist");
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ManagerZone mm = new ManagerZone();
            mm.Show();
        }
    }
}
