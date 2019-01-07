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

namespace group28
{
    public partial class StudentZone : Form
    {
        public Search_course asd = new Search_course();
        public Search_lecturer asd1 = new Search_lecturer();
        public EmailUpdate asd2 = new EmailUpdate();
        public Form1 asd3 = new Form1();
        Timer t = new Timer();

        public StudentZone()
        {
            InitializeComponent();
        }

        private void sch_stu_Click(object sender, EventArgs e)
        {
            Hide();
            schedule_student ss = new schedule_student();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            asd.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            asd3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            asd1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            asd2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            View_Messages vm = new View_Messages();
            vm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddCourseStu asd123 = new AddCourseStu();

                  this.Hide();
                   asd123.Show();
        }

    private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteCourseStu asd = new DeleteCourseStu();
            asd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            manager_send_message mm = new manager_send_message();
            mm.Show();
        }

        private void StudentZone_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            label5.Text = DateTime.Now.ToShortDateString();
            label_title.Text = "Welcome ";
            label_title.Text += LoginInfo.firstname;
        }

        private void t_Tick(object sender, EventArgs e)
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
    }
}
