namespace ClientWinForms
{
    partial class FormStudents
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.btnSearchId = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSecName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameOfFam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.btgSearchAge = new System.Windows.Forms.Button();
            this.comboBoxFac = new System.Windows.Forms.ComboBox();
            this.btnGoToCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvStudents.Location = new System.Drawing.Point(22, 28);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(745, 340);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(657, 374);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(110, 42);
            this.btnSearchAll.TabIndex = 1;
            this.btnSearchAll.Text = "Search all users or update";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // btnSearchId
            // 
            this.btnSearchId.Location = new System.Drawing.Point(541, 374);
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.Size = new System.Drawing.Size(110, 23);
            this.btnSearchId.TabIndex = 2;
            this.btnSearchId.Text = "Search by id";
            this.btnSearchId.UseVisualStyleBackColor = true;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(886, 43);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(886, 83);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Second Name";
            // 
            // tbSecName
            // 
            this.tbSecName.Location = new System.Drawing.Point(886, 125);
            this.tbSecName.Name = "tbSecName";
            this.tbSecName.Size = new System.Drawing.Size(100, 20);
            this.tbSecName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name Of Family";
            // 
            // tbNameOfFam
            // 
            this.tbNameOfFam.Location = new System.Drawing.Point(886, 169);
            this.tbNameOfFam.Name = "tbNameOfFam";
            this.tbNameOfFam.Size = new System.Drawing.Size(100, 20);
            this.tbNameOfFam.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(787, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Age";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(886, 207);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(787, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Course";
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(886, 252);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(100, 20);
            this.tbCourse.TabIndex = 15;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(425, 374);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(110, 23);
            this.btnSearchName.TabIndex = 17;
            this.btnSearchName.Text = "Search by name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(193, 374);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(110, 23);
            this.btnSearchCourse.TabIndex = 19;
            this.btnSearchCourse.Text = "Search by course";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // btgSearchAge
            // 
            this.btgSearchAge.Location = new System.Drawing.Point(309, 374);
            this.btgSearchAge.Name = "btgSearchAge";
            this.btgSearchAge.Size = new System.Drawing.Size(110, 23);
            this.btgSearchAge.TabIndex = 20;
            this.btgSearchAge.Text = "Search by age";
            this.btgSearchAge.UseVisualStyleBackColor = true;
            this.btgSearchAge.Click += new System.EventHandler(this.btgSearchAge_Click);
            // 
            // comboBoxFac
            // 
            this.comboBoxFac.FormattingEnabled = true;
            this.comboBoxFac.Location = new System.Drawing.Point(22, 376);
            this.comboBoxFac.Name = "comboBoxFac";
            this.comboBoxFac.Size = new System.Drawing.Size(165, 21);
            this.comboBoxFac.TabIndex = 21;
            this.comboBoxFac.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // btnGoToCreate
            // 
            this.btnGoToCreate.Location = new System.Drawing.Point(790, 374);
            this.btnGoToCreate.Name = "btnGoToCreate";
            this.btnGoToCreate.Size = new System.Drawing.Size(196, 23);
            this.btnGoToCreate.TabIndex = 22;
            this.btnGoToCreate.Text = "Press to create";
            this.btnGoToCreate.UseVisualStyleBackColor = true;
            this.btnGoToCreate.Click += new System.EventHandler(this.btnGoToCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(790, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(196, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUpdate.Location = new System.Drawing.Point(693, 420);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(42, 13);
            this.lblUpdate.TabIndex = 24;
            this.lblUpdate.Text = "Update";
            this.lblUpdate.Visible = false;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGoToCreate);
            this.Controls.Add(this.comboBoxFac);
            this.Controls.Add(this.btgSearchAge);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameOfFam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSecName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnSearchId);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.dgvStudents);
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Button btnSearchId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSecName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameOfFam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.Button btgSearchAge;
        private System.Windows.Forms.ComboBox comboBoxFac;
        private System.Windows.Forms.Button btnGoToCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblUpdate;
    }
}

