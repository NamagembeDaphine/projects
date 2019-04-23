using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class SchoolFeesPaymentRegisttration : Form
    {
        public SchoolFeesPaymentRegisttration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SchoolFees fees = new SchoolFees();
                fees.DateOfPayment1 = dateTimePicker1.Value.ToString("dd/MM/yy");
                fees.StudentName1 = textBox1.Text.ToString();
                fees.AdmissionNo1 = textBox2.Text.ToString();
                fees.Class1 = comboBox1.Text.ToString();
                fees.Term1 = comboBox2.Text.ToString();
                fees.Level1 = comboBox3.Text.ToString();
                fees.SchoolFeesAmount1 = int.Parse(textBox3.Text);
                fees.AmountPaid1 = int.Parse(textBox4.Text);

                fees.Balance1 = fees.SchoolFeesAmount1 - fees.AmountPaid1;

                textBox5.Text = fees.Balance1.ToString();
                databasehandler dh = new databasehandler();
                dh.InsertSchoolFeesPayment(fees);

                textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = textBox3.Text = textBox4.Text = null;
                MessageBox.Show("Operation Successful");
                textBox5.Text = null;
            }
            catch(Exception ex)
            {
                databasehandler dh = new databasehandler();
                dh.InsertExceptions(ex);
                MessageBox.Show("Already Exists");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SchoolFees fees = new SchoolFees();


            //    fees.AdmissionNo1 = textBox2.Text.ToString();

            //    databasehandler dh = new databasehandler();
            //    fees = dh.SelectOldAmountPaid(fees);
            //    textBox4.Text = fees.AmountPaid1.ToString();
            //     fees.AmountPaid1 = int.Parse(textBox4.Text);
            //    fees.SchoolFeesAmount1 = int.Parse(textBox3.Text);
            //    fees.CurrentAmountPaid1 = int.Parse(textBox5.Text);

            //    t


                

            //    fees.Balance1 = fees.SchoolFeesAmount1 - fees.AmountPaid1;

            //        dh.UpdateSchoolFeesPayment(fees);
            //        textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = textBox3.Text = textBox4.Text = null;
            //        textBox5.Text = fees.Balance1.ToString();
                   


               
               
                //{


                    //fees.SchoolFeesAmount1 = int.Parse(textBox3.Text);

                    //fees.AmountPaid1 = int.Parse(textBox4.Text);
                    //fees.AdmissionNo1 = textBox2.Text.ToString();

              
                    ////fees.AmountPaid1 = fees.AmountPaid1 + fees.AmountPaid1;
                    //fees.AmountPaid1 = fees.AmountPaid1 + fees.AmountPaid1;

                    //fees.Balance1 = fees.SchoolFeesAmount1 - fees.AmountPaid1;
                    //dh.UpdateSchoolFeesPayment(fees);
                    //textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = textBox3.Text = textBox4.Text = null;
                    //textBox5.Text = fees.Balance1.ToString();
                   
                    //textBox5.Text = null;
                //}
                //else 
                //{
                //    MessageBox.Show(fees.StatusDescription1);
                //}

                //}
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


        }
    }
}