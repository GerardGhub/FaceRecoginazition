namespace FaceRecoginazition
{
    partial class Login
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.tone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tfour = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Reg2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUserType = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feed_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagorbin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "Username";
            // 
            // tone
            // 
            this.tone.Location = new System.Drawing.Point(414, 108);
            this.tone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tone.Name = "tone";
            this.tone.Size = new System.Drawing.Size(423, 38);
            this.tone.TabIndex = 38;
            this.tone.TextChanged += new System.EventHandler(this.tone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 32);
            this.label2.TabIndex = 42;
            this.label2.Text = "UserPassword";
            // 
            // tfour
            // 
            this.tfour.Location = new System.Drawing.Point(414, 232);
            this.tfour.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tfour.Name = "tfour";
            this.tfour.PasswordChar = '*';
            this.tfour.Size = new System.Drawing.Size(423, 38);
            this.tfour.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select Type",
            "Student",
            "Teacher"});
            this.comboBox1.Location = new System.Drawing.Point(414, 346);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 39);
            this.comboBox1.TabIndex = 45;
            // 
            // Reg2
            // 
            this.Reg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg2.Location = new System.Drawing.Point(425, 458);
            this.Reg2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Reg2.Name = "Reg2";
            this.Reg2.Size = new System.Drawing.Size(200, 55);
            this.Reg2.TabIndex = 43;
            this.Reg2.Text = "Submit";
            this.Reg2.UseVisualStyleBackColor = true;
            this.Reg2.Click += new System.EventHandler(this.Reg2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "User Type";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(644, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 46;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1521, 239);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 55);
            this.button2.TabIndex = 47;
            this.button2.Text = "SignUp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tfour);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Reg2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 595);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Credentials";
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
            this.dgvUserType.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvUserType.ColumnHeadersHeight = 30;
            this.dgvUserType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_id,
            this.fcode,
            this.feed_type,
            this.bags,
            this.batch,
            this.prod,
            this.added,
            this.bagorbin});
            this.dgvUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUserType.EnableHeadersVisualStyles = false;
            this.dgvUserType.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUserType.Location = new System.Drawing.Point(1213, 70);
            this.dgvUserType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvUserType.MultiSelect = false;
            this.dgvUserType.Name = "dgvUserType";
            this.dgvUserType.ReadOnly = true;
            this.dgvUserType.RowHeadersWidth = 50;
            this.dgvUserType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvUserType.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvUserType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserType.Size = new System.Drawing.Size(251, 446);
            this.dgvUserType.TabIndex = 49;
            this.dgvUserType.CurrentCellChanged += new System.EventHandler(this.dgvUserType_CurrentCellChanged);
            // 
            // prod_id
            // 
            this.prod_id.DataPropertyName = "prod_id";
            this.prod_id.HeaderText = "ID";
            this.prod_id.MinimumWidth = 12;
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            this.prod_id.Visible = false;
            // 
            // fcode
            // 
            this.fcode.DataPropertyName = "p_feed_code";
            this.fcode.HeaderText = "FEED CODE";
            this.fcode.MinimumWidth = 12;
            this.fcode.Name = "fcode";
            this.fcode.ReadOnly = true;
            // 
            // feed_type
            // 
            this.feed_type.DataPropertyName = "feed_type";
            this.feed_type.HeaderText = "FEED TYPE";
            this.feed_type.MinimumWidth = 12;
            this.feed_type.Name = "feed_type";
            this.feed_type.ReadOnly = true;
            // 
            // bags
            // 
            this.bags.DataPropertyName = "p_bags";
            this.bags.HeaderText = "BAGS";
            this.bags.MinimumWidth = 12;
            this.bags.Name = "bags";
            this.bags.ReadOnly = true;
            // 
            // batch
            // 
            this.batch.DataPropertyName = "p_nobatch";
            this.batch.HeaderText = "BATCH";
            this.batch.MinimumWidth = 12;
            this.batch.Name = "batch";
            this.batch.ReadOnly = true;
            // 
            // prod
            // 
            this.prod.DataPropertyName = "proddate";
            this.prod.HeaderText = "PROD DATE";
            this.prod.MinimumWidth = 12;
            this.prod.Name = "prod";
            this.prod.ReadOnly = true;
            // 
            // added
            // 
            this.added.DataPropertyName = "dateadded";
            this.added.HeaderText = "DATE ADDED";
            this.added.MinimumWidth = 12;
            this.added.Name = "added";
            this.added.ReadOnly = true;
            // 
            // bagorbin
            // 
            this.bagorbin.DataPropertyName = "bagorbin";
            this.bagorbin.HeaderText = "STATS";
            this.bagorbin.MinimumWidth = 12;
            this.bagorbin.Name = "bagorbin";
            this.bagorbin.ReadOnly = true;
            this.bagorbin.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(991, 629);
            this.Controls.Add(this.dgvUserType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tfour;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Reg2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn feed_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn bags;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn added;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagorbin;
    }
}