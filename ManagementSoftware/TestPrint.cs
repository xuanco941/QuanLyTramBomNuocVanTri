using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware
{
    public partial class TestPrint : Form
    {
       /* public TestPrint()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);


            //for (int i = 0; i < 31; i++)
            //{
            //    Form1 form = new Form1();
            //    form.TopLevel = false;
            //    panel1.Controls.Add(form);
            //    form.FormBorderStyle = FormBorderStyle.None;
            //    form.Dock = DockStyle.Top;
            //    form.Show();
            //}

        }

        private void TestPrint_Load(object sender, EventArgs e)
        {
            Print(this.panel1);

        }
        Bitmap MemoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }




        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void Print(Panel pnl)
        {
            GetPrintArea(pnl);
            previewdlg.Document = printDocument1;
            previewdlg.ShowDialog();
        }


      
        private void button1_Click(object sender, EventArgs e)
        {

        }
       */
    }
}
