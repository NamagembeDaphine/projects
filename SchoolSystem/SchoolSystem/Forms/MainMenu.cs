using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class MainMenu : Form
    {
        databasehandler dh = new databasehandler();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRegistration SR = new StudentRegistration();
            SR.Show();
        }

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffMemberRegistration SMR = new StaffMemberRegistration();
            SMR.Show();
        }

        private void schoolFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolFeesPaymentRegisttration SF = new SchoolFeesPaymentRegisttration();
            SF.Show();
        }

        private void functionalFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionalFeesPaymentRegistration FF = new FunctionalFeesPaymentRegistration();
            FF.Show();
        }

        private void salaryRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StaffSalaryRegistration SS = new StaffSalaryRegistration();
            SS.Show();
        }

        private void systemUserRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginRegistration LR = new LoginRegistration();
            LR.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewItemRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITEM_REPORT IR = new ITEM_REPORT();
            IR.Show();
        }

        private void viewAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsDetails_Report SR = new StudentsDetails_Report();
            SR.Show();
        }

        private void viewStudentsByClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsDetailsClassReport SC = new StudentsDetailsClassReport();
            SC.Show();
        }

        private void viewAllStaffMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_Registration_Form SF = new Staff_Registration_Form();
            SF.Show();
        }

        private void viewByDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_Department_Report SR = new Staff_Department_Report();
            SR.Show();
        }

        private void viewSalaryPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryPaymentReport SP = new SalaryPaymentReport();
            SP.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_For_Students_With_Zero_Balance RB = new Report_For_Students_With_Zero_Balance();
            RB.Show();
        }

        private void checkStudentWithABalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_For_Students_With_A_Balance RS = new Report_For_Students_With_A_Balance();
            RS.Show();
        }

        private void viewAllPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_For_All_SchoolFeesPayment RF = new Report_For_All_SchoolFeesPayment();
            RF.Show();
        }

        private void checkPaymentByClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolFees_Class_Report SC = new SchoolFees_Class_Report();
            SC.Show();
        }

        private void updateSchoolFeesPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Payments__Form Up = new Update_Payments__Form();
            Up.Show();
        }

        private void updateItemPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Item_Form updateitem = new Update_Item_Form();
            updateitem.Show();
        }

        private void deleteStudentsWithZeroBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Deletion de = new Deletion();
            de.Show();
            
            //try 
            //{
            //    SchoolFees fees = new SchoolFees();
            //    dh.DeleteStudentsWithZeroBal(fees);
            //    MessageBox.Show("Deletion Request Was Successful");
            //}
            //catch(Exception ex)
            //{
            //    dh.InsertExceptions(ex);
            //}
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentFromSchoolDatabase DS = new DeleteStudentFromSchoolDatabase();
            DS.Show();
        }

        private void schoolFeesPaymentReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt rr = new Receipt();
            rr.Show();
        }

        private void makeRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void functionalFeesPaymentReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionalFeesReceipt FR = new FunctionalFeesReceipt();
            FR.Show();
        }

        private void deleteStudentSchoolFeesPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentSchoolFeesPayment DS = new DeleteStudentSchoolFeesPayment();
            DS.Show();
        }

        private void deleteStudentsWithZeroBalanceFunctionalFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentWithZeroBalanceFunctionalFees ss = new DeleteStudentWithZeroBalanceFunctionalFees();
            ss.Show();
        }

        private void deleteStudentFunctionalFeesPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentFunctionalFeePayment SFF = new DeleteStudentFunctionalFeePayment();
            SFF.Show();
        }

        private void updateStudentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudentsRecords UP = new UpdateStudentsRecords();
            UP.Show();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marks_input mm = new marks_input();
            mm.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentAccount sa = new StudentAccount();
            sa.Show();
        }
    }
}