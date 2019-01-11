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
    public partial class View_Messages : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        DataTable dt;
        public View_Messages()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void View_Messages_Load(object sender, EventArgs e)
        {
            view1();
            view2();
        }
        private void view1()
        {
            sda = new OleDbDataAdapter("SELECT sender_id,reciever_id,Text FROM messages WHERE messages.sender_id ='" + LoginInfo.userid + "'", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void view2()
        {
            sda = new OleDbDataAdapter("SELECT sender_id,Text FROM messages WHERE messages.reciever_id ='" + LoginInfo.userid + "'", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
