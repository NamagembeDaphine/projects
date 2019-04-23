using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class DeleteStudentSchoolFeesPayment : Form
    {
        databasehandler dh = new databasehandler();
        public DeleteStudentSchoolFeesPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SchoolFees fees = new SchoolFees();
                fees.AdmissionNo1 = textBox1.Text.ToString();
                dh.DeleteStudentSchoolFeesPayment(fees);
                MessageBox.Show("Deletion SuccessFull");
                textBox1.Text = null;
               
            }
            catch(Exception ex)
            {
                dh.InsertExceptions(ex);
            }
        }
    }
}