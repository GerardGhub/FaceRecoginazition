namespace FaceRecoginazition
{
    partial class Make_Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvUserType = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Persons in the scene :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 61);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nobody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1378, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            this.label3.TextChanged += new System.EventHandler(this.label3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(738, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of faces detected Including Ghost:  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbldate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(977, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1469, 634);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results: ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(1094, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 126);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(29, 45);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(431, 317);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Location = new System.Drawing.Point(2487, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(491, 577);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 427);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 39);
            this.comboBox1.TabIndex = 6;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(59, 33);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(861, 634);
            this.imageBoxFrameGrabber.TabIndex = 22;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbldate.Location = new System.Drawing.Point(59, 509);
            this.lbldate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(324, 100);
            this.lbldate.TabIndex = 18;
            this.lbldate.Text = "Nobody";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvUserType
            // 
            this.dgvUserType.AllowUserToAddRows = false;
            this.dgvUserType.AllowUserToDeleteRows = false;
            this.dgvUserType.AllowUserToResizeColumns = false;
            this.dgvUserType.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            this.dgvUserType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvUserType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserType.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUserType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvUserType.ColumnHeadersHeight = 40;
            this.dgvUserType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.uid,
            this.uname,
            this.sDate,
            this.sAttendance,
            this.sTime,
            this.lunch_out,
            this.lunch_in,
            this.time_out});
            this.dgvUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUserType.EnableHeadersVisualStyles = false;
            this.dgvUserType.GridColor = System.Drawing.SystemColors.Window;
            this.dgvUserType.Location = new System.Drawing.Point(59, 772);
            this.dgvUserType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvUserType.MultiSelect = false;
            this.dgvUserType.Name = "dgvUserType";
            this.dgvUserType.ReadOnly = true;
            this.dgvUserType.RowHeadersWidth = 50;
            this.dgvUserType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvUserType.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvUserType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserType.Size = new System.Drawing.Size(2387, 388);
            this.dgvUserType.TabIndex = 51;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "uid";
            this.uid.HeaderText = "USER ID";
            this.uid.MinimumWidth = 12;
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            // 
            // uname
            // 
            this.uname.DataPropertyName = "uname";
            this.uname.HeaderText = "USERNAME";
            this.uname.MinimumWidth = 12;
            this.uname.Name = "uname";
            this.uname.ReadOnly = true;
            // 
            // sDate
            // 
            this.sDate.DataPropertyName = "sDate";
            this.sDate.HeaderText = "DATE";
            this.sDate.MinimumWidth = 12;
            this.sDate.Name = "sDate";
            this.sDate.ReadOnly = true;
            // 
            // sAttendance
            // 
            this.sAttendance.DataPropertyName = "sAttendance";
            this.sAttendance.HeaderText = "STATUS";
            this.sAttendance.MinimumWidth = 12;
            this.sAttendance.Name = "sAttendance";
            this.sAttendance.ReadOnly = true;
            // 
            // sTime
            // 
            this.sTime.DataPropertyName = "sTime";
            this.sTime.HeaderText = "TIME IN";
            this.sTime.MinimumWidth = 12;
            this.sTime.Name = "sTime";
            this.sTime.ReadOnly = true;
            // 
            // lunch_out
            // 
            this.lunch_out.DataPropertyName = "lunch_out";
            this.lunch_out.HeaderText = "LUNCH OUT";
            this.lunch_out.MinimumWidth = 12;
            this.lunch_out.Name = "lunch_out";
            this.lunch_out.ReadOnly = true;
            // 
            // lunch_in
            // 
            this.lunch_in.DataPropertyName = "lunch_in";
            this.lunch_in.HeaderText = "LUNCH IN";
            this.lunch_in.MinimumWidth = 12;
            this.lunch_in.Name = "lunch_in";
            this.lunch_in.ReadOnly = true;
            // 
            // time_out
            // 
            this.time_out.DataPropertyName = "time_out";
            this.time_out.HeaderText = "TIME OUT";
            this.time_out.MinimumWidth = 12;
            this.time_out.Name = "time_out";
            this.time_out.ReadOnly = true;
            // 
            // Make_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2483, 1176);
            this.Controls.Add(this.dgvUserType);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Make_Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make_Attendance";
            this.Load += new System.EventHandler(this.Make_Attendance_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_out;
    }
}