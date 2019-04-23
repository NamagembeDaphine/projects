using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class DeleteStudentFunctionalFeePayment : Form
    {
        databasehandler dh = new databasehandler();
        public DeleteStudentFunctionalFeePayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                
                ItemPayment item = new ItemPayment();
                item.AdmissionNo1 = textBox1.Text.ToString();
                dh.DeleteStudentFunctionalFeesPayment(item);
                MessageBox.Show("Deletion Successfull");
                textBox1.Text = null;


            }
            catch(Exception ex)
            {
                dh.InsertExceptions(ex);
            }
        }
    }
}