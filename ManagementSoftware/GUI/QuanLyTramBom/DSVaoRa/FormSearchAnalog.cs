﻿using ManagementSoftware.Models.DuLieuMayPLC;
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

namespace ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa
{
    public partial class FormSearchAnalog : Form
    {
        public delegate void CallBackSetSearch(List<string> tinhieu);
        public CallBackSetSearch callBackSetSearch;
        public List<Analog> listAllAnalog;
        public FormSearchAnalog()
        {
            InitializeComponent();

            listAllAnalog = new AnalogCommon().listAllAnalogs;
            comboBoxNhomBom.DataSource = new List<string>() { "Tất cả", NhomBom.Chung, NhomBom.Bom1, NhomBom.Bom2, NhomBom.Bom3, NhomBom.Bom4 };
            comboBoxDieuKien.DataSource = new List<string>() { "DPS" };
            foreach (var item in listAllAnalog)
            {
                checkedListBox1.Items.Add(item.TinHieu);
            }

        }



        void SetCheckList()
        {
            checkedListBox1.Items.Clear();
            if (comboBoxNhomBom.Text == "Tất cả")
            {
                foreach (var item in listAllAnalog)
                {
                    if (item.DieuKien == comboBoxDieuKien.Text)
                    {
                        checkedListBox1.Items.Add(item.TinHieu);
                    }
                }
            }
            else
            {
                foreach (var item in listAllAnalog)
                {
                    if (item.Nhom == comboBoxNhomBom.Text && item.DieuKien == comboBoxDieuKien.Text)
                    {
                        checkedListBox1.Items.Add(item.TinHieu);
                    }
                }
            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            List<string>? listTinHieu = new List<string>();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string selectedItem = itemChecked.ToString();
                if (String.IsNullOrEmpty(selectedItem) == false)
                {
                    listTinHieu.Add(selectedItem);
                }
            }
            callBackSetSearch?.Invoke(listTinHieu);
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonSelectAll_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void comboBoxNhomBom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCheckList();

        }

        private void comboBoxDieuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCheckList();

        }
    }
}