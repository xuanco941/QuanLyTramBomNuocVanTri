using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong
{
    public partial class CapNhatKhuynhHuong : Form
    {
        public CapNhatKhuynhHuong(string name)
        {
            InitializeComponent();
            comboBoxTenKH.DataSource = DALKhuynhHuong.GetAll()?.Select(d => d.TenDoThi).ToList();

            if (!String.IsNullOrEmpty(name))
            {
                comboBoxTenKH.Text = name;
            }


            if (String.IsNullOrEmpty(comboBoxTenKH.Text))
            {
                buttonDelete.Enabled = false;
                comboBoxDk1.DataSource = null;
                comboBoxDk1.Enabled = false;

                comboBoxDk2.DataSource = null;
                comboBoxDk2.Enabled = false;

                comboBoxDk3.DataSource = null;
                comboBoxDk3.Enabled = false;

                comboBoxDk4.DataSource = null;
                comboBoxDk4.Enabled = false;

                comboBoxDk5.DataSource = null;
                comboBoxDk5.Enabled = false;

                comboBoxDk6.DataSource = null;
                comboBoxDk6.Enabled = false;

                comboBoxDk7.DataSource = null;
                comboBoxDk7.Enabled = false;

                comboBoxDk8.DataSource = null;
                comboBoxDk8.Enabled = false;
            }
            else
            {
                comboBoxDk1.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk1.Enabled = true;

                comboBoxDk2.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk2.Enabled = true;

                comboBoxDk3.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk3.Enabled = true;

                comboBoxDk4.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk4.Enabled = true;

                comboBoxDk5.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk5.Enabled = true;

                comboBoxDk6.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk6.Enabled = true;

                comboBoxDk7.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk7.Enabled = true;

                comboBoxDk8.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk8.Enabled = true;


            }
        }

        List<Analog> list = new AnalogCommon().listAllAnalogs;



        void SetCBNhom(ComboBox dieuKien, ComboBox cbNhom)
        {
            if (!String.IsNullOrEmpty(dieuKien.Text))
            {
                cbNhom.Enabled = true;
                cbNhom.DataSource = list.Where(a => a.DieuKien == dieuKien.Text).Select(a => a.Nhom).Distinct().ToList();
            }
            else
            {
                cbNhom.DataSource = null;
                cbNhom.Enabled = false;
            }
        }
        void SetAutoFillCBTinHieu(ComboBox cbNhom, ComboBox cbTinHieu)
        {
            if (!String.IsNullOrEmpty(cbNhom.Text))
            {
                cbTinHieu.Enabled = true;
                cbTinHieu.DataSource = list.Where(a => a.Nhom == cbNhom.Text).Select(a => a.TinHieu).ToList();
            }
            else
            {
                cbTinHieu.DataSource = null;
                cbTinHieu.Enabled = false;
            }
        }
        void SetAutoFillTextBox(ComboBox cbTinHieu, TextBox ganThe, TextBox donVi, TextBox max, TextBox min)
        {
            if (!String.IsNullOrEmpty(cbTinHieu.Text))
            {
                Analog? analog = list.Where(a => a.TinHieu == cbTinHieu.Text).FirstOrDefault();
                if (analog != null)
                {
                    ganThe.Text = analog.GanThe;
                    donVi.Text = analog.DonVi;
                    max.Text = analog.GiaTriLonNhat.ToString();
                    min.Text = analog.GiaTriNhoNhat.ToString();
                }
                else
                {
                    ganThe.Text = "";
                    donVi.Text = "";
                    max.Text = "";
                    min.Text = "";
                }
            }
            else
            {
                ganThe.Text = "";
                donVi.Text = "";
                max.Text = "";
                min.Text = "";
            }


        }


        void AutoFillAllField(List<XuHuongVaTinHieu>? listXuHuong)
        {
            if (listXuHuong != null && listXuHuong.Count > 0)
            {
                foreach (XuHuongVaTinHieu item in listXuHuong)
                {
                    if (item.Number == 1)
                    {
                        comboBoxDk1.Text = item.DieuKien;
                        comboBoxNhom1.Text = item.Nhom;
                        comboBoxTinHieu1.Text = item.TinHieu;
                        textBoxThe1.Text = item.GanThe;
                        textBoxMin1.Text = item.Min.ToString();
                        textBoxMax1.Text = item.Max.ToString();
                        textBoxGiaTri1.Text = item.DonVi;
                    }
                    else if (item.Number == 2)
                    {
                        comboBoxDk2.Text = item.DieuKien;
                        comboBoxNhom2.Text = item.Nhom;
                        comboBoxTinHieu2.Text = item.TinHieu;
                        textBoxThe2.Text = item.GanThe;
                        textBoxMin2.Text = item.Min.ToString();
                        textBoxMax2.Text = item.Max.ToString();
                        textBoxGiaTri2.Text = item.DonVi;
                    }
                    else if (item.Number == 3)
                    {
                        comboBoxDk3.Text = item.DieuKien;
                        comboBoxNhom3.Text = item.Nhom;
                        comboBoxTinHieu3.Text = item.TinHieu;
                        textBoxThe3.Text = item.GanThe;
                        textBoxMin3.Text = item.Min.ToString();
                        textBoxMax3.Text = item.Max.ToString();
                        textBoxGiaTri3.Text = item.DonVi;
                    }
                    else if (item.Number == 4)
                    {
                        comboBoxDk4.Text = item.DieuKien;
                        comboBoxNhom4.Text = item.Nhom;
                        comboBoxTinHieu4.Text = item.TinHieu;
                        textBoxThe4.Text = item.GanThe;
                        textBoxMin4.Text = item.Min.ToString();
                        textBoxMax4.Text = item.Max.ToString();
                        textBoxGiaTri4.Text = item.DonVi;
                    }
                    else if (item.Number == 5)
                    {
                        comboBoxDk5.Text = item.DieuKien;
                        comboBoxNhom5.Text = item.Nhom;
                        comboBoxTinHieu5.Text = item.TinHieu;
                        textBoxThe5.Text = item.GanThe;
                        textBoxMin5.Text = item.Min.ToString();
                        textBoxMax5.Text = item.Max.ToString();
                        textBoxGiaTri5.Text = item.DonVi;
                    }
                    else if (item.Number == 6)
                    {
                        comboBoxDk6.Text = item.DieuKien;
                        comboBoxNhom6.Text = item.Nhom;
                        comboBoxTinHieu6.Text = item.TinHieu;
                        textBoxThe6.Text = item.GanThe;
                        textBoxMin6.Text = item.Min.ToString();
                        textBoxMax6.Text = item.Max.ToString();
                        textBoxGiaTri6.Text = item.DonVi;
                    }
                    else if (item.Number == 7)
                    {
                        comboBoxDk7.Text = item.DieuKien;
                        comboBoxNhom7.Text = item.Nhom;
                        comboBoxTinHieu7.Text = item.TinHieu;
                        textBoxThe7.Text = item.GanThe;
                        textBoxMin7.Text = item.Min.ToString();
                        textBoxMax7.Text = item.Max.ToString();
                        textBoxGiaTri7.Text = item.DonVi;
                    }
                    else if (item.Number == 8)
                    {
                        comboBoxDk8.Text = item.DieuKien;
                        comboBoxNhom8.Text = item.Nhom;
                        comboBoxTinHieu8.Text = item.TinHieu;
                        textBoxThe8.Text = item.GanThe;
                        textBoxMin8.Text = item.Min.ToString();
                        textBoxMax8.Text = item.Max.ToString();
                        textBoxGiaTri8.Text = item.DonVi;
                    }
                }
            }
        }






        XuHuongVaTinHieu? GetAXuHuong(ComboBox dieukien, ComboBox cbNhom, ComboBox cbTinHieu, TextBox ganThe, TextBox donvi, TextBox max, TextBox min, Panel color, Label number)
        {
            XuHuongVaTinHieu? xuHuongVaTinHieu = new XuHuongVaTinHieu();
            string strDieuKien = dieukien.Text;
            string strNhom = cbNhom.Text;
            string strTinHieu = cbTinHieu.Text;
            string strGanThe = ganThe.Text;
            string strDonVi = donvi.Text;
            string strMax = max.Text;
            string strMin = min.Text;
            string strColor = color.BackColor.Name;
            if (String.IsNullOrEmpty(strDieuKien) == false && String.IsNullOrEmpty(strNhom) == false && String.IsNullOrEmpty(strTinHieu) == false &&
                String.IsNullOrEmpty(strGanThe) == false && String.IsNullOrEmpty(strDonVi) == false && String.IsNullOrEmpty(strMax) == false &&
                String.IsNullOrEmpty(strMin) == false && String.IsNullOrEmpty(strColor) == false)
            {
                xuHuongVaTinHieu.Number = int.Parse(number.Text);
                xuHuongVaTinHieu.DieuKien = strDieuKien;
                xuHuongVaTinHieu.Nhom = strNhom;
                xuHuongVaTinHieu.TinHieu = strTinHieu;
                xuHuongVaTinHieu.GanThe = strGanThe;
                xuHuongVaTinHieu.DonVi = strDonVi;
                xuHuongVaTinHieu.Max = double.Parse(strMax);
                xuHuongVaTinHieu.Min = double.Parse(strMin);
                xuHuongVaTinHieu.Color = strColor;
                return xuHuongVaTinHieu;

            }
            else
            {
                return null;
            }

        }

        public delegate void CallBack();
        public CallBack callBack;

        private void comboBoxDk8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxDieuKien = sender as ComboBox;
            if (comboBoxDieuKien != null)
            {
                if (comboBoxDieuKien.Name == comboBoxDk1.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom1);
                }
                else if (comboBoxDieuKien.Name == comboBoxDk2.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom2);
                }
                else if (comboBoxDieuKien.Name == comboBoxDk3.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom3);
                }
                else if (comboBoxDieuKien.Name == comboBoxDk4.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom4);
                }
                else if (comboBoxDieuKien.Name == comboBoxDk5.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom5);
                }
                else if (comboBoxDieuKien.Name == comboBoxDk6.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom6);
                }
                else if (comboBoxDieuKien.Name == comboBoxDk7.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom7);
                }
                else if (comboBoxDieuKien.Name == comboBoxDk8.Name)
                {
                    SetCBNhom(comboBoxDieuKien, comboBoxNhom8);
                }
            }
        }

        private void comboBoxNhom8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxNhom = sender as ComboBox;
            if (comboBoxNhom != null)
            {
                if (comboBoxNhom.Name == comboBoxNhom1.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu1);
                }
                else if (comboBoxNhom.Name == comboBoxNhom2.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu2);
                }
                else if (comboBoxNhom.Name == comboBoxNhom3.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu3);
                }
                else if (comboBoxNhom.Name == comboBoxNhom4.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu4);
                }
                else if (comboBoxNhom.Name == comboBoxNhom5.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu5);
                }
                else if (comboBoxNhom.Name == comboBoxNhom6.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu6);
                }
                else if (comboBoxNhom.Name == comboBoxNhom7.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu7);
                }
                else if (comboBoxNhom.Name == comboBoxNhom8.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxNhom, comboBoxTinHieu8);
                }
            }
        }

        private void comboBoxTinHieu8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxTinHieu = sender as ComboBox;
            if (comboBoxTinHieu != null)
            {
                if (comboBoxTinHieu.Name == comboBoxTinHieu1.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe1, textBoxGiaTri1, textBoxMax1, textBoxMin1);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu2.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe2, textBoxGiaTri2, textBoxMax2, textBoxMin2);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu3.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe3, textBoxGiaTri3, textBoxMax3, textBoxMin3);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu4.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe4, textBoxGiaTri4, textBoxMax4, textBoxMin4);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu5.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe5, textBoxGiaTri5, textBoxMax5, textBoxMin5);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu6.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe6, textBoxGiaTri6, textBoxMax6, textBoxMin6);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu7.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe7, textBoxGiaTri7, textBoxMax7, textBoxMin7);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu8.Name)
                {
                    SetAutoFillTextBox(comboBoxTinHieu, textBoxThe8, textBoxGiaTri8, textBoxMax8, textBoxMin8);
                }
            }
        }


        private void comboBoxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBoxTenKH.Text))
            {
                buttonDelete.Enabled = false;
                comboBoxDk1.DataSource = null;
                comboBoxDk1.Enabled = false;

                comboBoxDk2.DataSource = null;
                comboBoxDk2.Enabled = false;

                comboBoxDk3.DataSource = null;
                comboBoxDk3.Enabled = false;

                comboBoxDk4.DataSource = null;
                comboBoxDk4.Enabled = false;

                comboBoxDk5.DataSource = null;
                comboBoxDk5.Enabled = false;

                comboBoxDk6.DataSource = null;
                comboBoxDk6.Enabled = false;

                comboBoxDk7.DataSource = null;
                comboBoxDk7.Enabled = false;

                comboBoxDk8.DataSource = null;
                comboBoxDk8.Enabled = false;
            }
            else
            {
                comboBoxDk1.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk1.Enabled = true;

                comboBoxDk2.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk2.Enabled = true;

                comboBoxDk3.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk3.Enabled = true;

                comboBoxDk4.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk4.Enabled = true;

                comboBoxDk5.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk5.Enabled = true;

                comboBoxDk6.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk6.Enabled = true;

                comboBoxDk7.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk7.Enabled = true;

                comboBoxDk8.DataSource = new List<string>() { "", "DPS" };
                comboBoxDk8.Enabled = true;


            }
            List<XuHuongVaTinHieu>? listXuHuong = DALKhuynhHuong.GetAListXuHuongFromName(comboBoxTenKH.Text);
            AutoFillAllField(listXuHuong);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<XuHuongVaTinHieu> list = new List<XuHuongVaTinHieu>();
            if (String.IsNullOrEmpty(comboBoxTenKH.Text) == true)
            {
                MessageBox.Show("Không để trống ô nhập tên khuynh hướng.", "Lỗi Cú Pháp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XuHuongVaTinHieu? xuHuongVaTinHieu1 = GetAXuHuong(comboBoxDk1, comboBoxNhom1, comboBoxTinHieu1, textBoxThe1, textBoxGiaTri1, textBoxMax1, textBoxMin1, panelColor1, labelNumber1);
                if (xuHuongVaTinHieu1 != null)
                {
                    list.Add(xuHuongVaTinHieu1);
                }
                XuHuongVaTinHieu? xuHuongVaTinHieu2 = GetAXuHuong(comboBoxDk2, comboBoxNhom2, comboBoxTinHieu2, textBoxThe2, textBoxGiaTri2, textBoxMax2, textBoxMin2, panelColor2, labelNumber2);
                if (xuHuongVaTinHieu2 != null)
                {
                    list.Add(xuHuongVaTinHieu2);
                }
                XuHuongVaTinHieu? xuHuongVaTinHieu3 = GetAXuHuong(comboBoxDk3, comboBoxNhom3, comboBoxTinHieu3, textBoxThe3, textBoxGiaTri3, textBoxMax3, textBoxMin3, panelColor3, labelNumber3);
                if (xuHuongVaTinHieu3 != null)
                {
                    list.Add(xuHuongVaTinHieu3);
                }
                XuHuongVaTinHieu? xuHuongVaTinHieu4 = GetAXuHuong(comboBoxDk4, comboBoxNhom4, comboBoxTinHieu4, textBoxThe4, textBoxGiaTri4, textBoxMax4, textBoxMin4, panelColor4, labelNumber4);
                if (xuHuongVaTinHieu4 != null)
                {
                    list.Add(xuHuongVaTinHieu4);
                }
                XuHuongVaTinHieu? xuHuongVaTinHieu5 = GetAXuHuong(comboBoxDk5, comboBoxNhom5, comboBoxTinHieu5, textBoxThe5, textBoxGiaTri5, textBoxMax5, textBoxMin5, panelColor5, labelNumber5);
                if (xuHuongVaTinHieu5 != null)
                {
                    list.Add(xuHuongVaTinHieu5);
                }
                XuHuongVaTinHieu? xuHuongVaTinHieu6 = GetAXuHuong(comboBoxDk6, comboBoxNhom6, comboBoxTinHieu6, textBoxThe6, textBoxGiaTri6, textBoxMax6, textBoxMin6, panelColor6, labelNumber6);
                if (xuHuongVaTinHieu6 != null)
                {
                    list.Add(xuHuongVaTinHieu6);
                }
                XuHuongVaTinHieu? xuHuongVaTinHieu7 = GetAXuHuong(comboBoxDk7, comboBoxNhom7, comboBoxTinHieu7, textBoxThe7, textBoxGiaTri7, textBoxMax7, textBoxMin7, panelColor7, labelNumber7);
                if (xuHuongVaTinHieu7 != null)
                {
                    list.Add(xuHuongVaTinHieu7);
                }
                XuHuongVaTinHieu? xuHuongVaTinHieu8 = GetAXuHuong(comboBoxDk8, comboBoxNhom8, comboBoxTinHieu8, textBoxThe8, textBoxGiaTri8, textBoxMax8, textBoxMin8, panelColor8, labelNumber8);
                if (xuHuongVaTinHieu8 != null)
                {
                    list.Add(xuHuongVaTinHieu8);
                }
                if (list != null && list.Count > 0)
                {
                    if (DALKhuynhHuong.Update(comboBoxTenKH.Text, list) == true)
                    {
                        callBack?.Invoke();
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Cần thêm ít nhất 1 mẫu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DALKhuynhHuong.Delete(comboBoxTenKH.Text);
            callBack?.Invoke();
            this.Close();
        }

        private void CapNhatKhuynhHuong_Load(object sender, EventArgs e)
        {
            List<XuHuongVaTinHieu>? listXuHuong = DALKhuynhHuong.GetAListXuHuongFromName(comboBoxTenKH.Text);
            AutoFillAllField(listXuHuong);
        }
    }


}
