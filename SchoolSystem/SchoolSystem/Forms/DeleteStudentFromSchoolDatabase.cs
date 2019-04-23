using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class DeleteStudentFromSchoolDatabase : Form
    {
        public DeleteStudentFromSchoolDatabase()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Student stud = new Student();
                stud.AdmissionNo1 = textBox1.Text.ToString();
                databasehandler dh = new databasehandler();
                dh.DeleteStudentFromDb(stud);
                MessageBox.Show("Deletion Successfull");
                textBox1.Text = null;
            }
            catch(Exception ex)
            {
                databasehandler dh = new databasehandler();
                dh.InsertExceptions(ex);
            }
        }
    }
}