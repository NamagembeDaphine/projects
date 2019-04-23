using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Make_Receipt : Form
    {
        databasehandler dh = new databasehandler();
        public Make_Receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try 
            //{
            //    SchoolFees fees = new SchoolFees();
            //    fees.AdmissionNo1 = textBox1.Text.ToString();
            //    dh.SelectOldAmountPaid(fees);
            //    la

            //}
            //catch(Exception ex)
            //{
            //}
        }
    }
}