﻿using System;
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
    public partial class upclass : Form
    {
        public upclass()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void upclass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = string.Format(textB_num.Text);
            string classs = string.Format(textB_class.Text);
            for (int rows = 0; rows < (courseDataGridView.Rows.Count) - 1; rows++)
            {
                string day = courseDataGridView.Rows[rows].Cells[4].Value.ToString();
                string hour = courseDataGridView.Rows[rows].Cells[5].Value.ToString();
                string value = courseDataGridView.Rows[rows].Cells[0].Value.ToString();
                if (num == value)
                {
                    for (int i = 0; i < (courseDataGridView.Rows.Count) - 1; i++)
                    {
                        if (courseDataGridView.Rows[i].Cells[2].Value.ToString() == classs && courseDataGridView.Rows[i].Cells[4].Value.ToString() == day && courseDataGridView.Rows[i].Cells[5].Value.ToString() == hour)
                        {
                            MessageBox.Show("You can't update because class conflicts with another course at same day,hour and class ");
                        }
                        else 
                        {
                            courseDataGridView.Rows[rows].Cells[2].Value = classs;
                        }
                    }
                }
            }
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            LecturerZone l = new LecturerZone();
            l.Show();
        }
    }
}
