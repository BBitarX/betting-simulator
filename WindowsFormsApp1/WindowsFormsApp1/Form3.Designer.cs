
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbMaxNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpControls.SuspendLayout();
            this.grpOperation.SuspendLayout();
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
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.label1);
            this.grpControls.Controls.Add(this.cmbMaxNumber);
            this.grpControls.ForeColor = System.Drawing.Color.Gold;
            this.grpControls.Location = new System.Drawing.Point(12, 74);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(585, 171);
            this.grpControls.TabIndex = 2;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.button3);
            this.grpOperation.Controls.Add(this.button2);
            this.grpOperation.ForeColor = System.Drawing.Color.Gold;
            this.grpOperation.Location = new System.Drawing.Point(314, 310);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(284, 120);
            this.grpOperation.TabIndex = 3;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Operation";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(36)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(32, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(36)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Turquoise;
            this.button3.Location = new System.Drawing.Point(32, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Open Output Window";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cmbMaxNumber
            // 
            this.cmbMaxNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbMaxNumber.FormattingEnabled = true;
            this.cmbMaxNumber.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMaxNumber.Location = new System.Drawing.Point(128, 36);
            this.cmbMaxNumber.Name = "cmbMaxNumber";
            this.cmbMaxNumber.Size = new System.Drawing.Size(61, 21);
            this.cmbMaxNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dice Sides:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(622, 320);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaxNumber;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}