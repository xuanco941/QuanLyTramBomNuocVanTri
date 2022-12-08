﻿namespace ManagementSoftware
{
    partial class FormTest
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
            this.sfBarcode1 = new Syncfusion.Windows.Forms.Barcode.SfBarcode();
            this.radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.digitalGauge2 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.integerTextBox1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelPrintBarcode = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2bgrwk = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).BeginInit();
            this.panelPrintBarcode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfBarcode1
            // 
            this.sfBarcode1.DarkBarColor = System.Drawing.Color.Black;
            this.sfBarcode1.DisplayText = true;
            this.sfBarcode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfBarcode1.LightBarColor = System.Drawing.Color.White;
            this.sfBarcode1.Location = new System.Drawing.Point(0, 0);
            this.sfBarcode1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.sfBarcode1.Name = "sfBarcode1";
            this.sfBarcode1.Size = new System.Drawing.Size(239, 73);
            this.sfBarcode1.Symbology = Syncfusion.Windows.Forms.Barcode.BarcodeSymbolType.QRBarcode;
            this.sfBarcode1.SymbologySettings = null;
            this.sfBarcode1.TabIndex = 0;
            this.sfBarcode1.TextAlignment = Syncfusion.Windows.Forms.Barcode.BarcodeTextAlignment.Center;
            this.sfBarcode1.TextColor = System.Drawing.Color.Black;
            this.sfBarcode1.TextGapHeight = 5F;
            // 
            // radialGauge1
            // 
            this.radialGauge1.ArcThickness = 2F;
            this.radialGauge1.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            this.radialGauge1.EnableCustomNeedles = false;
            this.radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            this.radialGauge1.FrameThickness = 12;
            this.radialGauge1.GaugeLabel = "Gauge";
            this.radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radialGauge1.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            this.radialGauge1.Location = new System.Drawing.Point(224, 92);
            this.radialGauge1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            this.radialGauge1.Name = "radialGauge1";
            this.radialGauge1.ShowTicks = true;
            this.radialGauge1.Size = new System.Drawing.Size(261, 261);
            this.radialGauge1.TabIndex = 1;
            // 
            // digitalGauge2
            // 
            this.digitalGauge2.DisplayRecordIndex = 0;
            this.digitalGauge2.Location = new System.Drawing.Point(57, 27);
            this.digitalGauge2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digitalGauge2.MaximumSize = new System.Drawing.Size(583, 208);
            this.digitalGauge2.MinimumSize = new System.Drawing.Size(105, 104);
            this.digitalGauge2.Name = "digitalGauge2";
            this.digitalGauge2.Size = new System.Drawing.Size(210, 104);
            this.digitalGauge2.TabIndex = 3;
            // 
            // linearGauge1
            // 
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(117, 350);
            this.linearGauge1.MajorTicksHeight = 15;
            this.linearGauge1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.linearGauge1.MinimumSize = new System.Drawing.Size(100, 50);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            this.linearGauge1.ScaleColor = System.Drawing.Color.Gray;
            this.linearGauge1.Size = new System.Drawing.Size(350, 155);
            this.linearGauge1.TabIndex = 4;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(369, 75);
            this.chartControl1.Legend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(588, 180);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(478, 279);
            this.chartControl1.TabIndex = 5;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.VisualTheme = "";
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.BeforeTouchSize = new System.Drawing.Size(116, 23);
            this.integerTextBox1.IntegerValue = ((long)(1));
            this.integerTextBox1.Location = new System.Drawing.Point(4, 11);
            this.integerTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.Size = new System.Drawing.Size(116, 23);
            this.integerTextBox1.TabIndex = 6;
            this.integerTextBox1.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // panelPrintBarcode
            // 
            this.panelPrintBarcode.Controls.Add(this.sfBarcode1);
            this.panelPrintBarcode.Location = new System.Drawing.Point(735, 41);
            this.panelPrintBarcode.Name = "panelPrintBarcode";
            this.panelPrintBarcode.Size = new System.Drawing.Size(239, 73);
            this.panelPrintBarcode.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2bgrwk
            // 
            this.button2bgrwk.Location = new System.Drawing.Point(127, 11);
            this.button2bgrwk.Name = "button2bgrwk";
            this.button2bgrwk.Size = new System.Drawing.Size(75, 23);
            this.button2bgrwk.TabIndex = 10;
            this.button2bgrwk.Text = "button2";
            this.button2bgrwk.UseVisualStyleBackColor = true;
            this.button2bgrwk.Click += new System.EventHandler(this.button2bgrwk_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(550, 463);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(293, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.integerTextBox1);
            this.panel1.Controls.Add(this.button2bgrwk);
            this.panel1.Location = new System.Drawing.Point(321, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 55);
            this.panel1.TabIndex = 12;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelPrintBarcode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.linearGauge1);
            this.Controls.Add(this.digitalGauge2);
            this.Controls.Add(this.radialGauge1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormTest";
            this.Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).EndInit();
            this.panelPrintBarcode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Barcode.SfBarcode sfBarcode1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge2;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
        private TextBox textBox1;
        private Panel panelPrintBarcode;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2bgrwk;
        private ProgressBar progressBar1;
        private Panel panel1;
    }
}