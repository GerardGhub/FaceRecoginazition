namespace FaceRecoginazition
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pth1 = new System.Windows.Forms.Label();
            this.pth2 = new System.Windows.Forms.Label();
            this.pth3 = new System.Windows.Forms.Label();
            this.pth4 = new System.Windows.Forms.Label();
            this.pth5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(1677, 796);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 126);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start and Reoginize Face";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Location = new System.Drawing.Point(907, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(627, 577);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training: ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(1429, 796);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 126);
            this.button2.TabIndex = 3;
            this.button2.Text = "Capture Face";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(27, 169);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(861, 634);
            this.imageBoxFrameGrabber.TabIndex = 19;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1257, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // pth1
            // 
            this.pth1.AutoSize = true;
            this.pth1.Location = new System.Drawing.Point(32, 844);
            this.pth1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pth1.Name = "pth1";
            this.pth1.Size = new System.Drawing.Size(90, 32);
            this.pth1.TabIndex = 31;
            this.pth1.Text = "Path1";
            this.pth1.Visible = false;
            // 
            // pth2
            // 
            this.pth2.AutoSize = true;
            this.pth2.Location = new System.Drawing.Point(32, 892);
            this.pth2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pth2.Name = "pth2";
            this.pth2.Size = new System.Drawing.Size(90, 32);
            this.pth2.TabIndex = 32;
            this.pth2.Text = "Path2";
            this.pth2.Visible = false;
            // 
            // pth3
            // 
            this.pth3.AutoSize = true;
            this.pth3.Location = new System.Drawing.Point(32, 940);
            this.pth3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pth3.Name = "pth3";
            this.pth3.Size = new System.Drawing.Size(90, 32);
            this.pth3.TabIndex = 33;
            this.pth3.Text = "Path3";
            this.pth3.Visible = false;
            // 
            // pth4
            // 
            this.pth4.AutoSize = true;
            this.pth4.Location = new System.Drawing.Point(40, 980);
            this.pth4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pth4.Name = "pth4";
            this.pth4.Size = new System.Drawing.Size(93, 32);
            this.pth4.TabIndex = 34;
            this.pth4.Text = "label1";
            this.pth4.Visible = false;
            // 
            // pth5
            // 
            this.pth5.AutoSize = true;
            this.pth5.Location = new System.Drawing.Point(48, 1021);
            this.pth5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pth5.Name = "pth5";
            this.pth5.Size = new System.Drawing.Size(93, 32);
            this.pth5.TabIndex = 35;
            this.pth5.Text = "label3";
            this.pth5.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1429, 940);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 131);
            this.button3.TabIndex = 36;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2176, 1240);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pth5);
            this.Controls.Add(this.pth4);
            this.Controls.Add(this.pth3);
            this.Controls.Add(this.pth2);
            this.Controls.Add(this.pth1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pth1;
        private System.Windows.Forms.Label pth2;
        private System.Windows.Forms.Label pth3;
        private System.Windows.Forms.Label pth4;
        private System.Windows.Forms.Label pth5;
        private System.Windows.Forms.Button button3;
    }
}

