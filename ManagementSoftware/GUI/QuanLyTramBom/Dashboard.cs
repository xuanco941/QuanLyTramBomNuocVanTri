
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using System.Globalization;

namespace QuanLyTramBom
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();


            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            ToanCanhMayBom form = new ToanCanhMayBom();
            form.TopLevel = false;
            panelContent1.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();


            FormDSVaoRaTT form1 = new FormDSVaoRaTT();
            form1.TopLevel = false;
            panelContent4.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Show();

            FormKHThoiGianThuc form3 = new FormKHThoiGianThuc();
            form3.TopLevel = false;
            panelContent3.Controls.Add(form3);
            form3.Dock = DockStyle.Fill;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Show();

            //clock
            clock1.MinimumSize = new Size(65, 65);
            clock1.Size = new System.Drawing.Size(65,65);
            clock1.Location = new Point(1259, 4);

            //timer new alert
            timerGetNewAlert.Start();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tabPage1)
            {
               /* foreach (Form2 item in panelContent1.Controls)
                {
                    item.Dispose();
                    item.Close();
                }
               */
                ToanCanhMayBom form = new ToanCanhMayBom();
                form.TopLevel= false;
                panelContent1.Controls.Add(form);
                form.Dock= DockStyle.Fill;
                form.FormBorderStyle= FormBorderStyle.None;
                form.Show();
            }else if(e.TabPage == tabPage4)
            {
                FormDSVaoRaTT form1 = new FormDSVaoRaTT();
                form1.TopLevel = false;
                panelContent4.Controls.Add(form1);
                form1.Dock = DockStyle.Fill;
                form1.FormBorderStyle = FormBorderStyle.None;
                form1.Show();
            }
            else if (e.TabPage == tabPage2)
            {
                FormLDKhuynhHuong form2 = new FormLDKhuynhHuong();
                form2.TopLevel = false;
                panelContent2.Controls.Add(form2);
                form2.Dock = DockStyle.Fill;
                form2.FormBorderStyle = FormBorderStyle.None;
                form2.Show();
            }
            else if (e.TabPage == tabPage3)
            {
                FormKHThoiGianThuc form3 = new FormKHThoiGianThuc();
                form3.TopLevel = false;
                panelContent3.Controls.Add(form3);
                form3.Dock = DockStyle.Fill;
                form3.FormBorderStyle = FormBorderStyle.None;
                form3.Show();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            panelContent4.Controls.Clear();
            FormDSVaoRaSo form3 = new FormDSVaoRaSo();
            form3.TopLevel = false;
            form3.Dock = DockStyle.Fill;
            form3.FormBorderStyle = FormBorderStyle.None;
            panelContent4.Controls.Add(form3);
            form3.Show();
            button3.ForeColor = Color.Red;
            button4.ForeColor = Color.White;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelContent4.Controls.Clear();
            FormDSVaoRaTT form4 = new FormDSVaoRaTT();
            form4.TopLevel = false;
            form4.Dock = DockStyle.Fill;
            form4.FormBorderStyle = FormBorderStyle.None;
            panelContent4.Controls.Add(form4);
            form4.Show();
            button4.ForeColor = Color.Red;
            button3.ForeColor = Color.White;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableAlert tb = new TableAlert();
            tb.ShowDialog();
            
        }

        private void timerGetNewAlert_Tick(object sender, EventArgs e)
        {
            Alert? a = DALAlert.GetNewAlert();
            if (a != null)
            {
                labelSTT.Text = "ID"+ a.IDAlert;
                labelGanThe.Text = a.GanThe;
                labelThoiGian.Text = a.ThoiGian.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                labelDieuKien.Text = a.DieuKien;
                labelNhom.Text = a.Nhom;
                labelMoTa.Text = a.TinHieu;
                labelGiaTri.Text = a.TrangThai == true ? "true" : "false";
            }
        }
    }
}