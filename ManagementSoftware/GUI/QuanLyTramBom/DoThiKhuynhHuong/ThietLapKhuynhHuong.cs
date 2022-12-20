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
            }
            for (int i = 0; i < bom.Count; i++)
            {
                comboBoxNhom1.Items.Add(bom[i]);
            }
        }

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
        }
    }
}

