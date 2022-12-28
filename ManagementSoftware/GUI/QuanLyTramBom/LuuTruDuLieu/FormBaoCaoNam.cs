using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.DAL;
using DocumentFormat.OpenXml.Office2013.Word;
using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu;
using System.Drawing.Printing;
using System.Globalization;
using TestDatagrridviewAndPrint;

namespace QuanLyTramBom
{
    public partial class FormBaoCaoNam : Form
    {
        public FormBaoCaoNam()
        {
            
            InitializeComponent();
            dateTimePicker1.ShowUpDown = true;

        }

        List<BaoCao> list;

        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            // d là dữ liệu đầu vào
            DateTime d = dateTimePicker1.Value;
            //real Date thuong la no tu lay giờ hiện tại của minh
            // nên t bảo bạn nếu báo cáo ngày thì chuyển dữ liệu đầu vào về 0 giờ thì mới lấy đc đủ 24 tiếng, báo cáo tháng với năm thì kh ảnh hưởng
            // 

            list = DALBaoCao.BaoCaoNam(d);


            DataTable dt = new DataTable();
            dt.Columns.Add("THỜI GIAN");
            dt.Columns.Add("MỰC NƯỚC BƠM XẢ (M)");
            dt.Columns.Add("MỰC NƯỚC BƠM HÚT (M)");
            dt.Columns.Add("THỜI GIAN CHẠY BƠM 1 (H)");
            dt.Columns.Add("THỜI GIAN CHẠY BƠM 2 (H)");
            dt.Columns.Add("THỜI GIAN CHẠY BƠM 3 (H)");
            dt.Columns.Add("THỜI GIAN CHẠY BƠM 4 (H)");

            int i = 1;
            foreach (BaoCao item in list)
            {
                double xa = Math.Round((item.MucNuocBeXa / list.Count), 2, MidpointRounding.AwayFromZero);
                double hut = Math.Round((item.MucNuocBeHut / list.Count), 2, MidpointRounding.AwayFromZero);


                string tongTime1 = item.ThoiGianChayBom1.Hours.ToString() + " h " + item.ThoiGianChayBom1.Minutes.ToString() + " min ";
                string tongTime2 = item.ThoiGianChayBom2.Hours.ToString() + " h " + item.ThoiGianChayBom2.Minutes.ToString() + " min ";
                string tongTime3 = item.ThoiGianChayBom3.Hours.ToString() + " h " + item.ThoiGianChayBom3.Minutes.ToString() + " min ";
                string tongTime4 = item.ThoiGianChayBom4.Hours.ToString() + " h " + item.ThoiGianChayBom4.Minutes.ToString() + " min ";

                dt.Rows.Add(i,xa,hut,tongTime1,tongTime2,tongTime3,tongTime4);
                i++;
            }

            dataGridView1.DataSource = dt;


            //tính tổng, tb
            double trungBinhBeXa = 0;
            double trungBinhBeHut = 0;

            TimeSpan TongThoiGianChayBom1 = TimeSpan.FromMinutes(0);
            TimeSpan TongThoiGianChayBom2 = TimeSpan.FromMinutes(0);
            TimeSpan TongThoiGianChayBom3 = TimeSpan.FromMinutes(0);
            TimeSpan TongThoiGianChayBom4 = TimeSpan.FromMinutes(0);

            foreach (BaoCao item in list)
            {
                trungBinhBeHut = trungBinhBeHut + item.MucNuocBeHut;
                trungBinhBeXa = trungBinhBeXa + item.MucNuocBeXa;

                double minute1 = TongThoiGianChayBom1.TotalMinutes;
                double minute2 = item.ThoiGianChayBom1.TotalMinutes;
                double minute3 = TongThoiGianChayBom2.TotalMinutes;
                double minute4 = item.ThoiGianChayBom2.TotalMinutes;
                double minute5 = TongThoiGianChayBom3.TotalMinutes;
                double minute6 = item.ThoiGianChayBom3.TotalMinutes;
                double minute7 = TongThoiGianChayBom4.TotalMinutes;
                double minute8 = item.ThoiGianChayBom4.TotalMinutes;

                TongThoiGianChayBom1 = TimeSpan.FromMinutes(minute2 + minute1);
                TongThoiGianChayBom2 = TimeSpan.FromMinutes(minute3 + minute4);
                TongThoiGianChayBom3 = TimeSpan.FromMinutes(minute5 + minute6);
                TongThoiGianChayBom4 = TimeSpan.FromMinutes(minute8 + minute7);

                TongThoiGianChayBom1 = TimeSpan.FromMinutes(minute2 + minute1);

            }

            //label
            labelTBXa.Text = String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero));
            // b dùng hàm Math.Round để giới hạn còn 2 chữ số sau thập phân
            labelTBHut.Text = String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero));

            labelTongTime1.Text = TongThoiGianChayBom1.Hours.ToString() + " h " + TongThoiGianChayBom1.Minutes.ToString() + " min";
            labelTongTime2.Text = TongThoiGianChayBom2.Hours.ToString() + " h " + TongThoiGianChayBom2.Minutes.ToString() + " min";
            labelTongTime3.Text = TongThoiGianChayBom3.Hours.ToString() + " h " + TongThoiGianChayBom3.Minutes.ToString() + " min";
            labelTongTime4.Text = TongThoiGianChayBom4.Hours.ToString() + " h " + TongThoiGianChayBom4.Minutes.ToString() + " min";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel | *.xlsx | Excel 2010 | *.xls" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workBook = new XLWorkbook())
                        {
                            var ws = workBook.Worksheets.Add("Báo cáo năm");

                            ws.Cell("D2").Value = "CP2 BÁO CÁO NĂM";
                            ws.Cell("D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("D2").Style.Font.Bold = true;
                            ws.Cell("D2").Style.Font.FontSize = 15;

                            ws.Cell("B9").Value = "m";
                            ws.Cell("B9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("B9").Style.Font.Bold = true;
                            ws.Cell("B9").Style.Font.FontSize = 14;

                            ws.Cell("C9").Value = "m";
                            ws.Cell("C9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("C9").Style.Font.Bold = true;
                            ws.Cell("C9").Style.Font.FontSize = 14;

                            ws.Cell("D9").Value = "h";
                            ws.Cell("D9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("D9").Style.Font.Bold = true;
                            ws.Cell("D9").Style.Font.FontSize = 14;

                            ws.Cell("E9").Value = "h";
                            ws.Cell("E9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("E9").Style.Font.Bold = true;
                            ws.Cell("E9").Style.Font.FontSize = 14;

                            ws.Cell("F9").Value = "h";
                            ws.Cell("F9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("F9").Style.Font.Bold = true;
                            ws.Cell("F9").Style.Font.FontSize = 14;

                            ws.Cell("G9").Value = "h";
                            ws.Cell("G9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("G9").Style.Font.Bold = true;
                            ws.Cell("G9").Style.Font.FontSize = 14;

                            ws.Cell("A5").Value = dateTimePicker1.Value;
                            ws.Cell("A5").Style.Font.Underline = XLFontUnderlineValues.Double;
                            ws.Cell("A7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            

                            ws.Cell("A22").Value = "TỔNG";
                            ws.Cell("A22").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("A22").Style.Font.Bold = true;
                            ws.Cell("A23").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("A23").Style.Font.Bold = true;
                            ws.Cell("A23").Value = "TBÌNH";


                            ws.Range("A7:B9").Column(1).Merge();
                            ws.Cell("A7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("A7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                            ws.Cell("A7").Value = "THỜI GIAN";
                            ws.Cell("A7").Style.Font.Bold = true;
                            ws.Cell("A7").Style.Font.FontSize= 14;
                            //chieu rong cell
                            #region 
                            var col1 = ws.Column("A");
                            var col2 = ws.Column("B");
                            var col3 = ws.Column("C");
                            var col4 = ws.Column("D");
                            var col5 = ws.Column("E");
                            var col6 = ws.Column("F");
                            var col7 = ws.Column("G");
                            var col8 = ws.Column("H");

                            col1.Width = 15;
                            col2.Width = 20;
                            col3.Width = 20;
                            col4.Width = 20;
                            col5.Width = 20;
                            col6.Width = 20;
                            col7.Width = 20;
                            col8.Width = 20;
                            #endregion

                            ws.Range("B7:G7").Style.Font.FontSize = 12;

                            ws.Range("B7:B8").Column(1).Merge();
                            ws.Cell("B7").Value = "MỰC NƯỚC\r\nBỂ HÚT";
                            ws.Cell("B7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("B7").Style.Font.Bold = true;

                            ws.Range("C7:C8").Column(1).Merge();
                            ws.Cell("C7").Value = "MỰC NƯỚC\r\nBỂ XẢ";
                            ws.Cell("C7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("C7").Style.Font.Bold = true;

                            ws.Range("D7:D8").Column(1).Merge();
                            ws.Cell("D7").Value = "BƠM 1\r\nTHỜI GIAN CHẠY";
                            ws.Cell("D7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("D7").Style.Font.Bold = true;

                            ws.Range("E7:E8").Column(1).Merge();
                            ws.Cell("E7").Value = "BƠM 2\r\nTHỜI GIAN CHẠY";
                            ws.Cell("E7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("E7").Style.Font.Bold = true;

                            ws.Range("F7:F8").Column(1).Merge();
                            ws.Cell("F7").Value = "BƠM 3\r\nTHỜI GIAN CHẠY";
                            ws.Cell("F7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("F7").Style.Font.Bold = true;


                            ws.Range("G7:G8").Column(1).Merge();
                            ws.Cell("G7").Value = "BƠM 4\r\nTHỜI GIAN CHẠY";
                            ws.Cell("G7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("G7").Style.Font.Bold = true;





                            //add du lieu vao excel

                            List<ClassFormatDate> listData = new List<ClassFormatDate>();

                            foreach (var item in list)
                            {
                                ClassFormatDate c = new ClassFormatDate();
                                c.MucNuocHut = item.MucNuocBeHut;
                                c.MucNuocXa = item.MucNuocBeXa;
                                c.ThoiGianChayBom1 = item.ThoiGianChayBom1.Hours.ToString() + "h " + item.ThoiGianChayBom1.Minutes.ToString() + "min";
                                c.ThoiGianChayBom2 = item.ThoiGianChayBom2.Hours.ToString() + "h " + item.ThoiGianChayBom2.Minutes.ToString() + "min";
                                c.ThoiGianChayBom3 = item.ThoiGianChayBom3.Hours.ToString() + "h " + item.ThoiGianChayBom3.Minutes.ToString() + "min";
                                c.ThoiGianChayBom4 = item.ThoiGianChayBom4.Hours.ToString() + "h " + item.ThoiGianChayBom4.Minutes.ToString() + "min";


                                listData.Add(c);
                            }
                            var a = from p in listData
                                    select new { p.ThoiGian, p.MucNuocHut, p.MucNuocXa, p.ThoiGianChayBom1, p.ThoiGianChayBom2, p.ThoiGianChayBom3, p.ThoiGianChayBom4 };
                            var range = ws.Cell(10, 1).InsertData(a.AsEnumerable());

                            ws.Range("A10:G35").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Range("A10:G35").Style.Font.FontSize = 14;
                            ws.Rows().Height = 20;
                            double trungBinhBeXa = 0;
                            double trungBinhBeHut = 0;
                            TimeSpan TongThoiGianChayBom1 = TimeSpan.FromMinutes(0);
                            TimeSpan TongThoiGianChayBom2 = TimeSpan.FromMinutes(0);
                            TimeSpan TongThoiGianChayBom3 = TimeSpan.FromMinutes(0);
                            TimeSpan TongThoiGianChayBom4 = TimeSpan.FromMinutes(0);


                            foreach (BaoCao item in list)
                            {
                                trungBinhBeHut = trungBinhBeHut + item.MucNuocBeHut;
                                trungBinhBeXa = trungBinhBeXa + item.MucNuocBeXa;

                                double minute1 = TongThoiGianChayBom1.TotalMinutes;
                                double minute2 = item.ThoiGianChayBom1.TotalMinutes;
                                double minute3 = TongThoiGianChayBom2.TotalMinutes;
                                double minute4 = item.ThoiGianChayBom2.TotalMinutes;
                                double minute5 = TongThoiGianChayBom3.TotalMinutes;
                                double minute6 = item.ThoiGianChayBom3.TotalMinutes;
                                double minute7 = TongThoiGianChayBom4.TotalMinutes;
                                double minute8 = item.ThoiGianChayBom4.TotalMinutes;

                                TongThoiGianChayBom1 = TimeSpan.FromMinutes(minute2 + minute1);
                                TongThoiGianChayBom2 = TimeSpan.FromMinutes(minute3 + minute4);
                                TongThoiGianChayBom3 = TimeSpan.FromMinutes(minute5 + minute6);
                                TongThoiGianChayBom4 = TimeSpan.FromMinutes(minute8 + minute7);

                            }

                            ws.Cell("B23").Value = String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero));
                            ws.Cell("C23").Value = String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero));
                            ws.Cell("D22").Value = TongThoiGianChayBom1.Hours.ToString() + "h " + TongThoiGianChayBom1.Minutes.ToString() + "min";
                            ws.Cell("E22").Value = TongThoiGianChayBom2.Hours.ToString() + "h " + TongThoiGianChayBom2.Minutes.ToString() + "min";
                            ws.Cell("F22").Value = TongThoiGianChayBom3.Hours.ToString() + "h " + TongThoiGianChayBom3.Minutes.ToString() + "min";
                            ws.Cell("G22").Value = TongThoiGianChayBom4.Hours.ToString() + "h " + TongThoiGianChayBom4.Minutes.ToString() + "min";


                            string tenfile = ".xlsx";
                            workBook.SaveAs(sfd.FileName + DateTime.Now.ToString("dd_MM_yyyy_hhmmss") + tenfile);
                            MessageBox.Show("Xuất file thành công");


                        }

                    }
                    catch { MessageBox.Show("Không thể xuất file"); }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "CP2 Bao cao thang";
            printer.TitleFont = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            printer.SubTitle = "(" + DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + ")";

            printer.TitleSpacing = 5;

            printer.SubTitleSpacing = 30;

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = true;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "TPA";

            printer.FooterSpacing = 15;


            


            printer.PrintDataGridView(dataGridView1);
        }
    }
}
