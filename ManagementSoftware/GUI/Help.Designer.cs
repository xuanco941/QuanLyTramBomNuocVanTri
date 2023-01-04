namespace ManagementSoftware.GUI
{
    partial class Help
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.pdfDocumentView1 = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.SuspendLayout();
            // 
            // pdfDocumentView1
            // 
            this.pdfDocumentView1.AutoScroll = true;
            this.pdfDocumentView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pdfDocumentView1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.pdfDocumentView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfDocumentView1.EnableContextMenu = true;
            this.pdfDocumentView1.HorizontalScrollOffset = 0;
            this.pdfDocumentView1.IsTextSearchEnabled = true;
            this.pdfDocumentView1.IsTextSelectionEnabled = true;
            this.pdfDocumentView1.Location = new System.Drawing.Point(0, 0);
            messageBoxSettings2.EnableNotification = true;
            this.pdfDocumentView1.MessageBoxSettings = messageBoxSettings2;
            this.pdfDocumentView1.MinimumZoomPercentage = 50;
            this.pdfDocumentView1.Name = "pdfDocumentView1";
            this.pdfDocumentView1.PageBorderThickness = 1;
            pdfViewerPrinterSettings2.Copies = 1;
            pdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings2.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings2.PrintLocation")));
            pdfViewerPrinterSettings2.ShowPrintStatusDialog = true;
            this.pdfDocumentView1.PrinterSettings = pdfViewerPrinterSettings2;
            this.pdfDocumentView1.ReferencePath = null;
            this.pdfDocumentView1.ScrollDisplacementValue = 0;
            this.pdfDocumentView1.ShowHorizontalScrollBar = true;
            this.pdfDocumentView1.ShowVerticalScrollBar = true;
            this.pdfDocumentView1.Size = new System.Drawing.Size(942, 480);
            this.pdfDocumentView1.SpaceBetweenPages = 8;
            this.pdfDocumentView1.TabIndex = 0;
            textSearchSettings2.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings2.HighlightAllInstance = true;
            textSearchSettings2.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfDocumentView1.TextSearchSettings = textSearchSettings2;
            this.pdfDocumentView1.ThemeName = "Default";
            this.pdfDocumentView1.VerticalScrollOffset = 0;
            this.pdfDocumentView1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 480);
            this.Controls.Add(this.pdfDocumentView1);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfDocumentView1;
    }
}