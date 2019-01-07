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
    public partial class ManagerZone : Form
    {
        Timer t = new Timer();
        public Form1 asd3 = new Form1();
        public ManagerZone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Search_student ss = new Search_student();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Search_course sc = new Search_course();
            sc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Search_lecturer sl = new Search_lecturer();
            sl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Add_student asd = new Add_student();
            asd.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            update2 up = new update2();
            up.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Add_course adcrs = new Add_course();
            adcrs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            delete_course dlcrs = new delete_course();
            dlcrs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            manager_send_message mmn = new manager_send_message();
            mmn.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            View_Messages vm = new View_Messages();
            vm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            asd3.Show();
        }

        private void ManagerZone_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            label5.Text = DateTime.Now.ToShortDateString();
            label_title.Text = "Welcome ";
            label_title.Text += LoginInfo.firstname;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            label5.Text = DateTime.Now.ToShortDateString();
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
