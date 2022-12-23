
using ManagementSoftware.AutoAddData;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;
using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using Syncfusion.Windows.Forms.Tools;
using System.Globalization;

namespace QuanLyTramBom
{
    public partial class Dashboard : Form
    {
        PLCAlert plcAlert;

        public Dashboard()
        {
            InitializeComponent();


            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;



            ////clock
            //clock1.MinimumSize = new Size(65, 65);
            //clock1.Size = new System.Drawing.Size(65, 65);
            //clock1.Location = new Point(1259, 5);

            plcAlert = new PLCAlert();
            plcAlert.Open();
        }



        void SetTextControl(Label label, string text)
        {
            if (IsHandleCreated)
            {
                BeginInvoke(() =>
                {
                    label.Text = text;
                });
                return;
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ToanCanhTramBom formToanCanh = new ToanCanhTramBom();
            formToanCanh.TopLevel = false;
            panelContentToanCanh.Controls.Add(formToanCanh);
            formToanCanh.Dock = DockStyle.Fill;
            formToanCanh.FormBorderStyle = FormBorderStyle.None;
            formToanCanh.Show();

            //timer new alert
            timerGetNewAlert.Start();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerGetNewAlert != null && timerGetNewAlert.Enabled == true)
            {
                timerGetNewAlert.Stop();
                timerGetNewAlert.Dispose();
            }
            plcAlert.Close();
        }

        private void buttonViewTableLoi_Click(object sender, EventArgs e)
        {
            TableAlert tb = new TableAlert();
            tb.ShowDialog();
        }

        private async void timerGetNewAlert_Tick_1(object sender, EventArgs e)
        {
            //    if (AlertCurrent.Data != null && AlertCurrent.Data.Count > 0)
            //    {
            //        List<Alert>? listALl = await plcAlert.GetListDataAlertTrue();
            //        if (listALl != null)
            //        {
            //            foreach (var i in listALl)
            //            {
            //                foreach (var j in AlertCurrent.Data.ToList())
            //                {
            //                    if (i.TinHieu != j.TinHieu)
            //                    {
            //                        AlertCurrent.Data.Add(i);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        AlertCurrent.Data = await plcAlert.GetListDataAlertTrue();
            //    }
            //    if (AlertCurrent.Data != null && AlertCurrent.Data.Count > 0)
            //    {
            //        DateTime dateTimeMax = AlertCurrent.Data.Max((m) => m.ThoiGian);
            //        Alert? alertERR = AlertCurrent.Data.Where((a) => a.ThoiGian == dateTimeMax).FirstOrDefault();
            //        if (alertERR != null)
            //        {
            //            SetTextControl(labelNgay, alertERR.ThoiGian.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            //            SetTextControl(labelNhom, alertERR.Nhom);
            //            SetTextControl(labelMoTa, alertERR.TinHieu);
            //            SetTextControl(labelGanThe, alertERR.GanThe);
            //            SetTextControl(labelThoiGian, alertERR.ThoiGian.ToString("hh:mm:ss", CultureInfo.InvariantCulture));
            //            SetTextControl(labelDieuKien, alertERR.DieuKien);
            //            SetTextControl(labelGiaTri, AlertCurrent.Data.Count.ToString());
            //        }
            //    }
            //    else
            //    {
            //        SetTextControl(labelNgay, "");
            //        SetTextControl(labelNhom, "");
            //        SetTextControl(labelMoTa, "");
            //        SetTextControl(labelGanThe, "");
            //        SetTextControl(labelThoiGian, "");
            //        SetTextControl(labelDieuKien, "");
            //        SetTextControl(labelGiaTri, "");
            //    }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                foreach (FormKHThoiGianThuc f in tabPage2.Controls)
                {
                    f.Close();
                }
                foreach (FormQuanLyLuuTruDuLieu f in tabPage3.Controls)
                {
                    f.Close();
                }

                foreach (FormQuanLyDSVaoRa f in tabPage4.Controls)
                {
                    f.Close();
                }
                ToanCanhTramBom form = new ToanCanhTramBom();
                form.TopLevel = false;
                panelContentToanCanh.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();

            }
            else if (e.TabPage == tabPage2)
            {
                foreach (ToanCanhTramBom f in panelContentToanCanh.Controls)
                {
                    f.Close();
                }
                foreach (FormQuanLyLuuTruDuLieu f in tabPage3.Controls)
                {
                    f.Close();
                }

                foreach (FormQuanLyDSVaoRa f in tabPage4.Controls)
                {
                    f.Close();
                }
                FormKHThoiGianThuc form = new FormKHThoiGianThuc();
                form.TopLevel = false;
                tabPage2.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
            }
            else if (e.TabPage == tabPage3)
            {
                foreach (ToanCanhTramBom f in panelContentToanCanh.Controls)
                {
                    f.Close();
                }
                foreach (FormKHThoiGianThuc f in tabPage2.Controls)
                {
                    f.Close();
                }

                foreach (FormQuanLyDSVaoRa f in tabPage4.Controls)
                {
                    f.Close();
                }
                FormQuanLyLuuTruDuLieu form = new FormQuanLyLuuTruDuLieu();
                form.TopLevel = false;
                tabPage3.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
            }
            else if (e.TabPage == tabPage4)
            {
                foreach (ToanCanhTramBom f in panelContentToanCanh.Controls)
                {
                    f.Close();
                }
                foreach (FormKHThoiGianThuc f in tabPage2.Controls)
                {
                    f.Close();
                }

                foreach (FormQuanLyLuuTruDuLieu f in tabPage3.Controls)
                {
                    f.Close();
                }
                FormQuanLyDSVaoRa form = new FormQuanLyDSVaoRa();
                form.TopLevel = false;
                tabPage4.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
            }
        }
    }
}