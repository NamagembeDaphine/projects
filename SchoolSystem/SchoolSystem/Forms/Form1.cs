using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 100);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

      
       

        private void button2_Click(object sender, EventArgs e)
        {


            //MainMenu MM = new MainMenu();
            //MM.Show();


            UserLogin user = new UserLogin();
            databasehandler dh = new databasehandler();
            user.UserName1 = textBox1.Text.ToString();
            user.PassWord1 = textBox2.Text.ToString();
            if (string.IsNullOrEmpty(user.UserName1))
            {
                MessageBox.Show("Enter Username and password");

            }
            else if (string.IsNullOrEmpty(user.PassWord1))
            {

                MessageBox.Show("Enter username and password");
            }
            else
            {
                try
                {


                    user = dh.SelectUser(user);
                    if (user.StatusCode1 == "0")
                    {

                        user.UserName1 = textBox1.Text = user.PassWord1 = textBox2.Text = null;
                        MainMenu MM = new MainMenu();
                        MM.Show();

                    }
                    else
                    {
                        MessageBox.Show(user.StatusDescription1);
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show("check your username or password");
                }

            }
            //if (textBox1.Text == null)
            //{
            //    MessageBox.Show("Please enter username and password");
            //    user.UserName1 = textBox1.Text.ToString();
            //    user.PassWord1 = textBox2.Text.ToString();
            //    user = dh.SelectUser(user);
            //    MainMenu MM = new MainMenu();
            //    MM.Show();
            //}
            //else
            //{
            //    user = dh.SelectUser(user);
            //    MainMenu MM = new MainMenu();
            //    MM.Show();

            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}