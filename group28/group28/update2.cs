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
    public partial class update2 : Form
    {
        public update2()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void update2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = string.Format(textB_num.Text);
            string day = string.Format(textB_day.Text);
            string hour = string.Format(textB_hour.Text);
            int count = 0;
            int count2 = 0;
            if (num == "" || day == "" || hour == "") { MessageBox.Show("you must insert all information"); }
            else
            {
                for (int rows = 0; rows < (courseDataGridView.Rows.Count) - 1; rows++)
                {
                    string clas = courseDataGridView.Rows[rows].Cells[2].Value.ToString();
                    string value = courseDataGridView.Rows[rows].Cells[0].Value.ToString();
                    if (num == value)
                    {
                        count2++;
                        for (int i = 0; i < (courseDataGridView.Rows.Count) - 1; i++)
                        {
                            if (courseDataGridView.Rows[i].Cells[2].Value.ToString() == clas && courseDataGridView.Rows[i].Cells[4].Value.ToString() == day && courseDataGridView.Rows[i].Cells[5].Value.ToString() == hour)
                                count++;
                        }
                        if (count == 0)
                        {
                            courseDataGridView.Rows[rows].Cells[4].Value = day;
                            courseDataGridView.Rows[rows].Cells[5].Value = hour;
                            MessageBox.Show("Course Time Update Successfuly");
                        }
                        else
                            MessageBox.Show("You can't update because time conflicts with another course at same day,hour and class ");
                    }
                }
                if (count2 == 0) { MessageBox.Show("Number of course is incorrect"); }
            }
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ManagerZone mn = new ManagerZone();
            mn.Show();
        }
    }
}
