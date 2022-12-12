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
    public partial class FormLDKhuynhHuong : Form
    {
        public FormLDKhuynhHuong()
        {
            InitializeComponent();
            InitializeTimePicker();
        }

        private void InitializeTimePicker()
        {
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;
           
        }
        private void FormLDKhuynhHuong_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }
    }
}
