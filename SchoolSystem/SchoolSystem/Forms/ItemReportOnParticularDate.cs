using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class ItemReportOnParticularDate : Form
    {
        Bitmap bitmap;
        public ItemReportOnParticularDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPayment item = new ItemPayment();
                item.DateOfPayment1 = dateTimePicker1.Value.ToString("dd/MM/yy");
                databasehandler dh = new databasehandler();
                DataTable dt = new DataTable();
                dt = dh.SelectItemByDate(item);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                databasehandler dh = new databasehandler();
                dh.InsertExceptions(ex);
            }
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                       
        //    //resize datagridview to full height
        //    int height = dataGridView1.Height;

        //    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

        //    //create a bitmap and draw the datagridview on it

        //    bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
        //    dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

        //    //resize datagridview back to original heihght
        //    dataGridView1.Height = height;


        //    //show the print preview dialog

        //    printPreviewDialog1.Document = printDocument1;

        //    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
        //    printPreviewDialog1.ShowDialog();
        //    printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}