namespace Class_Pilot
{
    partial class Attendence
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAttend = new System.Windows.Forms.Button();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.btnStdRegister = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTutorEdit = new System.Windows.Forms.Button();
            this.StudentEditMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.btnStdEdit_AssignToClass = new System.Windows.Forms.Button();
            this.btnStdEdit_StdDetailsEdit = new System.Windows.Forms.Button();
            this.btnStdEditRemoveFromClass = new System.Windows.Forms.Button();
            this.btnTuteExamePaperSubmission = new System.Windows.Forms.Button();
            this.StuEditMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StudentEditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnAttend);
            this.flowLayoutPanel1.Controls.Add(this.btnCreateClass);
            this.flowLayoutPanel1.Controls.Add(this.btnStdRegister);
            this.flowLayoutPanel1.Controls.Add(this.btnPayments);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.btnTutorEdit);
            this.flowLayoutPanel1.Controls.Add(this.StudentEditMenu);
            this.flowLayoutPanel1.Controls.Add(this.btnTuteExamePaperSubmission);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 763);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 76);
            this.panel1.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(47, 18);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(152, 37);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Attendence";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAttend
            // 
            this.btnAttend.FlatAppearance.BorderSize = 0;
            this.btnAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAttend.ForeColor = System.Drawing.Color.White;
            this.btnAttend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttend.Location = new System.Drawing.Point(2, 82);
            this.btnAttend.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Padding = new System.Windows.Forms.Padding(62, 0, 8, 0);
            this.btnAttend.Size = new System.Drawing.Size(253, 49);
            this.btnAttend.TabIndex = 2;
            this.btnAttend.Text = "Attendence";
            this.btnAttend.UseVisualStyleBackColor = true;
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.FlatAppearance.BorderSize = 0;
            this.btnCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCreateClass.ForeColor = System.Drawing.Color.White;
            this.btnCreateClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateClass.Location = new System.Drawing.Point(2, 135);
            this.btnCreateClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Padding = new System.Windows.Forms.Padding(62, 0, 8, 0);
            this.btnCreateClass.Size = new System.Drawing.Size(253, 49);
            this.btnCreateClass.TabIndex = 3;
            this.btnCreateClass.Text = "Create Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            // 
            // btnStdRegister
            // 
            this.btnStdRegister.FlatAppearance.BorderSize = 0;
            this.btnStdRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdRegister.ForeColor = System.Drawing.Color.White;
            this.btnStdRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdRegister.Location = new System.Drawing.Point(2, 188);
            this.btnStdRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdRegister.Name = "btnStdRegister";
            this.btnStdRegister.Padding = new System.Windows.Forms.Padding(58, 0, 0, 0);
            this.btnStdRegister.Size = new System.Drawing.Size(253, 49);
            this.btnStdRegister.TabIndex = 4;
            this.btnStdRegister.Text = "Student Register";
            this.btnStdRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStdRegister.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(2, 241);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(62, 0, 8, 0);
            this.btnPayments.Size = new System.Drawing.Size(253, 49);
            this.btnPayments.TabIndex = 5;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(2, 294);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(62, 0, 8, 0);
            this.btnReports.Size = new System.Drawing.Size(253, 49);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnTutorEdit
            // 
            this.btnTutorEdit.FlatAppearance.BorderSize = 0;
            this.btnTutorEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTutorEdit.ForeColor = System.Drawing.Color.White;
            this.btnTutorEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutorEdit.Location = new System.Drawing.Point(2, 347);
            this.btnTutorEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnTutorEdit.Name = "btnTutorEdit";
            this.btnTutorEdit.Padding = new System.Windows.Forms.Padding(62, 0, 8, 0);
            this.btnTutorEdit.Size = new System.Drawing.Size(253, 49);
            this.btnTutorEdit.TabIndex = 7;
            this.btnTutorEdit.Text = "Tutor Edit";
            this.btnTutorEdit.UseVisualStyleBackColor = true;
            // 
            // StudentEditMenu
            // 
            this.StudentEditMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.StudentEditMenu.Controls.Add(this.btnStudentEdit);
            this.StudentEditMenu.Controls.Add(this.btnStdEdit_AssignToClass);
            this.StudentEditMenu.Controls.Add(this.btnStdEdit_StdDetailsEdit);
            this.StudentEditMenu.Controls.Add(this.btnStdEditRemoveFromClass);
            this.StudentEditMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StudentEditMenu.Location = new System.Drawing.Point(2, 400);
            this.StudentEditMenu.Margin = new System.Windows.Forms.Padding(2);
            this.StudentEditMenu.MaximumSize = new System.Drawing.Size(253, 208);
            this.StudentEditMenu.MinimumSize = new System.Drawing.Size(253, 54);
            this.StudentEditMenu.Name = "StudentEditMenu";
            this.StudentEditMenu.Size = new System.Drawing.Size(253, 54);
            this.StudentEditMenu.TabIndex = 1;
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.FlatAppearance.BorderSize = 0;
            this.btnStudentEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStudentEdit.ForeColor = System.Drawing.Color.White;
            this.btnStudentEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentEdit.Location = new System.Drawing.Point(2, 2);
            this.btnStudentEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Padding = new System.Windows.Forms.Padding(62, 0, 8, 0);
            this.btnStudentEdit.Size = new System.Drawing.Size(253, 49);
            this.btnStudentEdit.TabIndex = 8;
            this.btnStudentEdit.Text = "Student Edit";
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // btnStdEdit_AssignToClass
            // 
            this.btnStdEdit_AssignToClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnStdEdit_AssignToClass.FlatAppearance.BorderSize = 0;
            this.btnStdEdit_AssignToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEdit_AssignToClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdEdit_AssignToClass.ForeColor = System.Drawing.Color.White;
            this.btnStdEdit_AssignToClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEdit_AssignToClass.Location = new System.Drawing.Point(2, 55);
            this.btnStdEdit_AssignToClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEdit_AssignToClass.Name = "btnStdEdit_AssignToClass";
            this.btnStdEdit_AssignToClass.Size = new System.Drawing.Size(253, 49);
            this.btnStdEdit_AssignToClass.TabIndex = 10;
            this.btnStdEdit_AssignToClass.Text = "Assign to class";
            this.btnStdEdit_AssignToClass.UseVisualStyleBackColor = false;
            // 
            // btnStdEdit_StdDetailsEdit
            // 
            this.btnStdEdit_StdDetailsEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnStdEdit_StdDetailsEdit.FlatAppearance.BorderSize = 0;
            this.btnStdEdit_StdDetailsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEdit_StdDetailsEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdEdit_StdDetailsEdit.ForeColor = System.Drawing.Color.White;
            this.btnStdEdit_StdDetailsEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEdit_StdDetailsEdit.Location = new System.Drawing.Point(2, 108);
            this.btnStdEdit_StdDetailsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEdit_StdDetailsEdit.Name = "btnStdEdit_StdDetailsEdit";
            this.btnStdEdit_StdDetailsEdit.Size = new System.Drawing.Size(253, 42);
            this.btnStdEdit_StdDetailsEdit.TabIndex = 11;
            this.btnStdEdit_StdDetailsEdit.Text = "Student Details Edit";
            this.btnStdEdit_StdDetailsEdit.UseVisualStyleBackColor = false;
            // 
            // btnStdEditRemoveFromClass
            // 
            this.btnStdEditRemoveFromClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnStdEditRemoveFromClass.FlatAppearance.BorderSize = 0;
            this.btnStdEditRemoveFromClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEditRemoveFromClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdEditRemoveFromClass.ForeColor = System.Drawing.Color.White;
            this.btnStdEditRemoveFromClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEditRemoveFromClass.Location = new System.Drawing.Point(2, 154);
            this.btnStdEditRemoveFromClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEditRemoveFromClass.Name = "btnStdEditRemoveFromClass";
            this.btnStdEditRemoveFromClass.Size = new System.Drawing.Size(253, 42);
            this.btnStdEditRemoveFromClass.TabIndex = 12;
            this.btnStdEditRemoveFromClass.Text = "Remove From Class";
            this.btnStdEditRemoveFromClass.UseVisualStyleBackColor = false;
            // 
            // btnTuteExamePaperSubmission
            // 
            this.btnTuteExamePaperSubmission.FlatAppearance.BorderSize = 0;
            this.btnTuteExamePaperSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuteExamePaperSubmission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTuteExamePaperSubmission.ForeColor = System.Drawing.Color.White;
            this.btnTuteExamePaperSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuteExamePaperSubmission.Location = new System.Drawing.Point(2, 458);
            this.btnTuteExamePaperSubmission.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuteExamePaperSubmission.Name = "btnTuteExamePaperSubmission";
            this.btnTuteExamePaperSubmission.Padding = new System.Windows.Forms.Padding(62, 0, 8, 0);
            this.btnTuteExamePaperSubmission.Size = new System.Drawing.Size(253, 49);
            this.btnTuteExamePaperSubmission.TabIndex = 10;
            this.btnTuteExamePaperSubmission.Text = "Tute/Exam";
            this.btnTuteExamePaperSubmission.UseVisualStyleBackColor = true;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1497, 763);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1515, 810);
            this.MinimumSize = new System.Drawing.Size(1515, 810);
            this.Name = "Attendence";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StudentEditMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAttend;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Button btnStdRegister;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTutorEdit;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Button btnTuteExamePaperSubmission;
        private System.Windows.Forms.FlowLayoutPanel StudentEditMenu;
        private System.Windows.Forms.Button btnStdEdit_AssignToClass;
        private System.Windows.Forms.Timer StuEditMenuTimer;
        private System.Windows.Forms.Button btnStdEdit_StdDetailsEdit;
        private System.Windows.Forms.Button btnStdEditRemoveFromClass;
    }
}