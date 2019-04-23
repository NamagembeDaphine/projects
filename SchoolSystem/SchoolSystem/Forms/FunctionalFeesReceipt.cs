using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class FunctionalFeesReceipt : Form
    {
        databasehandler dh = new databasehandler();
        public FunctionalFeesReceipt()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                ItemPayment item = new ItemPayment();
                item.AdmissionNo1 = textBox1.Text.ToString();
                dh.SelectOldItemAmountPaid(item);
                label11.Text = item.StudentName1.ToString();
                label12.Text = item.AdmissionNo1.ToString();
                label13.Text = item.Class1.ToString();
                label14.Text = item.Item1.ToString();
                label15.Text = item.ItemFee1.ToString();
                label16.Text = item.AmountPaid1.ToString();
                label17.Text = item.Balance1.ToString();

            }
            catch(Exception ex)
            {
                dh.InsertExceptions(ex);
            }
        }
    }
}