namespace FaceRecoginazition
{
    partial class View_Record
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new FaceRecoginazition.Database1DataSet2();
            this.attendanceTableAdapter = new FaceRecoginazition.Database1DataSet2TableAdapters.AttendanceTableAdapter();
            this.dgvUserType = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // dgvUserType
            // 
            this.dgvUserType.AllowUserToAddRows = false;
            this.dgvUserType.AllowUserToDeleteRows = false;
            this.dgvUserType.AllowUserToResizeColumns = false;
            this.dgvUserType.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.dgvUserType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserType.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUserType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserType.ColumnHeadersHeight = 30;
            this.dgvUserType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.uid,
            this.uname,
            this.sDate,
            this.sAttendance,
            this.sTime});
            this.dgvUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserType.EnableHeadersVisualStyles = false;
            this.dgvUserType.GridColor = System.Drawing.SystemColors.Window;
            this.dgvUserType.Location = new System.Drawing.Point(0, 0);
            this.dgvUserType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvUserType.MultiSelect = false;
            this.dgvUserType.Name = "dgvUserType";
            this.dgvUserType.ReadOnly = true;
            this.dgvUserType.RowHeadersWidth = 50;
            this.dgvUserType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvUserType.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserType.Size = new System.Drawing.Size(2262, 925);
            this.dgvUserType.TabIndex = 50;
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
            // View_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2262, 925);
            this.Controls.Add(this.dgvUserType);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "View_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Record";
            this.Load += new System.EventHandler(this.View_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Database1DataSet2TableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridView dgvUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTime;
    }
}