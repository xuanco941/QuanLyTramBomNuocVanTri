using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
