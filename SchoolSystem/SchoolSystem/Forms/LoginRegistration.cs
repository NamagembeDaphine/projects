using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class LoginRegistration : Form
    {
        public LoginRegistration()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserLogin user = new UserLogin();
                user.DateOfRegistration1 = dateTimePicker1.Value.ToString("dd/MM/yy");
                user.Name1 = textBox2.Text.ToString();
                user.Type1 = comboBox1.Text.ToString();
                user.Gender1 = comboBox2.Text.ToString();
                user.UserName1 = textBox5.Text.ToString();
                user.PassWord1 = textBox6.Text.ToString();

                databasehandler dh = new databasehandler();
                dh.InsertUser(user);
                textBox2.Text = comboBox1.Text = comboBox2.Text = textBox5.Text = textBox6.Text = null;
                MessageBox.Show(user.StatusDescription1 = "RegistrationSuccessfull");
            }
            catch(Exception ex)
            {
                databasehandler dh = new databasehandler();
                dh.InsertExceptions(ex);
            }
        }
    }
}