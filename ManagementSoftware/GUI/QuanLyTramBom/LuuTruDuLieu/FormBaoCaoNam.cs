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

namespace QuanLyTramBom
{
    public partial class FormBaoCaoNam : Form
    {
        public FormBaoCaoNam()
        {
            InitializeComponent();


        }

        class cloneEx
        {
            string ThoiGian;
            string MucNuocBeHut;
            string MucNuocBeXa;
            string ThoiGianChayBom1;
            string ThoiGianChayBom2;
            string ThoiGianChayBom3;
            string ThoiGianChayBom4;
        }

        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            // d là dữ liệu đầu vào
            DateTime d = dateTimePicker1.Value;
            //real Date thuong la no tu lay giờ hiện tại của minh
            // nên t bảo bạn nếu báo cáo ngày thì chuyển dữ liệu đầu vào về 0 giờ thì mới lấy đc đủ 24 tiếng, báo cáo tháng với năm thì kh ảnh hưởng
            // 

            List<BaoCao> list = DALBaoCao.BaoCaoNam(d);


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

            labelTongTime1.Text = TongThoiGianChayBom1.Hours.ToString() + " giờ " + TongThoiGianChayBom1.Minutes.ToString() + " phút";
            labelTongTime2.Text = TongThoiGianChayBom2.Hours.ToString() + " giờ " + TongThoiGianChayBom2.Minutes.ToString() + " phút";
            labelTongTime3.Text = TongThoiGianChayBom3.Hours.ToString() + " giờ " + TongThoiGianChayBom3.Minutes.ToString() + " phút";
            labelTongTime4.Text = TongThoiGianChayBom4.Hours.ToString() + " giờ " + TongThoiGianChayBom4.Minutes.ToString() + " phút";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<BaoCao> baocaonam = DALBaoCao.BaoCaoNam(dateTimePicker1.Value);
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
                            ws.Cell("D2").Style.Font.FontSize = 13;

                            ws.Cell("B9").Value = "m";
                            ws.Cell("B9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("B9").Style.Font.Bold = true;

                            ws.Cell("C9").Value = "m";
                            ws.Cell("C9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("C9").Style.Font.Bold = true;

                            ws.Cell("D9").Value = "h";
                            ws.Cell("D9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("D9").Style.Font.Bold = true;

                            ws.Cell("E9").Value = "h";
                            ws.Cell("E9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("E9").Style.Font.Bold = true;

                            ws.Cell("F9").Value = "h";
                            ws.Cell("F9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("F9").Style.Font.Bold = true;

                            ws.Cell("G9").Value = "h";
                            ws.Cell("G9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            ws.Cell("G9").Style.Font.Bold = true;

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

                            cloneEx clone = new cloneEx();


                            //add du lieu vao excel


                            var a = from p in baocaonam
                                    select new { p.ThoiGian, p.MucNuocBeHut, p.MucNuocBeXa, p.ThoiGianChayBom1.Hours, p.ThoiGianChayBom2, p.ThoiGianChayBom3, p.ThoiGianChayBom4 };
                            var range = ws.Cell(10, 1).InsertData(a.AsEnumerable());


                            double trungBinhBeXa = 0;
                            double trungBinhBeHut = 0;
                            TimeSpan TongThoiGianChayBom1 = TimeSpan.FromMinutes(0);
                            TimeSpan TongThoiGianChayBom2 = TimeSpan.FromMinutes(0);
                            TimeSpan TongThoiGianChayBom3 = TimeSpan.FromMinutes(0);
                            TimeSpan TongThoiGianChayBom4 = TimeSpan.FromMinutes(0);


                            foreach (BaoCao item in baocaonam)
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

                            ws.Cell("B23").Value = (trungBinhBeHut / baocaonam.Count).ToString();
                            ws.Cell("C23").Value = (trungBinhBeXa / baocaonam.Count).ToString();
                            ws.Cell("D22").Value = TongThoiGianChayBom1.Hours.ToString() + ":" + TongThoiGianChayBom1.Minutes.ToString();
                            ws.Cell("E22").Value = TongThoiGianChayBom2.Hours.ToString() + ":" + TongThoiGianChayBom2.Minutes.ToString();
                            ws.Cell("F22").Value = TongThoiGianChayBom3.Hours.ToString() + ":" + TongThoiGianChayBom3.Minutes.ToString();
                            ws.Cell("G22").Value = TongThoiGianChayBom4.Hours.ToString() + ":" + TongThoiGianChayBom4.Minutes.ToString();


                            string tenfile = ".xlsx";
                            workBook.SaveAs(sfd.FileName + DateTime.Now.ToString("dd_MM_yyyy") + tenfile);
                            MessageBox.Show("Xuất file thành công");


                        }

                    }
                    catch { MessageBox.Show("Không thể xuất file"); }
                }
            }
        }

    }
}
