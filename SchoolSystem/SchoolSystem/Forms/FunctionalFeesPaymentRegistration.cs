using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class FunctionalFeesPaymentRegistration : Form
    {
        public FunctionalFeesPaymentRegistration()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPayment item = new ItemPayment();

                item.DateOfPayment1 = dateTimePicker1.Value.ToString("dd/MM/yy");
                item.StudentName1 = textBox1.Text.ToString();
                item.AdmissionNo1 = textBox2.Text.ToString();
                item.Class1 = comboBox1.Text.ToString();
                item.Item1 = textBox3.Text.ToString();
                item.ItemFee1 = int.Parse(textBox4.Text);
                item.AmountPaid1 = int.Parse(textBox5.Text);

                item.Balance1 = item.ItemFee1 - item.AmountPaid1;

                textBox6.Text = item.Balance1.ToString();

                databasehandler dh = new databasehandler();
                dh.InsertItem(item);
                textBox1.Text = textBox2.Text = comboBox1.Text = textBox3.Text = textBox4.Text = textBox5.Text = null;
                MessageBox.Show("Operation Successful");
                textBox6.Text = null;
            }

            catch(Exception ex)
            {
                databasehandler dh = new databasehandler();
                dh.InsertExceptions(ex);
                MessageBox.Show("Already Exists");
            }

        }

        private void FunctionalFeesPaymentRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}