using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;





namespace SchoolSystem
{
    public partial class SchoolFees_Class_Report : Form
    {
        Bitmap bitmap;

        //int iCellHeight;
        //int iTotalWidth;
        //int iRow;
        //bool bNewPage;
        //bool bFirstPage;
        //int iHeaderHeight;
        //ArrayList arrColumnLefts = new ArrayList();
        //ArrayList arrColumnWidth = new ArrayList();
        //ArrayList arrColumnLeft = new ArrayList();
        //StringFormat strFormat;




       
       // bool bFirstPage;
       // double iTotalWidith;
       // double iTotalWidth;
       // bool bNewPage;
       //int iRow;
       // int iHeaderHeight;
       // bool arrColumnLeft;
       // bool arrColumnWidths;
       //  int iCellHeight;
       // int arrColumnsLefts;

        public SchoolFees_Class_Report()
        {
            InitializeComponent();
            //GetEnumerator();
           
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return(IEnumerator)this;
        //}
          


        private void button1_Click(object sender, EventArgs e)
        {
            SchoolFees fees = new SchoolFees();
            fees.Class1 = textBox1.Text.ToString();
            databasehandler dh = new databasehandler();
            DataTable dt = new DataTable();
            dt = dh.SelectSchoolFeesPaymentClass(fees);
            dataGridView1.DataSource = dt;
            textBox1.Text = null;
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
                       

            //printDocument1 doc = new printDocument1(this.dataGridView1,this.dataGridView1.Font,true);
            

            ////Open the print dialog
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDocument1;
            //printDialog.UseEXDialog = true;

            //// get document
            //if(DialogResult.OK == printDialog.ShowDialog())
            //{
            //    printDocument1.Print();
            //}



            //show the print preview dialog

            //printPreviewDialog1.Document = printDocument1;

            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();
            //printDocument1.Print();

            ////resize datagridview to full height
            //int height = dataGridView1.Height;

            //dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            ////create a bitmap and draw the datagridview on it

            //bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            //dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            ////resize datagridview back to original heihght
            //dataGridView1.Height = height;


            ////show the print preview dialog

            //printPreviewDialog1.ClientSize = new Size(400, 300);
            //printPreviewDialog1.Name = "printpreviewdap";
            //printPreviewDialog1.UseAntiAlias = true;
        
            //printPreviewDialog1.Document = printDocument1;


            ////printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();

            //printDocument1.Print();
               

               
            //GridPrintDocument doc = new GridPrintDocument(this.dataGridView1, this.dataGridView1.Font, true);
            //GridSelectedArea SelArea = new GridSelectedArea(1,2,10, dataGridView1.RowCount -3);
            //doc.DocumentName1 = "previewtest";
            //printPreviewDialog1 = new PrintPreviewDialog1();
            //printPreviewDialog1.ClientSize = new Size(400, 300);
            //printPreviewDialog1.UseAntiAlias = true;
            //printPreviewDialog1.Document = doc;
            //printPreviewDialog1.ShowDialog();
           




            ////resize datagridview to full height
            //int height = dataGridView1.Height;

            //dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            ////create a bitmap and draw the datagridview on it

            ////bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            ////dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            //bitmap = new Bitmap(this.dataGridView1, this.dataGridView1.Font, true);
            //grids
            ////resize datagridview back to original heihght
            //dataGridView1.Height = height;


            ////show the print preview dialog;

          
            //printDocument1.Print();
               
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            
        
          
            //Graphics g = e.Graphics;
            //dataGridPrinter1 Printer = new dataGridPrinter1();
            ////draw a label title for grid

            ////DrawTopLabel(g);

            ////draw the datagrid using the drawdatagrid
            ////bool more = dataGridPrinter1.DrawDataGrid(g);
            ////bool more;

            ////if (more == true) 
            ////{
            ////    e.HasMorePages = true;
            ////    Printer.PageNumber1++;
                
                
            //}

            e.Graphics.DrawImage(bitmap, 0, 0);


            //try
            //{
            ////    //set the left margin
            //int iLeftMargin = e.MarginBounds.Left;

            ////    //set the top margin
            //int iTopMargin = e.MarginBounds.Top;

            ////    //whether more pages have to print or not
            //bool bMorePagesToPrint = false;
            //int iTmpWidth = 0;

            ////    //for the fistpageto print set the cell width and header height
                
            //    if (bFirstPage)

            //    {
                   
            //           foreach(DataGridViewColumn GridCol in dataGridView1.Columns)
            //        {
                           
            //            iTmpWidth = (int)(Math.Floor((double)
            //             ((double)GridCol.Width /
            //             (double)iTotalWidth *
            //             (double)iTotalWidth *
            //             ((double)e.MarginBounds.Width /
            //             (double)iTotalWidth))));

            //            iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
            //                GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

            ////            //save width and height of headers

            //            arrColumnLeft.Add(iLeftMargin);
            //            arrColumnWidth.Add(iTmpWidth);
            //            iLeftMargin += iTmpWidth;


            //        }
            //    }

            ////    //Looptill all the gridrows not get printed

            //    while(iRow < dataGridView1.Rows.Count - 1)
            //    {
            //        DataGridViewRow GridRow = dataGridView1.Rows[iRow];

            ////        //set the cell height

            //        iCellHeight = GridRow.Height + 5;
            //        int iCount = 0;

            ////        //check whether the current page setting allows more rows to print

            //        if (iTopMargin + iCellHeight > e.MarginBounds.Height + e.MarginBounds.Top)
            //        {

            //            bNewPage = true;
            //            bFirstPage = false;
            //            bMorePagesToPrint = true;
            //            break;

            //        }

            //        else 
            //        {
            //            if (bNewPage) 
            //            {
            ////        //        //draw header 

            //                e.Graphics.DrawString("CLASS SCHOOLFEES REPORT", new Font(dataGridView1.Font, FontStyle.Bold),
            //                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("CLASS SCHOOLFEES REPORT",
            //                    new Font(dataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13);
            //                String strDate = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToShortTimeString();

            ////        //        //draw date
            //                e.Graphics.DrawString(strDate, new Font(dataGridView1.Font, FontStyle.Bold), Brushes.Black,
            //                    e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, new Font
            //                    (dataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("CLASS SCHOOLFEES REPORT",
            //                    new Font(new Font(dataGridView1.Font, FontStyle.Bold),
            //                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

            ////                //draw columns
                       

            //                iTopMargin = e.MarginBounds.Top;
            //                foreach (DataGridViewColumn GridCol in this.dataGridView1.Columns)
            //                {
            //                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
            //                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
            //                        (int)arrColumnWidth[iCount], iHeaderHeight));
            //                    //e.Graphics.DrawString(Pens.Black, new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
            //                    //    (int)arrColumnWidth[iCount], iHeaderHeight));
            //                    e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
            //                        new SolidBrush(GridCol.InheritedStyle.ForeColor),
            //                        new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
            //                        (int)arrColumnWidth[iCount], iHeaderHeight), strFormat);
            //                    iCount++;
            //                }

            //                  bNewPage = false;
            //                  iTopMargin += iHeaderHeight;
                              

                                       
            //            }

            //            iCount = 0;
            ////            // draw column contents

            //            foreach(DataGridViewCell cel in GridRow.Cells)
            //            {
            //                if (cel.Value != null)
            //                {
            //                    e.Graphics.DrawString(cel.Value.ToString(), cel.InheritedStyle.Font, new SolidBrush(cel.InheritedStyle.ForeColor),
            //                        new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
            //                        (int)arrColumnWidth[iCount],
            //                        (float)iCellHeight),
            //                        strFormat);
            //                }

            ////                //drawing cell borderss

            //                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
            //                    (int)arrColumnWidth[iCount], iCellHeight));
            //                iCount++;

            //            }
            //        }

            //        iRow++;
            //        iTopMargin += iCellHeight;

            //    }
                
            ////    //if more lines exist, print another page

            //    if (bMorePagesToPrint)
            //        e.HasMorePages = true;
            //    else
            //        e.HasMorePages = false;


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

            
        }
        }