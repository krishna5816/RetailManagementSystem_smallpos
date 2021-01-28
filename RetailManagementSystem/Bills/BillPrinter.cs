using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Models;
using p = RetailControls.PrintHelper;
namespace RetailManagementSystem.Bills_form
{
    public class BillPrinter
    {
        public void setupPrinter()
        {
            PrintDialog = new PrintDialog();

            if (PrintDialog.ShowDialog() == DialogResult.OK)
            {

                PrinterSettings = PrintDialog.PrinterSettings;

                Stream SaveFileStream = File.Create(printerfile);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, PrintDialog.PrinterSettings);
                SaveFileStream.Close();



                isprintersetup = true;
            }
        }

        public delegate void PrintHandler(object sender, PrintPageEventArgs e);
        public event PrintHandler finishedprinting;
        Models.HamroSuperMarketEntities db = new Models.HamroSuperMarketEntities();
        public static Pen penBlack = new Pen(Color.Black);
        public static Pen penBlue = new Pen(Color.Blue);
        public static Brush brushBlack = new SolidBrush(Color.Black);
        public static Font Font = new Font("Times New Roman", 15);
        public static Font Font_bold = new Font("Times New Roman", 15, FontStyle.Bold);
        public static Font f_7_bold = new Font(Font.FontFamily, 8, FontStyle.Bold);
        public static Font f_7 = new Font(Font.FontFamily, 8);

        public static Font f_10_bold = new Font(Font.FontFamily, 10, FontStyle.Bold);
        public static Font f_10 = new Font(Font.FontFamily, 10);

        public static Font f_12_bold = new Font(Font.FontFamily, 12, FontStyle.Bold);
        public static Font f_12 = new Font(Font.FontFamily, 12);

        public static Font f_20_bold = new Font(Font.FontFamily, 20, FontStyle.Bold);
        public static Font f_20 = new Font(Font.FontFamily, 20);

        public static Font f_15_bold = new Font(Font.FontFamily, 15, FontStyle.Bold);
        public static Font f_15 = new Font(Font.FontFamily, 15);

        public static Font f_17_bold = new Font(Font.FontFamily, 17, FontStyle.Bold);
        public static Font f_17 = new Font(Font.FontFamily, 17);


        public bill Bills { get; set; }

        public PrintDocument printDocumentScroll { get; set; }
        public PrintDocument printDocumentA4 { get; set; }

        public PrinterSettings PrinterSettings { get; set; }
        public PageSettings PageSettings { get; set; }
        const string printerfile = @"printer.bin";
        const string printerfileA4 = @"printerA4.bin";
        const string page = @"page.bin";
        PageSetupDialog PageSetupDialog { get; set; }
        PrintDialog PrintDialog { get; set; }
        public bool isprintersetup = false;
        PrintPreviewDialog PrintPreviewDialog { get; set; }


        int printtype = 0;

        public dynamic getObj(string fname)
        {
            Stream openFileStream = File.OpenRead(fname);
            BinaryFormatter deserializer = new BinaryFormatter();
            var obj = deserializer.Deserialize(openFileStream);
            openFileStream.Close();
            return obj;

        }
        public void loadPrintsetting()
        {
            try
            {
                
                    PrinterSettings = getObj(printerfile) as System.Drawing.Printing.PrinterSettings;
                    printDocumentScroll.PrinterSettings = PrinterSettings;
                    isprintersetup = true;
                
            }
            catch (Exception)
            {
                setupPrinter();

            }

        }


       

        public void print(bill bill)
        {
            Bills = bill;
            if (!isprintersetup)
            {
                loadPrintsetting();
            }
            if (!isprintersetup)
            {

                return;
            }
            
                printDocumentScroll.PrinterSettings = PrinterSettings;
                printDocumentScroll.DefaultPageSettings = new PageSettings()
                {
                    PaperSize = new PaperSize("scroll", 280, 83149000)
                };
                printDocumentScroll.Print();
            
        }


        public BillPrinter()
        {
            printDocumentScroll = new PrintDocument();
            printDocumentScroll.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var width = 280;
            var top = 10;
            var left = 0;
            var g = e.Graphics;
            var w = e.PageBounds.Width - 100;
            top += printInBox(left, top, 260, g, "demo", p.f_12_bold, StringAlignment.Center, false);// 
            top += 5;
            top += printInBox(left, top, 260, g, "demo", p.f_7_bold, StringAlignment.Center, false);//
            top += 5;
            top += printInBox(left, top, 260, g, "Vat: demo", p.f_7_bold, StringAlignment.Center, false);//
            top += 5;
            top += printInBox(left, top, 260, g, "Phone:demo", p.f_7_bold, StringAlignment.Center, false);//
            top += 5;

            var height = e.PageSettings.PaperSize.Height;
            var b = new SolidBrush(Color.Black);
            var pp = new Pen(b, 1);
            var brushBlack = new SolidBrush(Color.Black);
           // var f_10 = new Font(Font.FontFamily, 10);
            var h = e.PageBounds.Height;

            var ratios = new double[] { 0, 0.1, 0.4, 0.1, 0.1, 0.3 };

          
            top += 20;
            top += 5;
            g.DrawLine(penBlack, left, top, left + width, top);
            top += 5;
            printInBox(left, top, width / 2, g, "Billno: " + Bills.id.ToString(), p.f_7, StringAlignment.Near);
            top += printInBox(160, top, 100, g, "Date: " + RetailControls.Helpers.DateStampToString(Bills.day.Value), p.f_7, StringAlignment.Near);
            top += 5;
            g.DrawLine(penBlack, left, top, left + width, top);
            top += 5;
            if (Bills.customer_id != null)
            {
                var customer = db.customers.Find(Bills.customer_id);
                if (customer != null)
                {
                    
                    top += printInBox(left, top, width, g, "Name: " + customer.name, p.f_7, StringAlignment.Near) + 3;
                    printInBox(left, top, width / 2, g, "Adress: " + customer.adress, p.f_7, StringAlignment.Near);
                    top += printInBox(left + width / 2, top, width / 2, g, "Phone no: "+customer.phone, p.f_7, StringAlignment.Near) + 5;

                    g.DrawLine(penBlack, left, top, left + width, top);
                    top += 5;
                }
            }

            top += RetailControls.Helper.drawtext(g,
                       new string[] {

                    "S.N",
                    "Particular",
                    "Rate",
                    "Dis",
                    "Qty",                   
                    "Total"

                    },
                       new double[]
                       {
                      0,0.09,0.3,0.2,0.1,0.1,0.2
                       }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Center
                        ) + 5;
            var bis = db.billitems.Where(o => o.bill_id == Bills.id).ToList();
            for (int i = 0; i < bis.Count; i++)
            {
                var item = bis.ElementAt(i);
                var itemname = db.items.Find(item.item_id).name;
                top += RetailControls.Helper.drawtext(g,
                       new string[] {

                    (i+1).ToString(),
                    itemname,
                    item.rate.Value.ToString("00"),
                    item.item_discount.ToString("00"),
                    item.quantity.Value.ToString("00"),
                    item.amount.Value.ToString("00"),
                    },
                       new double[]
                       {
                       0,0.09,0.3,0.2,0.1,0.1,0.2
                       }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Center
                        ) + 2;
            }
            g.DrawLine(penBlack, left, top, left + width, top);
            top += 5;
            top += RetailControls.Helper.drawtext(g,
                       new string[] {

                    "",
                    "",

                    "Sub Total",
                    Bills.grosstotal.Value.ToString()
                    },
                       new double[]
                       {
                       0,0.1,0.3,0.4,0.2
                       }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Far
                        ) + 2;
            top += RetailControls.Helper.drawtext(g,
                      new string[] {

                    "",
                    "",

                    "Flat Discount",
                    Bills.discount.Value.ToString()
                   },
                      new double[]
                      {
                       0,0.1,0.3,0.4,0.2
                      }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Far
                       ) + 2;
            top += RetailControls.Helper.drawtext(g,
                      new string[] {

                    "",
                    "",

                    "Tax Amount",
                    Bills.tax.Value.ToString()
                   },
                      new double[]
                      {
                       0,0.1,0.3,0.4,0.2
                      }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Far
                       ) + 2;
            top += RetailControls.Helper.drawtext(g,
                      new string[] {

                    "",
                    "",

                    "Tender Amount",
                    Bills.paid.Value.ToString()
                   },
                      new double[]
                      {
                       0,0.1,0.3,0.4,0.2
                      }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Far
                       ) + 2;
            top += RetailControls.Helper.drawtext(g,
                      new string[] {

                    "",
                    "",

                    "Due Amount",
                    Bills.due.Value.ToString()
                   },
                      new double[]
                      {
                       0,0.1,0.3,0.4,0.2
                      }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Far
                       ) + 2;
            top += RetailControls.Helper.drawtext(g,
                      new string[] {

                    "",
                    "",

                    "Return Amount",
                    Bills.returns.ToString()
                   },
                      new double[]
                      {
                       0,0.1,0.3,0.4,0.2
                      }, top, width - 10, p.f_7, brushBlack, 5, StringAlignment.Far
                       ) + 2;


            top += printInBox(left, top, 260, g, "Goods once sold cannot be returned.", p.f_7, StringAlignment.Center, false);
            top += printInBox(left, top, 260, g, "Thank you", p.f_7_bold, StringAlignment.Center, false);//
            top += 5;

        }
            public int printInBox(int x, int y, int width, Graphics g, string text, Font f, StringAlignment sa = StringAlignment.Near, bool drawrect = false)
            {
                var brush = new SolidBrush(Color.Black);
                var height = (int)g.MeasureString(text, f, width).Height;
                var rect = new Rectangle(x, y, width, height);
                var stringformat = new StringFormat()
                {
                    Alignment = sa
                };
                g.DrawString(text, f, brush, rect, stringformat);
                if (drawrect)
                {
                    g.DrawRectangle(new Pen(brush), rect);
                }
                return height;
            }
    }
}
