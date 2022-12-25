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
                cbNhom.Text = "";
                cbNhom.Enabled = false;
            }
        }
        void SetAutoFillCBTinHieu(ComboBox cbdieuKien, ComboBox cbNhom, ComboBox cbTinHieu)
        {
            if (cbNhom.Enabled == true && !String.IsNullOrEmpty(cbdieuKien.Text) && !String.IsNullOrEmpty(cbNhom.Text))
            {
                cbTinHieu.Enabled = true;
                cbTinHieu.DataSource = list.Where(a => a.Nhom == cbNhom.Text).Select(a => a.TinHieu).ToList();
            }
            else
            {
                cbTinHieu.Text = "";
                cbTinHieu.Enabled = false;
            }
        }
        void SetAutoFillTextBox(ComboBox cbNhom, ComboBox cbTinHieu, TextBox ganThe, TextBox donVi, TextBox max, TextBox min)
        {
            if (cbTinHieu.Enabled == true && !String.IsNullOrEmpty(cbNhom.Text) && !String.IsNullOrEmpty(cbNhom.Text) && !String.IsNullOrEmpty(cbTinHieu.Text))
            {
                Analog? analog = list.Where(a => a.TinHieu == cbTinHieu.Text).FirstOrDefault();
                if(analog!= null)
                {
                    ganThe.Text = analog.GanThe;
                    donVi.Text = analog.DonVi;
                    max.Text = analog.GiaTriLonNhat.ToString();
                    min.Text = analog.GiaTriNhoNhat.ToString();
                }

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
                    SetAutoFillCBTinHieu(comboBoxDk1, comboBoxNhom, comboBoxTinHieu1);
                }
                else if (comboBoxNhom.Name == comboBoxNhom2.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxDk2, comboBoxNhom, comboBoxTinHieu2);
                }
                else if (comboBoxNhom.Name == comboBoxNhom3.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxDk3, comboBoxNhom, comboBoxTinHieu3);
                }
                else if (comboBoxNhom.Name == comboBoxNhom4.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxDk4, comboBoxNhom, comboBoxTinHieu4);
                }
                else if (comboBoxNhom.Name == comboBoxNhom5.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxDk5, comboBoxNhom, comboBoxTinHieu5);
                }
                else if (comboBoxNhom.Name == comboBoxNhom6.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxDk6, comboBoxNhom, comboBoxTinHieu6);
                }
                else if (comboBoxNhom.Name == comboBoxNhom7.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxDk7, comboBoxNhom, comboBoxTinHieu7);
                }
                else if (comboBoxNhom.Name == comboBoxNhom8.Name)
                {
                    SetAutoFillCBTinHieu(comboBoxDk8, comboBoxNhom, comboBoxTinHieu8);
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
                    SetAutoFillTextBox(comboBoxNhom1, comboBoxTinHieu, textBoxThe1, textBoxGiaTri1, textBoxMax1, textBoxMin1);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu2.Name)
                {
                    SetAutoFillTextBox(comboBoxNhom2, comboBoxTinHieu, textBoxThe2, textBoxGiaTri2, textBoxMax2, textBoxMin2);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu3.Name)
                {
                    SetAutoFillTextBox(comboBoxNhom3, comboBoxTinHieu, textBoxThe3, textBoxGiaTri3, textBoxMax3, textBoxMin3);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu4.Name)
                {
                    SetAutoFillTextBox(comboBoxNhom4, comboBoxTinHieu, textBoxThe4, textBoxGiaTri4, textBoxMax4, textBoxMin4);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu5.Name)
                {
                    SetAutoFillTextBox(comboBoxNhom5, comboBoxTinHieu, textBoxThe5, textBoxGiaTri5, textBoxMax5, textBoxMin5);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu6.Name)
                {
                    SetAutoFillTextBox(comboBoxNhom6, comboBoxTinHieu, textBoxThe6, textBoxGiaTri6, textBoxMax6, textBoxMin6);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu7.Name)
                {
                    SetAutoFillTextBox(comboBoxNhom7, comboBoxTinHieu, textBoxThe7, textBoxGiaTri7, textBoxMax7, textBoxMin7);
                }
                else if (comboBoxTinHieu.Name == comboBoxTinHieu8.Name)
                {
                    SetAutoFillTextBox(comboBoxNhom8, comboBoxTinHieu, textBoxThe8, textBoxGiaTri8, textBoxMax8, textBoxMin8);
                }
            }
        }
    }

}

