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
            if (radioButton2.Checked)
            {
                checkedListBox1.Enabled= true;
                
            }
            else
            {
                checkedListBox1.Enabled = false;
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
            List<Digital> d = DigitalCommon.listD.Where((item) => item.Nhom == nhombom && item.DieuKien == comboBox3.Text).ToList();
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
            List<Digital> d = DigitalCommon.listD.Where((item) => item.Nhom == nhombom && item.DieuKien == comboBox3.Text).ToList();
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

       
    }
}
