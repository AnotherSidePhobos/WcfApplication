namespace ClientWinForms
{
    partial class CreateForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameOfFam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSecName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Course";
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(152, 295);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(100, 20);
            this.tbCourse.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Age";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(152, 250);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Faculty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Name Of Family";
            // 
            // tbNameOfFam
            // 
            this.tbNameOfFam.Location = new System.Drawing.Point(152, 168);
            this.tbNameOfFam.Name = "tbNameOfFam";
            this.tbNameOfFam.Size = new System.Drawing.Size(100, 20);
            this.tbNameOfFam.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Second Name";
            // 
            // tbSecName
            // 
            this.tbSecName.Location = new System.Drawing.Point(152, 124);
            this.tbSecName.Name = "tbSecName";
            this.tbSecName.Size = new System.Drawing.Size(100, 20);
            this.tbSecName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(152, 82);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 19;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(296, 293);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 23);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbFac
            // 
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Location = new System.Drawing.Point(152, 208);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(100, 21);
            this.cmbFac.TabIndex = 32;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 444);
            this.Controls.Add(this.cmbFac);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameOfFam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSecName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameOfFam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSecName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbFac;
    }
}