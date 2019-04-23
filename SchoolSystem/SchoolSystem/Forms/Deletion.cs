using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Deletion : Form
    {
        databasehandler dh = new databasehandler();
        public Deletion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                   SchoolFees fees = new SchoolFees();
                    dh.DeleteStudentsWithZeroBal(fees);
                   MessageBox.Show("Deletion Successfull");
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