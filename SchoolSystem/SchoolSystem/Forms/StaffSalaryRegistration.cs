using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class StaffSalaryRegistration : Form
    {
        public StaffSalaryRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Salary sal = new Salary();
                sal.DateOfPayment1 = dateTimePicker1.Value.ToString("dd/MM/yy");
                sal.PaidTo1 = textBox1.Text.ToString();
                sal.Department1 = comboBox1.Text.ToString();
                sal.Type1 = comboBox2.Text.ToString();
                sal.Salo1 = int.Parse(textBox2.Text);
                sal.AmountRecieved1 = int.Parse(textBox3.Text);

                sal.Balance1 = sal.Salo1 - sal.AmountRecieved1;

                textBox4.Text = sal.Balance1.ToString();
                databasehandler dh = new databasehandler();
                dh.InsertSalaryPayment(sal);
                textBox1.Text = comboBox1.Text = comboBox2.Text = textBox2.Text = textBox3.Text = null;
                MessageBox.Show("Opertional Sucessful");
                textBox4.Text = null;
            }
            catch (Exception ex)
            {
                databasehandler dh = new databasehandler();
                dh.InsertExceptions(ex);
            }
        }
    }
}