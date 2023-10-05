namespace FJS_TOOLKIT
{
    partial class FJS_Toolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJS_Toolkit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.CheckBox();
            this.MHACC = new System.Windows.Forms.CheckBox();
            this.PostAerial = new System.Windows.Forms.CheckBox();
            this.PreAerial = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.folderNameTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Reports);
            this.panel1.Controls.Add(this.MHACC);
            this.panel1.Controls.Add(this.PostAerial);
            this.panel1.Controls.Add(this.PreAerial);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 308);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select a subdirectory setup.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter desired folder names per line.";
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(3, 27);
            this.folderNameTextBox.Multiline = true;
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(293, 203);
            this.folderNameTextBox.TabIndex = 6;
            this.folderNameTextBox.Text = "Enter desired folder names..";
            this.folderNameTextBox.Click += new System.EventHandler(this.folderNameTextBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Folders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reports
            // 
            this.Reports.AutoSize = true;
            this.Reports.ForeColor = System.Drawing.Color.White;
            this.Reports.Location = new System.Drawing.Point(235, 255);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(63, 17);
            this.Reports.TabIndex = 4;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // MHACC
            // 
            this.MHACC.AutoSize = true;
            this.MHACC.ForeColor = System.Drawing.Color.White;
            this.MHACC.Location = new System.Drawing.Point(162, 255);
            this.MHACC.Name = "MHACC";
            this.MHACC.Size = new System.Drawing.Size(67, 17);
            this.MHACC.TabIndex = 3;
            this.MHACC.Text = "MH ACC";
            this.MHACC.UseVisualStyleBackColor = true;
            this.MHACC.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // PostAerial
            // 
            this.PostAerial.AutoSize = true;
            this.PostAerial.ForeColor = System.Drawing.Color.White;
            this.PostAerial.Location = new System.Drawing.Point(80, 255);
            this.PostAerial.Name = "PostAerial";
            this.PostAerial.Size = new System.Drawing.Size(76, 17);
            this.PostAerial.TabIndex = 2;
            this.PostAerial.Text = "Post Aerial";
            this.PostAerial.UseVisualStyleBackColor = true;
            // 
            // PreAerial
            // 
            this.PreAerial.AutoSize = true;
            this.PreAerial.ForeColor = System.Drawing.Color.White;
            this.PreAerial.Location = new System.Drawing.Point(3, 255);
            this.PreAerial.Name = "PreAerial";
            this.PreAerial.Size = new System.Drawing.Size(71, 17);
            this.PreAerial.TabIndex = 1;
            this.PreAerial.Text = "Pre Aerial";
            this.PreAerial.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(301, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 308);
            this.panel2.TabIndex = 9;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(3, 27);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(293, 274);
            this.logTextBox.TabIndex = 9;
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "FJS TOOLKIT - LOGBOOK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "EXTRA TOOLS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(601, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 308);
            this.panel3.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 276);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "PDF 2 PNG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FJS_Toolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(783, 310);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FJS_Toolkit";
            this.Text = "FJS TOOLKIT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox MHACC;
        private System.Windows.Forms.CheckBox PostAerial;
        private System.Windows.Forms.CheckBox PreAerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Reports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
    }
}

