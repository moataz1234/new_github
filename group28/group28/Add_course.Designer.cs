namespace group28
{
    partial class Add_course
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_course));
            this.database23DataSet = new group28.Database23DataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new group28.Database23DataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new group28.Database23DataSetTableAdapters.TableAdapterManager();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_corse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textB_name = new System.Windows.Forms.TextBox();
            this.textB_lecid = new System.Windows.Forms.TextBox();
            this.textB_points = new System.Windows.Forms.TextBox();
            this.textB_hour = new System.Windows.Forms.TextBox();
            this.textB_day = new System.Windows.Forms.TextBox();
            this.textB_lecname = new System.Windows.Forms.TextBox();
            this.textB_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.database23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // database23DataSet
            // 
            this.database23DataSet.DataSetName = "Database23DataSet";
            this.database23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.database23DataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.lecturer_courseTableAdapter = null;
            this.tableAdapterManager.lecturerTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.messagesTableAdapter = null;
            this.tableAdapterManager.student_courseTableAdapter = null;
            this.tableAdapterManager.StudentInCourseTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = group28.Database23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(532, 110);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.RowTemplate.Height = 24;
            this.courseDataGridView.Size = new System.Drawing.Size(745, 391);
            this.courseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lec_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lecturerName";
            this.dataGridViewTextBoxColumn4.HeaderText = "lecturerName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "day";
            this.dataGridViewTextBoxColumn5.HeaderText = "day";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hour";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hour";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "points";
            this.dataGridViewTextBoxColumn7.HeaderText = "points";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_corse);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textB_name);
            this.groupBox1.Controls.Add(this.textB_lecid);
            this.groupBox1.Controls.Add(this.textB_points);
            this.groupBox1.Controls.Add(this.textB_hour);
            this.groupBox1.Controls.Add(this.textB_day);
            this.groupBox1.Controls.Add(this.textB_lecname);
            this.groupBox1.Controls.Add(this.textB_num);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 463);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Course";
            // 
            // add_corse
            // 
            this.add_corse.BackColor = System.Drawing.Color.Green;
            this.add_corse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_corse.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_corse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_corse.Location = new System.Drawing.Point(355, 402);
            this.add_corse.Name = "add_corse";
            this.add_corse.Size = new System.Drawing.Size(84, 55);
            this.add_corse.TabIndex = 15;
            this.add_corse.Text = "Add";
            this.add_corse.UseVisualStyleBackColor = false;
            this.add_corse.Click += new System.EventHandler(this.add_corse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number:";
            // 
            // textB_name
            // 
            this.textB_name.Location = new System.Drawing.Point(148, 96);
            this.textB_name.Name = "textB_name";
            this.textB_name.Size = new System.Drawing.Size(169, 22);
            this.textB_name.TabIndex = 13;
            // 
            // textB_lecid
            // 
            this.textB_lecid.Location = new System.Drawing.Point(148, 149);
            this.textB_lecid.Name = "textB_lecid";
            this.textB_lecid.Size = new System.Drawing.Size(169, 22);
            this.textB_lecid.TabIndex = 12;
            // 
            // textB_points
            // 
            this.textB_points.Location = new System.Drawing.Point(148, 382);
            this.textB_points.Name = "textB_points";
            this.textB_points.Size = new System.Drawing.Size(169, 22);
            this.textB_points.TabIndex = 11;
            // 
            // textB_hour
            // 
            this.textB_hour.Location = new System.Drawing.Point(148, 323);
            this.textB_hour.Name = "textB_hour";
            this.textB_hour.Size = new System.Drawing.Size(169, 22);
            this.textB_hour.TabIndex = 10;
            // 
            // textB_day
            // 
            this.textB_day.Location = new System.Drawing.Point(148, 264);
            this.textB_day.Name = "textB_day";
            this.textB_day.Size = new System.Drawing.Size(169, 22);
            this.textB_day.TabIndex = 9;
            // 
            // textB_lecname
            // 
            this.textB_lecname.Location = new System.Drawing.Point(148, 202);
            this.textB_lecname.Name = "textB_lecname";
            this.textB_lecname.Size = new System.Drawing.Size(169, 22);
            this.textB_lecname.TabIndex = 8;
            // 
            // textB_num
            // 
            this.textB_num.Location = new System.Drawing.Point(148, 41);
            this.textB_num.Name = "textB_num";
            this.textB_num.Size = new System.Drawing.Size(169, 22);
            this.textB_num.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-5, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lecture_class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer_Name:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_title.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_title.Location = new System.Drawing.Point(578, 22);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(260, 45);
            this.label_title.TabIndex = 19;
            this.label_title.Text = "Add Course";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1315, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.courseDataGridView);
            this.Name = "Add_course";
            this.Text = "Add_course";
            this.Load += new System.EventHandler(this.Add_course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database23DataSet database23DataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Database23DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private Database23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_corse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textB_name;
        private System.Windows.Forms.TextBox textB_lecid;
        private System.Windows.Forms.TextBox textB_points;
        private System.Windows.Forms.TextBox textB_hour;
        private System.Windows.Forms.TextBox textB_day;
        private System.Windows.Forms.TextBox textB_lecname;
        private System.Windows.Forms.TextBox textB_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}