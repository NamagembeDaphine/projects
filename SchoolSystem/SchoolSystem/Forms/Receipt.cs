using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Receipt : Form
    {
        Bitmap memoryImage;
        databasehandler dh = new databasehandler();
        public Receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height,myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                SchoolFees fees = new SchoolFees();
                fees.AdmissionNo1 = textBox1.Text.ToString();
                dh.SelectOldAmountPaid(fees);
                label11.Text = fees.StudentName1.ToString();
                label12.Text = fees.AdmissionNo1.ToString();
                label13.Text = fees.Class1.ToString();
                label14.Text = fees.Term1.ToString();
                label15.Text = fees.Level1.ToString();
                label16.Text = fees.SchoolFeesAmount1.ToString();
                label17.Text = fees.AmountPaid1.ToString();
                label18.Text = fees.Balance1.ToString();


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}