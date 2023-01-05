using ClosedXML.Excel;
using DGVPrinterHelper;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTramBom
{
    public partial class FormBaoCaoNgay : Form
    {
        public FormBaoCaoNgay()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 35;

        }
        List<BaoCao> list;
        DateTime d;
        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            // d là dữ liệu đầu vào
            d = dateTimePicker1.Value.Date;

            //real Date thuong la no tu lay giờ hiện tại của minh
            // nên t bảo bạn nếu báo cáo ngày thì chuyển dữ liệu đầu vào về 0 giờ thì mới lấy đc đủ 24 tiếng, báo cáo tháng với năm thì kh ảnh hưởng
            // 

            list = DALBaoCao.BaoCaoNgay(d);

            DataTable dt = new DataTable();
            dt.Columns.Add("THỜI GIAN");
            dt.Columns.Add("MỰC NƯỚC\nBƠM XẢ\n(m)");
            dt.Columns.Add("MỰC NƯỚC\nBƠM HÚT\n(m)");
            dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 1\n(h)");
            dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 2\n(h)");
            dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 3\n(h)");
            dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 4\n(h)");

            int i = 1;
            foreach (BaoCao item in list)
            {
                double xa = Math.Round((item.MucNuocBeXa / list.Count), 2, MidpointRounding.ToPositiveInfinity);
                double hut = Math.Round((item.MucNuocBeHut / list.Count), 2, MidpointRounding.ToPositiveInfinity);


                string tongTime1 = item.ThoiGianChayBom1.Hours.ToString() + " h " + item.ThoiGianChayBom1.Minutes.ToString() + " min ";
                string tongTime2 = item.ThoiGianChayBom2.Hours.ToString() + " h " + item.ThoiGianChayBom2.Minutes.ToString() + " min ";
                string tongTime3 = item.ThoiGianChayBom3.Hours.ToString() + " h " + item.ThoiGianChayBom3.Minutes.ToString() + " min ";
                string tongTime4 = item.ThoiGianChayBom4.Hours.ToString() + " h " + item.ThoiGianChayBom4.Minutes.ToString() + " min ";

                dt.Rows.Add(i, xa, hut, tongTime1, tongTime2, tongTime3, tongTime4);
                i++;
            }



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

            }
            //label
            labelTBXa.Text = String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.ToPositiveInfinity)) + " m";
            // b dùng hàm Math.Round để giới hạn còn 2 chữ số sau thập phân
            labelTBHut.Text = String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.ToPositiveInfinity)) + " m";

            labelTongTime1.Text = TongThoiGianChayBom1.Hours.ToString() + " h " + TongThoiGianChayBom1.Minutes.ToString() + " min";
            labelTongTime2.Text = TongThoiGianChayBom2.Hours.ToString() + " h " + TongThoiGianChayBom2.Minutes.ToString() + " min";
            labelTongTime3.Text = TongThoiGianChayBom3.Hours.ToString() + " h " + TongThoiGianChayBom3.Minutes.ToString() + " min";
            labelTongTime4.Text = TongThoiGianChayBom4.Hours.ToString() + " h " + TongThoiGianChayBom4.Minutes.ToString() + " min";

            dt.Rows.Add("Tổng", "", "", TongThoiGianChayBom1.Hours.ToString() + " h " + TongThoiGianChayBom1.Minutes.ToString() + " min ", TongThoiGianChayBom2.Hours.ToString() + " h " + TongThoiGianChayBom2.Minutes.ToString() + " min ",
      TongThoiGianChayBom3.Hours.ToString() + " h  " + TongThoiGianChayBom3.Minutes.ToString() + " min ", TongThoiGianChayBom4.Hours.ToString() + " h " + TongThoiGianChayBom4.Minutes.ToString() + " min ");
            dt.Rows.Add("T.Bình", String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.ToPositiveInfinity)), String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.ToPositiveInfinity)), "", "", "", "");
            dataGridView1.DataSource = dt;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[0].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel | *.xlsx | Excel 2016 | *.xls" })
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (var workBook = new XLWorkbook())
                            {
                                var ws = workBook.Worksheets.Add("Báo cáo ngày");

                                ws.Cell("D2").Value = "CP2 BÁO CÁO NGÀY";
                                ws.Cell("D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Cell("D2").Style.Font.Bold = true;
                                ws.Cell("D2").Style.Font.FontSize = 18;

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

                                ws.Cell("A5").Value = d.ToString("dd/MM/yyyy");
                                ws.Cell("A5").Style.Font.Underline = XLFontUnderlineValues.Double;
                                ws.Cell("A5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                ws.Cell("A34").Value = "TỔNG";
                                ws.Cell("A34").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Cell("A34").Style.Font.Bold = true;
                                ws.Cell("A35").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Cell("A35").Style.Font.Bold = true;
                                ws.Cell("A35").Value = "TBÌNH";


                                ws.Range("A7:B9").Column(1).Merge();
                                ws.Cell("A7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Cell("A7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                                ws.Cell("A7").Value = "THỜI GIAN";
                                ws.Cell("A7").Style.Font.Bold = true;
                                ws.Cell("A7").Style.Font.FontSize = 14;
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
                                ws.Range("B7:G7").Style.Font.FontSize = 12;

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

                                ws.Cell("B35").Value = String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.ToPositiveInfinity));
                                ws.Cell("C35").Value = String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.ToPositiveInfinity));
                                ws.Cell("D34").Value = TongThoiGianChayBom1.Hours.ToString() + "h " + TongThoiGianChayBom1.Minutes.ToString() + "min";
                                ws.Cell("E34").Value = TongThoiGianChayBom2.Hours.ToString() + "h " + TongThoiGianChayBom2.Minutes.ToString() + "min";
                                ws.Cell("F34").Value = TongThoiGianChayBom3.Hours.ToString() + "h " + TongThoiGianChayBom3.Minutes.ToString() + "min";
                                ws.Cell("G34").Value = TongThoiGianChayBom4.Hours.ToString() + "h " + TongThoiGianChayBom4.Minutes.ToString() + "min";




                                string tenfile = ".xlsx";
                                workBook.SaveAs(sfd.FileName + DateTime.Now.ToString("dd_MM_yyyy_hhmmss") + tenfile);
                                MessageBox.Show("Xuất file thành công");


                            }

                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }

            }

        }

        private void buttonPrinter_Click(object sender, EventArgs e)
        {
            if (list != null && list.Count > 0 && dataGridView1.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();

                printer.Title = "CP2 Báo cáo ngày";
                printer.TitleFont = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                printer.SubTitle = d.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                printer.SubTitleAlignment = StringAlignment.Near;
                printer.SubTitleFont = new Font("Segoe UI", 9, FontStyle.Underline);

                printer.TitleSpacing = 5;

                printer.SubTitleSpacing = 4;

                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

                //printer.PageNumbers = true;

                //printer.PageNumberInHeader = true;

                printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Near;

                //printer.Footer = "leanway";

                //printer.FooterSpacing = 5;

                printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth;
                printer.TableAlignment = DGVPrinter.Alignment.Center;
                printer.KeepRowsTogether = true;

                printer.PrintDataGridView(dataGridView1);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu để in báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

