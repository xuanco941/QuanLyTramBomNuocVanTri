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
            dataGridView1.RowTemplate.Height = 35;

        }

        List<BaoCao> list;
        DateTime d;


        void SearchData()
        {
            // d là dữ liệu đầu vào
            d = dateTimePicker1.Value;
            //real Date thuong la no tu lay giờ hiện tại của minh
            // nên t bảo bạn nếu báo cáo ngày thì chuyển dữ liệu đầu vào về 0 giờ thì mới lấy đc đủ 24 tiếng, báo cáo tháng với năm thì kh ảnh hưởng
            // 

            list = DALBaoCao.BaoCaoNam(d);

            DataTable dt = new DataTable();
            dt.Columns.Add("THỜI GIAN");
            dt.Columns.Add("MỰC NƯỚC\nBƠM XẢ\n(m)");
            dt.Columns.Add("MỰC NƯỚC\nBƠM HÚT\n(m)");
            if (checkBoxBom1.Checked == true)
            {
                dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 1\n(h)");
            }
            if (checkBoxBom2.Checked == true)
            {
                dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 2\n(h)");
            }
            if (checkBoxBom3.Checked == true)
            {
                dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 3\n(h)");
            }
            if (checkBoxBom4.Checked == true)
            {
                dt.Columns.Add("THỜI GIAN\nCHẠY BƠM 4\n(h)");
            }

            int i = 1;
            foreach (BaoCao item in list)
            {
                double xa = item.MucNuocBeXa;
                double hut = item.MucNuocBeHut;


                string tongTime1 = "";
                string tongTime2 = "";
                string tongTime3 = "";
                string tongTime4 = "";

                List<string> listStr = new List<string>();

                if (checkBoxBom1.Checked == true)
                {
                    tongTime1 = Math.Floor(item.ThoiGianChayBom1 / 60).ToString() + " h " + (item.ThoiGianChayBom1 % 60).ToString() + " min ";
                    listStr.Add(tongTime1);
                }
                if (checkBoxBom2.Checked == true)
                {
                    tongTime2 = Math.Floor(item.ThoiGianChayBom2 / 60).ToString() + " h " + (item.ThoiGianChayBom2 % 60).ToString() + " min ";
                    listStr.Add(tongTime2);
                }
                if (checkBoxBom3.Checked == true)
                {
                    tongTime3 = Math.Floor(item.ThoiGianChayBom3 / 60).ToString() + " h " + (item.ThoiGianChayBom3 % 60).ToString() + " min ";
                    listStr.Add(tongTime3);
                }
                if (checkBoxBom4.Checked == true)
                {
                    tongTime4 = Math.Floor(item.ThoiGianChayBom4 / 60).ToString() + " h " + (item.ThoiGianChayBom4 % 60).ToString() + " min ";
                    listStr.Add(tongTime4);
                }

                if (listStr != null && listStr.Count > 0)
                {
                    if (listStr.Count == 1)
                    {
                        dt.Rows.Add((i - 1).ToString() + " - " + i.ToString(), xa, hut, listStr[0]);
                    }
                    if (listStr.Count == 2)
                    {
                        dt.Rows.Add((i - 1).ToString() + " - " + i.ToString(), xa, hut, listStr[0], listStr[1]);
                    }
                    if (listStr.Count == 3)
                    {
                        dt.Rows.Add((i - 1).ToString() + " - " + i.ToString(), xa, hut, listStr[0], listStr[1], listStr[2]);
                    }
                    if (listStr.Count == 4)
                    {
                        dt.Rows.Add((i - 1).ToString() + " - " + i.ToString(), xa, hut, listStr[0], listStr[1], listStr[2], listStr[3]);
                    }
                }
                else
                {
                    dt.Rows.Add((i - 1).ToString() + " - " + i.ToString(), xa, hut);
                }



                i++;
            }


            //tính tổng, tb
            double trungBinhBeXa = 0;
            double trungBinhBeHut = 0;

            double TongThoiGianChayBom1 = 0;
            double TongThoiGianChayBom2 = 0;
            double TongThoiGianChayBom3 = 0;
            double TongThoiGianChayBom4 = 0;

            foreach (BaoCao item in list)
            {
                trungBinhBeHut = trungBinhBeHut + item.MucNuocBeHut;
                trungBinhBeXa = trungBinhBeXa + item.MucNuocBeXa;


                TongThoiGianChayBom1 = TongThoiGianChayBom1 + item.ThoiGianChayBom1;
                TongThoiGianChayBom2 = TongThoiGianChayBom2 + item.ThoiGianChayBom2;
                TongThoiGianChayBom3 = TongThoiGianChayBom3 + item.ThoiGianChayBom3;
                TongThoiGianChayBom4 = TongThoiGianChayBom4 + item.ThoiGianChayBom4;
            }

            //label
            labelTBXa.Text = String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero)) + " m";
            labelTBHut.Text = String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero)) + " m";

            labelTongTime1.Text = Math.Floor(TongThoiGianChayBom1 / 60).ToString() + " h " + (TongThoiGianChayBom1 % 60).ToString() + " min ";
            labelTongTime2.Text = Math.Floor(TongThoiGianChayBom2 / 60).ToString() + " h " + (TongThoiGianChayBom2 % 60).ToString() + " min ";
            labelTongTime3.Text = Math.Floor(TongThoiGianChayBom3 / 60).ToString() + " h " + (TongThoiGianChayBom3 % 60).ToString() + " min ";
            labelTongTime4.Text = Math.Floor(TongThoiGianChayBom4 / 60).ToString() + " h " + (TongThoiGianChayBom4 % 60).ToString() + " min ";




            List<string> listTong = new List<string>();
            if (checkBoxBom1.Checked == true)
            {
                string tong1 = Math.Floor(TongThoiGianChayBom1 / 60).ToString() + " h " + (TongThoiGianChayBom1 % 60).ToString() + " min ";
                listTong.Add(tong1);
            }
            if (checkBoxBom2.Checked == true)
            {
                string tong2 = Math.Floor(TongThoiGianChayBom2 / 60).ToString() + " h " + (TongThoiGianChayBom2 % 60).ToString() + " min ";
                listTong.Add(tong2);
            }
            if (checkBoxBom3.Checked == true)
            {
                string tong3 = Math.Floor(TongThoiGianChayBom3 / 60).ToString() + " h " + (TongThoiGianChayBom3 % 60).ToString() + " min ";
                listTong.Add(tong3);
            }
            if (checkBoxBom4.Checked == true)
            {
                string tong4 = Math.Floor(TongThoiGianChayBom4 / 60).ToString() + " h " + (TongThoiGianChayBom4 % 60).ToString() + " min ";
                listTong.Add(tong4);
            }

            if (listTong != null && listTong.Count>0)
            {
                if (listTong.Count == 1)
                {
                    dt.Rows.Add("Tổng", "", "", listTong[0]);
                    dt.Rows.Add("T.Bình", String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero)), String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero)), "");
                }
                if (listTong.Count == 2)
                {
                    dt.Rows.Add("Tổng", "", "", listTong[0], listTong[1]);
                    dt.Rows.Add("T.Bình", String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero)), String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero)), "", "");
                }
                if (listTong.Count == 3)
                {
                    dt.Rows.Add("Tổng", "", "", listTong[0], listTong[1], listTong[2]);
                    dt.Rows.Add("T.Bình", String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero)), String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero)), "", "", "");
                }
                if (listTong.Count == 4)
                {
                    dt.Rows.Add("Tổng", "", "", listTong[0], listTong[1], listTong[2], listTong[3]);
                    dt.Rows.Add("T.Bình", String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero)), String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero)), "", "", "", "");
                }
            }
            else
            {
                dt.Rows.Add("T.Bình", String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero)), String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero)));
            }








            dataGridView1.DataSource = dt;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[0].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }






        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            SearchData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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

                                ws.Cell("A5").Value = d.ToString("yyyy");
                                ws.Cell("A5").Style.Font.Underline = XLFontUnderlineValues.Double;
                                ws.Cell("A5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


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

                                int i = 1;

                                foreach (var item in list)
                                {
                                    ClassFormatDate c = new ClassFormatDate();
                                    c.ThoiGian = (i - 1).ToString() + " - " + i.ToString();
                                    c.MucNuocHut = item.MucNuocBeHut;
                                    c.MucNuocXa = item.MucNuocBeXa;
                                    c.ThoiGianChayBom1 = Math.Floor(item.ThoiGianChayBom1 / 60).ToString() + " h " + (item.ThoiGianChayBom1 % 60).ToString() + " min ";
                                    c.ThoiGianChayBom2 = Math.Floor(item.ThoiGianChayBom2 / 60).ToString() + " h " + (item.ThoiGianChayBom2 % 60).ToString() + " min ";
                                    c.ThoiGianChayBom3 = Math.Floor(item.ThoiGianChayBom3 / 60).ToString() + " h " + (item.ThoiGianChayBom3 % 60).ToString() + " min ";
                                    c.ThoiGianChayBom4 = Math.Floor(item.ThoiGianChayBom4 / 60).ToString() + " h " + (item.ThoiGianChayBom4 % 60).ToString() + " min ";


                                    listData.Add(c);
                                    i++;
                                }
                                var a = from p in listData
                                        select new { p.ThoiGian, p.MucNuocHut, p.MucNuocXa, p.ThoiGianChayBom1, p.ThoiGianChayBom2, p.ThoiGianChayBom3, p.ThoiGianChayBom4 };
                                var range = ws.Cell(10, 1).InsertData(a.AsEnumerable());

                                ws.Range("A10:G35").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Range("A10:G35").Style.Font.FontSize = 14;
                                ws.Rows().Height = 20;


                                //tính tổng, tb
                                double trungBinhBeXa = 0;
                                double trungBinhBeHut = 0;

                                double TongThoiGianChayBom1 = 0;
                                double TongThoiGianChayBom2 = 0;
                                double TongThoiGianChayBom3 = 0;
                                double TongThoiGianChayBom4 = 0;

                                foreach (BaoCao item in list)
                                {
                                    trungBinhBeHut = trungBinhBeHut + item.MucNuocBeHut;
                                    trungBinhBeXa = trungBinhBeXa + item.MucNuocBeXa;


                                    TongThoiGianChayBom1 = TongThoiGianChayBom1 + item.ThoiGianChayBom1;
                                    TongThoiGianChayBom2 = TongThoiGianChayBom2 + item.ThoiGianChayBom2;
                                    TongThoiGianChayBom3 = TongThoiGianChayBom3 + item.ThoiGianChayBom3;
                                    TongThoiGianChayBom4 = TongThoiGianChayBom4 + item.ThoiGianChayBom4;

                                }

                                ws.Cell("B23").Value = String.Format("{0:0.00}", Math.Round((trungBinhBeHut / list.Count), 2, MidpointRounding.AwayFromZero));
                                ws.Cell("C23").Value = String.Format("{0:0.00}", Math.Round((trungBinhBeXa / list.Count), 2, MidpointRounding.AwayFromZero));
                                ws.Cell("D22").Value = Math.Floor(TongThoiGianChayBom1 / 60).ToString() + " h " + (TongThoiGianChayBom1 % 60).ToString() + " min ";
                                ws.Cell("E22").Value = Math.Floor(TongThoiGianChayBom2 / 60).ToString() + " h " + (TongThoiGianChayBom2 % 60).ToString() + " min ";
                                ws.Cell("F22").Value = Math.Floor(TongThoiGianChayBom3 / 60).ToString() + " h " + (TongThoiGianChayBom3 % 60).ToString() + " min ";
                                ws.Cell("G22").Value = Math.Floor(TongThoiGianChayBom4 / 60).ToString() + " h " + (TongThoiGianChayBom4 % 60).ToString() + " min ";


                                string tenfile = ".xlsx";
                                workBook.SaveAs(sfd.FileName + DateTime.Now.ToString("dd_MM_yyyy_hhmmss") + tenfile);
                                MessageBox.Show("Xuất file thành công");


                            }

                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }

        }

        private void buttonPrinter_Click(object sender, EventArgs e)
        {
            if (list != null && list.Count > 0 && dataGridView1.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();

                printer.Title = "CP2 Báo cáo năm";
                printer.TitleFont = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                printer.SubTitle = d.ToString("yyyy", CultureInfo.InvariantCulture);

                printer.SubTitleAlignment = StringAlignment.Near;
                printer.SubTitleFont = new Font("Segoe UI", 9, FontStyle.Underline);

                printer.TitleSpacing = 5;

                printer.SubTitleSpacing = 4;

                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

                //printer.PageNumbers = true;

                //printer.PageNumberInHeader = true;

                printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Near;

                //printer.Footer = "TPA";

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

        private void FormBaoCaoNam_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            checkBoxBom1.Checked = true;
            checkBoxBom2.Checked = true;
            checkBoxBom3.Checked = true;
            checkBoxBom4.Checked = true;

            SearchData();

        }
    }
}
