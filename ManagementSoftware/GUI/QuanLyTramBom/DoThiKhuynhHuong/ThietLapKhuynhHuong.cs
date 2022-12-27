using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ManagementSoftware
{
    public partial class ThietLapKhuynhHuong : Form
    {
        public ThietLapKhuynhHuong()
        {
            InitializeComponent();
        }


        List<Analog> list = new AnalogCommon().listAllAnalogs;

        void SetCBDieuKien(ComboBox dieuKien)
        {
            dieuKien.DataSource = new List<string>() { "", "DPS" };
        }
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

        private void ThietLapKhuynhHuong_Load(object sender, EventArgs e)
        {
            SetCBDieuKien(comboBoxDk1);
            SetCBDieuKien(comboBoxDk2);
            SetCBDieuKien(comboBoxDk3);
            SetCBDieuKien(comboBoxDk4);
            SetCBDieuKien(comboBoxDk5);
            SetCBDieuKien(comboBoxDk6);
            SetCBDieuKien(comboBoxDk7);
            SetCBDieuKien(comboBoxDk8);


        }
        private void comboBoxDk1_SelectedIndexChanged(object sender, EventArgs e)
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
        private void comboBoxNhom1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBoxTinHieu1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            List<XuHuongVaTinHieu> list = new List<XuHuongVaTinHieu>();
            if (String.IsNullOrEmpty(textBoxName.Text) == true)
            {
                MessageBox.Show("Không để trống ô nhập tên khuynh hướng.", "Lỗi Cú Pháp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DALKhuynhHuong.CheckName(textBoxName.Text) == false)
            {
                MessageBox.Show("Tên khuynh hướng này đã tồn tại, vui lòng nhập tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (DALKhuynhHuong.Add(textBoxName.Text, list) > 0)
                    {
                        this.Close();
                        callBack?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cần thêm ít nhất 1 mẫu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public delegate void CallBack();
        public CallBack callBack;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

