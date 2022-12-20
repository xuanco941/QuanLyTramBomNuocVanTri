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
    public partial class FormCaiDatDoThiKhuynhHuong : Form
    {
        public FormCaiDatDoThiKhuynhHuong()
        {
            InitializeComponent();
        }

        private void FormCaiDatDoThiKhuynhHuong_Load(object sender, EventArgs e)
        {
            List<String> bom = new List<String>();
            bom.Add("Chung");
            bom.Add("Bơm 1");
            bom.Add("Bơm 2");
            bom.Add("Bơm 3");
            bom.Add("Bơm 4");
            List<String> dieukien = new List<String>();
            dieukien.Add("DPS");
            for (int i = 0; i < dieukien.Count; i ++) {
                comboBoxDk1.Items.Add(dieukien[i]);
                comboBoxDk2.Items.Add(dieukien[i]);
                comboBoxDk3.Items.Add(dieukien[i]);
                comboBoxDk4.Items.Add(dieukien[i]);
                comboBoxDk5.Items.Add(dieukien[i]);
                comboBoxDk6.Items.Add(dieukien[i]);
                comboBoxDk7.Items.Add(dieukien[i]);
                comboBoxDk8.Items.Add(dieukien[i]);
            }
            for (int i = 0; i < bom.Count; i++)
            {
                comboBoxNhom1.Items.Add(bom[i]);
                comboBoxNhom2.Items.Add(bom[i]);
                comboBoxNhom3.Items.Add(bom[i]);
                comboBoxNhom4.Items.Add(bom[i]);
                comboBoxNhom5.Items.Add(bom[i]);
                comboBoxNhom6.Items.Add(bom[i]);
                comboBoxNhom7.Items.Add(bom[i]);
                comboBoxNhom8.Items.Add(bom[i]);
            }
        }
        #region nhom1
        private void comboBoxDk1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu1.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk1.Text;
            if (comboBoxNhom1.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom1.Text && item.DieuKien == comboBoxDk1.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu1.Items.Add(item.ToString());
            }
        }

        private void comboBoxNhom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu1.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom1.Text;
            if (comboBoxDk1.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom1.Text && item.DieuKien == comboBoxDk1.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu1.Items.Add(item.TinHieu.ToString());
            }
        }

        private void textBoxThe1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTinHieu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu1.Text && item.Nhom == comboBoxNhom1.Text && item.DieuKien == comboBoxDk1.Text);
            textBoxThe1.Text = d.GanThe;
            textBoxGiaTri1.Text = d.DonVi;
            textBoxMax1.Text = d.GiaTriLonNhat.ToString();
            textBoxMin1.Text = d.GiaTriNhoNhat.ToString();

        }
        #endregion nhom1
        #region nhom2
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu2.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk2.Text;
            if (comboBoxNhom2.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom2.Text && item.DieuKien == comboBoxDk2.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu2.Items.Add(item.ToString());
            }

        }

        private void comboBoxNhom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu2.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom2.Text;
            if (comboBoxDk2.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom2.Text && item.DieuKien == comboBoxDk2.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu2.Items.Add(item.TinHieu.ToString());
            }

        }

        private void comboBoxTinHieu2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu2.Text && item.Nhom == comboBoxNhom2.Text && item.DieuKien == comboBoxDk2.Text);
            textBoxThe2.Text = d.GanThe;
            textBoxGiaTri2.Text = d.DonVi;
            textBoxMax2.Text = d.GiaTriLonNhat.ToString();
            textBoxMin2.Text = d.GiaTriNhoNhat.ToString();
        }
        #endregion nhom2
        #region nhom3
        private void comboBoxDk3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu3.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk3.Text;
            if (comboBoxNhom3.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom3.Text && item.DieuKien == comboBoxDk3.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu3.Items.Add(item.ToString());
            }
        }

        private void comboBoxNhom3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu3.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom3.Text;
            if (comboBoxDk3.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom3.Text && item.DieuKien == comboBoxDk3.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu3.Items.Add(item.TinHieu.ToString());
            }
        }

        private void comboBoxTinHieu3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu3.Text && item.Nhom == comboBoxNhom3.Text && item.DieuKien == comboBoxDk3.Text);
            textBoxThe3.Text = d.GanThe;
            textBoxGiaTri3.Text = d.DonVi;
            textBoxMax3.Text = d.GiaTriLonNhat.ToString();
            textBoxMin3.Text = d.GiaTriNhoNhat.ToString();

        }
        #endregion nhom3
        private void comboBoxDk4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu4.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk4.Text;
            if (comboBoxNhom4.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom4.Text && item.DieuKien == comboBoxDk4.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu4.Items.Add(item.ToString());
            }
        }

        private void comboBoxNhom4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu4.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom4.Text;
            if (comboBoxDk4.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom4.Text && item.DieuKien == comboBoxDk4.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu4.Items.Add(item.TinHieu.ToString());
            }
        }

        private void comboBoxTinHieu4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu4.Text && item.Nhom == comboBoxNhom4.Text && item.DieuKien == comboBoxDk4.Text);
            textBoxThe4.Text = d.GanThe;
            textBoxGiaTri4.Text = d.DonVi;
            textBoxMax4.Text = d.GiaTriLonNhat.ToString();
            textBoxMin4.Text = d.GiaTriNhoNhat.ToString();
        }

        private void comboBoxDk5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu5.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk5.Text;
            if (comboBoxNhom5.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom5.Text && item.DieuKien == comboBoxDk5.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu5.Items.Add(item.ToString());
            }
        }

        private void comboBoxNhom5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu5.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom5.Text;
            if (comboBoxDk5.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom3.Text && item.DieuKien == comboBoxDk5.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu5.Items.Add(item.TinHieu.ToString());
            }
        }

        private void comboBoxTinHieu5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu5.Text && item.Nhom == comboBoxNhom5.Text && item.DieuKien == comboBoxDk5.Text);
            textBoxThe5.Text = d.GanThe;
            textBoxGiaTri5.Text = d.DonVi;
            textBoxMax5.Text = d.GiaTriLonNhat.ToString();
            textBoxMin5.Text = d.GiaTriNhoNhat.ToString();
        }

        private void comboBoxDk6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu6.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk6.Text;
            if (comboBoxNhom6.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom6.Text && item.DieuKien == comboBoxDk6.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu6.Items.Add(item.ToString());
            }
        }

        private void comboBoxNhom6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu6.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom6.Text;
            if (comboBoxDk6.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom6.Text && item.DieuKien == comboBoxDk6.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu6.Items.Add(item.TinHieu.ToString());
            }
        }

        private void comboBoxTinHieu6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu6.Text && item.Nhom == comboBoxNhom6.Text && item.DieuKien == comboBoxDk6.Text);
            textBoxThe6.Text = d.GanThe;
            textBoxGiaTri6.Text = d.DonVi;
            textBoxMax6.Text = d.GiaTriLonNhat.ToString();
            textBoxMin6.Text = d.GiaTriNhoNhat.ToString();
        }

        private void comboBoxDk7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu7.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk7.Text;
            if (comboBoxNhom7.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom7.Text && item.DieuKien == comboBoxDk7.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu7.Items.Add(item.ToString());
            }
        }

        private void comboBoxNhom7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu7.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom7.Text;
            if (comboBoxDk7.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom7.Text && item.DieuKien == comboBoxDk7.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu7.Items.Add(item.TinHieu.ToString());
            }
        }

        private void comboBoxTinHieu7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu7.Text && item.Nhom == comboBoxNhom7.Text && item.DieuKien == comboBoxDk7.Text);
            textBoxThe7.Text = d.GanThe;
            textBoxGiaTri7.Text = d.DonVi;
            textBoxMax7.Text = d.GiaTriLonNhat.ToString();
            textBoxMin7.Text = d.GiaTriNhoNhat.ToString();
        }

        private void comboBoxDk8_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu8.Items.Clear();
            List<Analog> d;
            String dieukien = comboBoxDk8.Text;
            if (comboBoxNhom8.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom8.Text && item.DieuKien == comboBoxDk8.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.DieuKien == dieukien).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu8.Items.Add(item.ToString());
            }
        }

        private void comboBoxNhom8_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTinHieu8.Items.Clear();
            List<Analog> d;
            String nhombom = comboBoxNhom8.Text;
            if (comboBoxDk8.Text != "")
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == comboBoxNhom8.Text && item.DieuKien == comboBoxDk8.Text).ToList();
            }
            else
            {
                d = new AnalogCommon().listAllAnalogs.Where((item) => item.Nhom == nhombom).ToList();

            }
            foreach (var item in d)
            {
                comboBoxTinHieu8.Items.Add(item.TinHieu.ToString());
            }
        }

        private void comboBoxTinHieu8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Analog d = new AnalogCommon().listAllAnalogs.FirstOrDefault((item) => item.TinHieu == comboBoxTinHieu7.Text && item.Nhom == comboBoxNhom7.Text && item.DieuKien == comboBoxDk7.Text);
            textBoxThe8.Text = d.GanThe;
            textBoxGiaTri8.Text = d.DonVi;
            textBoxMax8.Text = d.GiaTriLonNhat.ToString();
            textBoxMin8.Text = d.GiaTriNhoNhat.ToString();
        }
    }

}

