using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class StaffMemberRegistration : Form
    {
        public StaffMemberRegistration()
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
                StaffMember staff = new StaffMember();
                staff.DateOfRegistration1 = dateTimePicker1.Value.ToString("dd/MM/yy");
                staff.Name1 = textBox2.Text.ToString();
                staff.Department1 = comboBox1.Text.ToString();
                staff.Type1 = comboBox2.Text.ToString();
                staff.Salary1 = int.Parse(textBox1.Text);

                databasehandler dh = new databasehandler();
                dh.InsertStaffMembers(staff);
                textBox1.Text = comboBox1.Text = comboBox2.Text = textBox2.Text = null;
                MessageBox.Show("Operation Successful");
            }
            catch(Exception ex)
            {
                databasehandler dh = new databasehandler();
                dh.InsertExceptions(ex);
                
            }

        }
    }
}