namespace SchoolSystem
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionalFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemUserRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsByClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStaffMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewByDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStudentWithABalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPaymentByClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalaryPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSchoolFeesPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentsWithZeroBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentSchoolFeesPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentFunctionalFeesPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeRecieptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolFeesPaymentReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionalFeesPaymentReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.viewRecordsToolStripMenuItem,
            this.checkPaymentsToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.deleteRecordsToolStripMenuItem,
            this.makeRecieptToolStripMenuItem,
            this.gradeToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentRegistrationToolStripMenuItem,
            this.staffRegistrationToolStripMenuItem,
            this.paymentRegistrationToolStripMenuItem,
            this.salaryRegistrationToolStripMenuItem,
            this.systemUserRegistrationToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // studentRegistrationToolStripMenuItem
            // 
            this.studentRegistrationToolStripMenuItem.Name = "studentRegistrationToolStripMenuItem";
            this.studentRegistrationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.studentRegistrationToolStripMenuItem.Text = "StudentRegistration";
            this.studentRegistrationToolStripMenuItem.Click += new System.EventHandler(this.studentRegistrationToolStripMenuItem_Click);
            // 
            // staffRegistrationToolStripMenuItem
            // 
            this.staffRegistrationToolStripMenuItem.Name = "staffRegistrationToolStripMenuItem";
            this.staffRegistrationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.staffRegistrationToolStripMenuItem.Text = "StaffRegistration";
            this.staffRegistrationToolStripMenuItem.Click += new System.EventHandler(this.staffRegistrationToolStripMenuItem_Click);
            // 
            // paymentRegistrationToolStripMenuItem
            // 
            this.paymentRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolFeesToolStripMenuItem,
            this.functionalFeesToolStripMenuItem});
            this.paymentRegistrationToolStripMenuItem.Name = "paymentRegistrationToolStripMenuItem";
            this.paymentRegistrationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.paymentRegistrationToolStripMenuItem.Text = "PaymentRegistration";
            // 
            // schoolFeesToolStripMenuItem
            // 
            this.schoolFeesToolStripMenuItem.Name = "schoolFeesToolStripMenuItem";
            this.schoolFeesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.schoolFeesToolStripMenuItem.Text = "SchoolFees";
            this.schoolFeesToolStripMenuItem.Click += new System.EventHandler(this.schoolFeesToolStripMenuItem_Click);
            // 
            // functionalFeesToolStripMenuItem
            // 
            this.functionalFeesToolStripMenuItem.Name = "functionalFeesToolStripMenuItem";
            this.functionalFeesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.functionalFeesToolStripMenuItem.Text = "FunctionalFees";
            this.functionalFeesToolStripMenuItem.Click += new System.EventHandler(this.functionalFeesToolStripMenuItem_Click);
            // 
            // salaryRegistrationToolStripMenuItem
            // 
            this.salaryRegistrationToolStripMenuItem.Name = "salaryRegistrationToolStripMenuItem";
            this.salaryRegistrationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.salaryRegistrationToolStripMenuItem.Text = "SalaryRegistration";
            this.salaryRegistrationToolStripMenuItem.Click += new System.EventHandler(this.salaryRegistrationToolStripMenuItem_Click);
            // 
            // systemUserRegistrationToolStripMenuItem
            // 
            this.systemUserRegistrationToolStripMenuItem.Name = "systemUserRegistrationToolStripMenuItem";
            this.systemUserRegistrationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.systemUserRegistrationToolStripMenuItem.Text = "SystemUserRegistration";
            this.systemUserRegistrationToolStripMenuItem.Click += new System.EventHandler(this.systemUserRegistrationToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allStudentToolStripMenuItem,
            this.staffRecordsToolStripMenuItem});
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.viewRecordsToolStripMenuItem.Text = "ViewRecords";
            // 
            // allStudentToolStripMenuItem
            // 
            this.allStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllStudentsToolStripMenuItem,
            this.viewStudentsByClassToolStripMenuItem});
            this.allStudentToolStripMenuItem.Name = "allStudentToolStripMenuItem";
            this.allStudentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.allStudentToolStripMenuItem.Text = "StudentsRecords";
            // 
            // viewAllStudentsToolStripMenuItem
            // 
            this.viewAllStudentsToolStripMenuItem.Name = "viewAllStudentsToolStripMenuItem";
            this.viewAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewAllStudentsToolStripMenuItem.Text = "ViewAllStudents";
            this.viewAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewAllStudentsToolStripMenuItem_Click);
            // 
            // viewStudentsByClassToolStripMenuItem
            // 
            this.viewStudentsByClassToolStripMenuItem.Name = "viewStudentsByClassToolStripMenuItem";
            this.viewStudentsByClassToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewStudentsByClassToolStripMenuItem.Text = "ViewStudentsByClass";
            this.viewStudentsByClassToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsByClassToolStripMenuItem_Click);
            // 
            // staffRecordsToolStripMenuItem
            // 
            this.staffRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllStaffMembersToolStripMenuItem,
            this.viewByDepartmentToolStripMenuItem});
            this.staffRecordsToolStripMenuItem.Name = "staffRecordsToolStripMenuItem";
            this.staffRecordsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.staffRecordsToolStripMenuItem.Text = "StaffRecords";
            // 
            // viewAllStaffMembersToolStripMenuItem
            // 
            this.viewAllStaffMembersToolStripMenuItem.Name = "viewAllStaffMembersToolStripMenuItem";
            this.viewAllStaffMembersToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewAllStaffMembersToolStripMenuItem.Text = "ViewAllStaffMembers";
            this.viewAllStaffMembersToolStripMenuItem.Click += new System.EventHandler(this.viewAllStaffMembersToolStripMenuItem_Click);
            // 
            // viewByDepartmentToolStripMenuItem
            // 
            this.viewByDepartmentToolStripMenuItem.Name = "viewByDepartmentToolStripMenuItem";
            this.viewByDepartmentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewByDepartmentToolStripMenuItem.Text = "ViewByDepartment";
            this.viewByDepartmentToolStripMenuItem.Click += new System.EventHandler(this.viewByDepartmentToolStripMenuItem_Click);
            // 
            // checkPaymentsToolStripMenuItem
            // 
            this.checkPaymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkStudentWithABalanceToolStripMenuItem,
            this.cToolStripMenuItem,
            this.checkPaymentByClassToolStripMenuItem,
            this.viewAllPaymentsToolStripMenuItem,
            this.viewSalaryPaymentsToolStripMenuItem,
            this.viewItemRecordsToolStripMenuItem});
            this.checkPaymentsToolStripMenuItem.Name = "checkPaymentsToolStripMenuItem";
            this.checkPaymentsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.checkPaymentsToolStripMenuItem.Text = "CheckPayments";
            // 
            // checkStudentWithABalanceToolStripMenuItem
            // 
            this.checkStudentWithABalanceToolStripMenuItem.Name = "checkStudentWithABalanceToolStripMenuItem";
            this.checkStudentWithABalanceToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.checkStudentWithABalanceToolStripMenuItem.Text = "ViewStudentsWithASchoolFeesBalance";
            this.checkStudentWithABalanceToolStripMenuItem.Click += new System.EventHandler(this.checkStudentWithABalanceToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.cToolStripMenuItem.Text = "ViewStudentsWithZeroBalanceSchoolFees";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // checkPaymentByClassToolStripMenuItem
            // 
            this.checkPaymentByClassToolStripMenuItem.Name = "checkPaymentByClassToolStripMenuItem";
            this.checkPaymentByClassToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.checkPaymentByClassToolStripMenuItem.Text = "ViewSchoolFeesPaymentByClass";
            this.checkPaymentByClassToolStripMenuItem.Click += new System.EventHandler(this.checkPaymentByClassToolStripMenuItem_Click);
            // 
            // viewAllPaymentsToolStripMenuItem
            // 
            this.viewAllPaymentsToolStripMenuItem.Name = "viewAllPaymentsToolStripMenuItem";
            this.viewAllPaymentsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.viewAllPaymentsToolStripMenuItem.Text = "ViewAllSchoolFeesPayments";
            this.viewAllPaymentsToolStripMenuItem.Click += new System.EventHandler(this.viewAllPaymentsToolStripMenuItem_Click);
            // 
            // viewSalaryPaymentsToolStripMenuItem
            // 
            this.viewSalaryPaymentsToolStripMenuItem.Name = "viewSalaryPaymentsToolStripMenuItem";
            this.viewSalaryPaymentsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.viewSalaryPaymentsToolStripMenuItem.Text = "ViewSalaryPayments";
            this.viewSalaryPaymentsToolStripMenuItem.Click += new System.EventHandler(this.viewSalaryPaymentsToolStripMenuItem_Click);
            // 
            // viewItemRecordsToolStripMenuItem
            // 
            this.viewItemRecordsToolStripMenuItem.Name = "viewItemRecordsToolStripMenuItem";
            this.viewItemRecordsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.viewItemRecordsToolStripMenuItem.Text = "ViewFunctionalFeesPayments";
            this.viewItemRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewItemRecordsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSchoolFeesPaymentToolStripMenuItem,
            this.updateItemPaymentToolStripMenuItem,
            this.updateStudentRecordsToolStripMenuItem});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.logOutToolStripMenuItem.Text = "UpdatePayments";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // updateSchoolFeesPaymentToolStripMenuItem
            // 
            this.updateSchoolFeesPaymentToolStripMenuItem.Name = "updateSchoolFeesPaymentToolStripMenuItem";
            this.updateSchoolFeesPaymentToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.updateSchoolFeesPaymentToolStripMenuItem.Text = "UpdateSchoolFeesPayment";
            this.updateSchoolFeesPaymentToolStripMenuItem.Click += new System.EventHandler(this.updateSchoolFeesPaymentToolStripMenuItem_Click);
            // 
            // updateItemPaymentToolStripMenuItem
            // 
            this.updateItemPaymentToolStripMenuItem.Name = "updateItemPaymentToolStripMenuItem";
            this.updateItemPaymentToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.updateItemPaymentToolStripMenuItem.Text = "UpdateFunctionalFeesPayment";
            this.updateItemPaymentToolStripMenuItem.Click += new System.EventHandler(this.updateItemPaymentToolStripMenuItem_Click);
            // 
            // updateStudentRecordsToolStripMenuItem
            // 
            this.updateStudentRecordsToolStripMenuItem.Name = "updateStudentRecordsToolStripMenuItem";
            this.updateStudentRecordsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.updateStudentRecordsToolStripMenuItem.Text = "UpdateStudentRecords";
            this.updateStudentRecordsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentRecordsToolStripMenuItem_Click);
            // 
            // deleteRecordsToolStripMenuItem
            // 
            this.deleteRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteStudentsWithZeroBalanceToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.deleteStudentSchoolFeesPaymentToolStripMenuItem,
            this.deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem,
            this.deleteStudentFunctionalFeesPaymentToolStripMenuItem});
            this.deleteRecordsToolStripMenuItem.Name = "deleteRecordsToolStripMenuItem";
            this.deleteRecordsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.deleteRecordsToolStripMenuItem.Text = "DeleteRecords";
            // 
            // deleteStudentsWithZeroBalanceToolStripMenuItem
            // 
            this.deleteStudentsWithZeroBalanceToolStripMenuItem.Name = "deleteStudentsWithZeroBalanceToolStripMenuItem";
            this.deleteStudentsWithZeroBalanceToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.deleteStudentsWithZeroBalanceToolStripMenuItem.Text = "DeleteStudentsWithZeroBalanceSchoolFees";
            this.deleteStudentsWithZeroBalanceToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentsWithZeroBalanceToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.deleteStudentToolStripMenuItem.Text = "DeleteStudentFromSchoolDatabase";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // deleteStudentSchoolFeesPaymentToolStripMenuItem
            // 
            this.deleteStudentSchoolFeesPaymentToolStripMenuItem.Name = "deleteStudentSchoolFeesPaymentToolStripMenuItem";
            this.deleteStudentSchoolFeesPaymentToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.deleteStudentSchoolFeesPaymentToolStripMenuItem.Text = "DeleteStudentSchoolFeesPayment";
            this.deleteStudentSchoolFeesPaymentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentSchoolFeesPaymentToolStripMenuItem_Click);
            // 
            // deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem
            // 
            this.deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem.Name = "deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem";
            this.deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem.Text = "DeleteStudentsWithZeroBalanceFunctionalFees";
            this.deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem_Click);
            // 
            // deleteStudentFunctionalFeesPaymentToolStripMenuItem
            // 
            this.deleteStudentFunctionalFeesPaymentToolStripMenuItem.Name = "deleteStudentFunctionalFeesPaymentToolStripMenuItem";
            this.deleteStudentFunctionalFeesPaymentToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.deleteStudentFunctionalFeesPaymentToolStripMenuItem.Text = "DeleteStudentFunctionalFeesPayment";
            this.deleteStudentFunctionalFeesPaymentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentFunctionalFeesPaymentToolStripMenuItem_Click);
            // 
            // makeRecieptToolStripMenuItem
            // 
            this.makeRecieptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolFeesPaymentReceiptToolStripMenuItem,
            this.functionalFeesPaymentReceiptToolStripMenuItem});
            this.makeRecieptToolStripMenuItem.Name = "makeRecieptToolStripMenuItem";
            this.makeRecieptToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.makeRecieptToolStripMenuItem.Text = "Make Receipt";
            this.makeRecieptToolStripMenuItem.Click += new System.EventHandler(this.makeRecieptToolStripMenuItem_Click);
            // 
            // schoolFeesPaymentReceiptToolStripMenuItem
            // 
            this.schoolFeesPaymentReceiptToolStripMenuItem.Name = "schoolFeesPaymentReceiptToolStripMenuItem";
            this.schoolFeesPaymentReceiptToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.schoolFeesPaymentReceiptToolStripMenuItem.Text = "SchoolFeesPaymentReceipt";
            this.schoolFeesPaymentReceiptToolStripMenuItem.Click += new System.EventHandler(this.schoolFeesPaymentReceiptToolStripMenuItem_Click);
            // 
            // functionalFeesPaymentReceiptToolStripMenuItem
            // 
            this.functionalFeesPaymentReceiptToolStripMenuItem.Name = "functionalFeesPaymentReceiptToolStripMenuItem";
            this.functionalFeesPaymentReceiptToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.functionalFeesPaymentReceiptToolStripMenuItem.Text = "FunctionalFeesPaymentReceipt";
            this.functionalFeesPaymentReceiptToolStripMenuItem.Click += new System.EventHandler(this.functionalFeesPaymentReceiptToolStripMenuItem_Click);
            // 
            // gradeToolStripMenuItem
            // 
            this.gradeToolStripMenuItem.Name = "gradeToolStripMenuItem";
            this.gradeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gradeToolStripMenuItem.Text = "Grade";
            this.gradeToolStripMenuItem.Click += new System.EventHandler(this.gradeToolStripMenuItem_Click);
            // 
            // registerSystemToolStripMenuItem
            // 
            this.registerSystemToolStripMenuItem.Name = "registerSystemToolStripMenuItem";
            this.registerSystemToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.registerSystemToolStripMenuItem.Text = "Register System";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.staffToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.studentToolStripMenuItem.Text = "Accounts";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.studentToolStripMenuItem1.Text = "Student ";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(816, 444);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsByClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllStaffMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewByDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStudentWithABalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPaymentByClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolFeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionalFeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalaryPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemUserRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSchoolFeesPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentsWithZeroBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentSchoolFeesPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentFunctionalFeesPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeRecieptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolFeesPaymentReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionalFeesPaymentReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
    }
}