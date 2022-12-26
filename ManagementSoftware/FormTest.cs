using Custom;
using ManagementSoftware.Properties;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms.Barcode;
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
    public partial class FormTest : Form
    {

        public FormTest()
        {
            InitializeComponent();

            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;


            sfBarcode1.Symbology = BarcodeSymbolType.Code128B;
            sfBarcode1.Text = "ABC-123-abc-A123";
            sfBarcode1.TextGapHeight = 5;

            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);




            pictureBox1.Image = Resources.check;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 700;
            timer.Elapsed += Tick;
            timer.Start();


            DataGridViewColumn clumn1 = new DataGridViewTextBoxColumn();
            clumn1.HeaderText = "TESTHeader1";
            clumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(clumn1);

            DataGridViewProgressColumn column = new DataGridViewProgressColumn();
            clumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.HeaderText = "Progress";
            dataGridView1.Columns.Add(column);
        }
        public bool a;
        private void Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAA");
            if(a)
            {
                System.Diagnostics.Debug.WriteLine("BBBBBBBBBBBBBBBBBBBBBBBBBBBB");
                pictureBox1.Image = Resources.check;
                a = false;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC");
                pictureBox1.Image = Resources.backpage;
                a = true;
            }
        }

        void TestDGV()
        {
  
            object[] row1 = new object[] { "abc",50.23 };
            object[] row2 = new object[] { "axc", 99.9 };

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);

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
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panelPrintBarcode.Width / 2), this.panelPrintBarcode.Location.Y);
        }
        public void Print(Panel pnl)
        {
            Panel pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printDocument1;
            previewdlg.ShowDialog();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Print(this.panelPrintBarcode);
        }





        private void button2bgrwk_Click(object sender, EventArgs e)
        {
            // start the animation
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // start the job
            button2bgrwk.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            LoadExcel();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button2bgrwk.Enabled = true;
            progressBar1.Visible = false;
        }

        private void LoadExcel()
        {
            // some work takes 5 sec
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestDGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }







        public Panel CreateFloatingPanel(Panel originalPanel)
        {
            Bitmap bmp = new Bitmap(originalPanel.Width,
                originalPanel.Height);
            Rectangle rect = new Rectangle(0, 0,
                bmp.Width, bmp.Height);
            originalPanel.DrawToBitmap(bmp, rect);
            foreach (Control ctrl in originalPanel.Controls)
            {
                ctrl.Visible = false;
            }
            using (Graphics g = Graphics.FromHwnd(originalPanel.Handle))
            {
                g.DrawImage(bmp, 0, 0);
                bmp.Dispose();
                SolidBrush brush =
                    new SolidBrush(Color.FromArgb(128, Color.Gray));
                g.FillRectangle(brush, rect);
                brush.Dispose();
            }
            Panel floater = new Panel();
            floater.Size = originalPanel.Size;
            floater.Left = originalPanel.Left - 50;
            floater.Top = originalPanel.Top - 50;
            this.Controls.Add(floater);
            floater.BringToFront();
            return floater;
        }
    }
}
