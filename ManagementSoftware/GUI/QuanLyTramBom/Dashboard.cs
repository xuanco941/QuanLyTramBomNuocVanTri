
using ManagementSoftware.AutoAddData;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
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



            //clock
            clock1.MinimumSize = new Size(65, 65);
            clock1.Size = new System.Drawing.Size(65, 65);
            clock1.Location = new Point(1259, 5);


        }

        //void CLoseAllTab()
        //{
        //    if (panelContentToanCanh.Controls.Count > 0)
        //    {
        //        foreach (ToanCanhMayBom item in panelContentToanCanh.Controls)
        //        {
        //            item.Close();
        //            item.Dispose();
        //        }
        //    }
        //    if (tabPage4.Controls.Count > 0)
        //    {
        //        foreach (FormQuanLyLuuTruDuLieu item in tabPage4.Controls)
        //        {
        //            item.Close();
        //            item.Dispose();
        //        }
        //    }

        //}
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage != tabPage1)
            {
                foreach (ToanCanhMayBom form in panelContentToanCanh.Controls)
                {
                    form.CloseForm();
                    form.Close();
                }

            }
            else
            {
                ToanCanhMayBom formToanCanh = new ToanCanhMayBom();
                formToanCanh.TopLevel = false;
                panelContentToanCanh.Controls.Add(formToanCanh);
                formToanCanh.Dock = DockStyle.Fill;
                formToanCanh.FormBorderStyle = FormBorderStyle.None;
                formToanCanh.Show();
            }
            if (e.TabPage == tabPage2)
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


        private void button2_Click(object sender, EventArgs e)
        {
            TableAlert tb = new TableAlert();
            tb.ShowDialog();

        }


        void SetTextControl(Label label, string text)
        {
            label.Invoke(new Action(() => { label.Text = text; }));
        }
        private async void timerGetNewAlert_Tick(object sender, EventArgs e)
        {
            if(AlertCurrent.Data!=null && AlertCurrent.Data.Count > 0)
            {
                List<Alert>? listALl = await PLCAlert.GetListDataAlertTrue();
                if (listALl != null)
                {
                    foreach (var i in listALl)
                    {
                        foreach (var j in AlertCurrent.Data)
                        {
                            if(i.TinHieu != j.TinHieu)
                            {
                                AlertCurrent.Data.Add(i);
                            }
                        }
                    }
                }
            }
            else
            {
                AlertCurrent.Data = await PLCAlert.GetListDataAlertTrue();
            }
            if (AlertCurrent.Data != null && AlertCurrent.Data.Count > 0)
            {
                DateTime dateTimeMax = AlertCurrent.Data.Max((m) => m.ThoiGian);
                Alert? alertERR = AlertCurrent.Data.Where((a) => a.ThoiGian == dateTimeMax).FirstOrDefault();
                if (alertERR != null)
                {
                    SetTextControl(labelNgay, alertERR.ThoiGian.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    SetTextControl(labelNhom, alertERR.Nhom);
                    SetTextControl(labelMoTa, alertERR.TinHieu);
                    SetTextControl(labelGanThe, alertERR.GanThe);
                    SetTextControl(labelThoiGian, alertERR.ThoiGian.ToString("hh:mm:ss", CultureInfo.InvariantCulture));
                    SetTextControl(labelDieuKien, alertERR.DieuKien);
                    SetTextControl(labelGiaTri, AlertCurrent.Data.Count.ToString());
                }
            }
            else
            {
                SetTextControl(labelNgay,"");
                SetTextControl(labelNhom, "");
                SetTextControl(labelMoTa, "");
                SetTextControl(labelGanThe, "");
                SetTextControl(labelThoiGian, "");
                SetTextControl(labelDieuKien, "");
                SetTextControl(labelGiaTri, "");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ToanCanhMayBom formToanCanh = new ToanCanhMayBom();
            formToanCanh.TopLevel = false;
            panelContentToanCanh.Controls.Add(formToanCanh);
            formToanCanh.Dock = DockStyle.Fill;
            formToanCanh.FormBorderStyle = FormBorderStyle.None;
            formToanCanh.Show();

            FormQuanLyDSVaoRa formQuanLyDSVaoRa = new FormQuanLyDSVaoRa();
            formQuanLyDSVaoRa.TopLevel = false;
            tabPage4.Controls.Add(formQuanLyDSVaoRa);
            formQuanLyDSVaoRa.Dock = DockStyle.Fill;
            formQuanLyDSVaoRa.FormBorderStyle = FormBorderStyle.None;
            formQuanLyDSVaoRa.Show();


            //timer new alert
            timerGetNewAlert.Start();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerGetNewAlert.Stop();
            timerGetNewAlert.Dispose();
        }
    }
}