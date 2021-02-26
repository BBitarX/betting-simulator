
namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.pnlChangeLog = new System.Windows.Forms.Panel();
            this.lblChangeLog = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnklblGithub = new System.Windows.Forms.LinkLabel();
            this.lblCreds = new System.Windows.Forms.Label();
            this.pnlChangeLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(514, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlChangeLog
            // 
            this.pnlChangeLog.AutoScroll = true;
            this.pnlChangeLog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlChangeLog.Controls.Add(this.lblChangeLog);
            this.pnlChangeLog.Location = new System.Drawing.Point(31, 99);
            this.pnlChangeLog.Name = "pnlChangeLog";
            this.pnlChangeLog.Size = new System.Drawing.Size(250, 186);
            this.pnlChangeLog.TabIndex = 1;
            // 
            // lblChangeLog
            // 
            this.lblChangeLog.AutoSize = true;
            this.lblChangeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeLog.ForeColor = System.Drawing.Color.Turquoise;
            this.lblChangeLog.Location = new System.Drawing.Point(12, 28);
            this.lblChangeLog.Name = "lblChangeLog";
            this.lblChangeLog.Size = new System.Drawing.Size(204, 272);
            this.lblChangeLog.TabIndex = 0;
            this.lblChangeLog.Text = resources.GetString("lblChangeLog.Text");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklblGithub);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(371, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discord: BBitar#3731";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Github:";
            // 
            // lnklblGithub
            // 
            this.lnklblGithub.AutoSize = true;
            this.lnklblGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.lnklblGithub.Location = new System.Drawing.Point(66, 73);
            this.lnklblGithub.Name = "lnklblGithub";
            this.lnklblGithub.Size = new System.Drawing.Size(56, 13);
            this.lnklblGithub.TabIndex = 2;
            this.lnklblGithub.TabStop = true;
            this.lnklblGithub.Text = "Click Here";
            this.lnklblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblGithub_LinkClicked);
            // 
            // lblCreds
            // 
            this.lblCreds.AutoSize = true;
            this.lblCreds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreds.ForeColor = System.Drawing.Color.Turquoise;
            this.lblCreds.Location = new System.Drawing.Point(466, 293);
            this.lblCreds.Name = "lblCreds";
            this.lblCreds.Size = new System.Drawing.Size(144, 18);
            this.lblCreds.TabIndex = 3;
            this.lblCreds.Text = "Made by BBitar :D";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(622, 320);
            this.Controls.Add(this.lblCreds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlChangeLog);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnlChangeLog.ResumeLayout(false);
            this.pnlChangeLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlChangeLog;
        private System.Windows.Forms.Label lblChangeLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnklblGithub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreds;
    }
}