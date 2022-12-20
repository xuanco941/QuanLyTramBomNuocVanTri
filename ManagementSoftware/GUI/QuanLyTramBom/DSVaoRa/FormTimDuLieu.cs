using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTramBom
{
    
    public partial class FormTimDuLieu : Form
    {
        public delegate void CallBackSetSearch(string loaibom, List<string> tinhieu);
        public CallBackSetSearch callBackSetSearch;
        public List<Digital> lisAllDigital;
        public FormTimDuLieu()
        {
            InitializeComponent();
        }

        
        private void FormTimDuLieu_Load(object sender, EventArgs e)
        {
            List<String> bom = new List<String>();
            bom.Add("Chung");
            bom.Add("Bơm 1");
            bom.Add("Bơm 2");
            bom.Add("Bơm 3");
            bom.Add("Bơm 4");

            for (int i=0; i< bom.Count; i++)
            {
                comboBox1.Items.Add(bom[i]);
            }

            comboBox3.Text = "DPS";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            String nhombom = comboBox1.Text;
            List<Digital> d = new DigitalCommon().ListAllDigitals.Where((item) => item.Nhom == nhombom && item.DieuKien == comboBox3.Text).ToList();
            //.Where((item, index) => AlertCommon.listAlert[index].DieuKien == "DPS").ToList();
            foreach (var item in d)
            {
                checkedListBox1.Items.Add(item.TinHieu.ToString());
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            String nhombom = comboBox1.Text;
            List<Digital> d = new DigitalCommon().ListAllDigitals.Where((item) => item.Nhom == nhombom && item.DieuKien == comboBox3.Text).ToList();
            //.Where((item, index) => AlertCommon.listAlert[index].DieuKien == "DPS").ToList();
            foreach (var item in d)
            {
                checkedListBox1.Items.Add(item.TinHieu.ToString());
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
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
            callBackSetSearch?.Invoke(null, listTinHieu);
            this.Close();
        }
    }
}
