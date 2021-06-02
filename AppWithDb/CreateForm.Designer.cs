namespace AppWithDb
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
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // cmbFac
            // 
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Location = new System.Drawing.Point(141, 184);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(100, 21);
            this.cmbFac.TabIndex = 45;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(285, 269);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 23);
            this.btnCreate.TabIndex = 44;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Course";
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(141, 271);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(100, 20);
            this.tbCourse.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Age";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(141, 226);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Faculty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Name Of Family";
            // 
            // tbNameOfFam
            // 
            this.tbNameOfFam.Location = new System.Drawing.Point(141, 144);
            this.tbNameOfFam.Name = "tbNameOfFam";
            this.tbNameOfFam.Size = new System.Drawing.Size(100, 20);
            this.tbNameOfFam.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Second Name";
            // 
            // tbSecName
            // 
            this.tbSecName.Location = new System.Drawing.Point(141, 100);
            this.tbSecName.Name = "tbSecName";
            this.tbSecName.Size = new System.Drawing.Size(100, 20);
            this.tbSecName.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 33;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(501, 344);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.Button btnCreate;
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
    }
}