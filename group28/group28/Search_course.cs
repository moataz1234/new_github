﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static group28.Form1;

namespace group28
{
    public partial class Search_course : Form
    {
        public Search_course()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Search_course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void btn_search_crs_Click(object sender, EventArgs e)
        {
            string id = string.Format(textB_id_crs.Text);

            if (id == "")
            {
                MessageBox.Show("You Must Insert a Number Course!");
            }
            else
            {
                DataView dv = new DataView();
                dv.Table = database23DataSet.Tables[0];
                dv.RowFilter = "Number  = " + textB_id_crs.Text;
                courseDataGridView.DataSource = dv;
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
