namespace StudentAcademicManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDisplayStudents = new System.Windows.Forms.Button();
            this.btnRegistrationHistory = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtStudentNumber
            //
            this.txtStudentNumber.Location = new System.Drawing.Point(150, 20);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(200, 27);
            this.txtStudentNumber.TabIndex = 0;
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(150, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 1;
            //
            // txtQualification
            //
            this.txtQualification.Location = new System.Drawing.Point(150, 100);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(200, 27);
            this.txtQualification.TabIndex = 2;
            //
            // txtMarks
            //
            this.txtMarks.Location = new System.Drawing.Point(150, 140);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(200, 27);
            this.txtMarks.TabIndex = 3;
            //
            // btnAddStudent
            //
            this.btnAddStudent.Location = new System.Drawing.Point(20, 190);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(120, 30);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            //
            // btnDisplayStudents
            //
            this.btnDisplayStudents.Location = new System.Drawing.Point(150, 190);
            this.btnDisplayStudents.Name = "btnDisplayStudents";
            this.btnDisplayStudents.Size = new System.Drawing.Size(120, 30);
            this.btnDisplayStudents.TabIndex = 5;
            this.btnDisplayStudents.Text = "Display Students";
            this.btnDisplayStudents.Click += new System.EventHandler(this.btnDisplayStudents_Click);
            //
            // btnRegistrationHistory
            //
            this.btnRegistrationHistory.Location = new System.Drawing.Point(280, 190);
            this.btnRegistrationHistory.Name = "btnRegistrationHistory";
            this.btnRegistrationHistory.Size = new System.Drawing.Size(120, 30);
            this.btnRegistrationHistory.TabIndex = 6;
            this.btnRegistrationHistory.Text = "Registration History";
            this.btnRegistrationHistory.Click += new System.EventHandler(this.btnRegistrationHistory_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(410, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // lstOutput
            //
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.HorizontalScrollbar = true;
            this.lstOutput.Location = new System.Drawing.Point(20, 240);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(510, 173);
            this.lstOutput.TabIndex = 8;
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Number:";
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Qualification:";
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Marks (comma separated):";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegistrationHistory);
            this.Controls.Add(this.btnDisplayStudents);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentNumber);
            this.Name = "Form1";
            this.Text = "Student Academic Management System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDisplayStudents;
        private System.Windows.Forms.Button btnRegistrationHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
