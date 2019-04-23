using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class DeleteStudentWithZeroBalanceFunctionalFees : Form
    {
        databasehandler dh = new databasehandler();
        public DeleteStudentWithZeroBalanceFunctionalFees()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPayment item = new ItemPayment();
                dh.DeleteStudentsWithZeroBalFunctionalFeesPayment(item);
                MessageBox.Show("Deletion SuccessFull");
            }
            catch(Exception ex)
            {
                dh.InsertExceptions(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}