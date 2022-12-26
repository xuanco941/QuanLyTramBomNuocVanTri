
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;
using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using Syncfusion.Windows.Forms.Tools;

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
            plcAlert = new PLCAlert();



            ////clock


            Panel floater = CreateFloatingPanel(panel3);
            floater.BackColor = Color.Transparent;
            Clock clock1 = new Clock();
            clock1.MinimumSize = new Size(65, 65);
            clock1.Size = new System.Drawing.Size(65, 65);
            floater.Location = new Point(1830, 1);
            floater.Size = new Size(65, 65);
            floater.Controls.Add(clock1);


        }

        public Panel CreateFloatingPanel(Panel originalPanel)
        {
            Bitmap bmp = new Bitmap(originalPanel.Width,
                originalPanel.Height);
            Rectangle rect = new Rectangle(0, 0,
                bmp.Width, bmp.Height);
            originalPanel.DrawToBitmap(bmp, rect);
            foreach (Control ctrl in originalPanel.Controls)
            {
                ctrl.Visible = false;
            }
            using (Graphics g = Graphics.FromHwnd(originalPanel.Handle))
            {
                g.DrawImage(bmp, 0, 0);
                bmp.Dispose();
                SolidBrush brush =
                    new SolidBrush(Color.FromArgb(128, Color.Gray));
                g.FillRectangle(brush, rect);
                brush.Dispose();
            }
            Panel floater = new Panel();
            floater.Size = originalPanel.Size;
            floater.Left = originalPanel.Left - 50;
            floater.Top = originalPanel.Top - 50;
            this.Controls.Add(floater);
            floater.BringToFront();
            return floater;
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
        System.Timers.Timer timer;

        private async void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null && timer.Enabled == true)
            {
                timer.Stop();
                timer.Dispose();
            }
            await plcAlert.Close();
        }

        private async void timerGetNewAlert_Tick_1(object sender, EventArgs e)
        {
            List<Alert>? alertTrue = await plcAlert.GetListDataAlertTrue();
            List<AlertHistory>? alertHistories = DALAlertHistory.GetAllAlertHistory();
            if (alertTrue != null && alertTrue.Count > 0)
            {

                if (alertHistories != null && alertHistories.Count > 0)
                {

                    foreach (var i in alertTrue)
                    {
                        bool check = false;
                        foreach (var j in alertHistories.ToList())
                        {
                            if (i.TinHieu != j.TinHieu)
                            {
                                check = true;
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check == true)
                        {
                            await DALAlertHistory.AddAlertHistory(i);
                        }
                    }

                }
                else
                {
                    await DALAlertHistory.AddRangeHistory(alertTrue);
                }


            }

            if (alertHistories != null && alertHistories.Count > 0)
            {
                AlertHistory? alertERR = DALAlertHistory.GetNewestAlertHistory();
                if (alertERR != null)
                {
                    SetTextControl(labelNgay, alertERR.ThoiGian.ToString("dd/MM/yyyy"));
                    SetTextControl(labelNhom, alertERR.Nhom);
                    SetTextControl(labelMoTa, alertERR.TinHieu);
                    SetTextControl(labelGanThe, alertERR.GanThe);
                    SetTextControl(labelThoiGian, alertERR.ThoiGian.ToString("hh:mm:ss"));
                    SetTextControl(labelDieuKien, alertERR.DieuKien);
                    SetTextControl(labelGiaTri, alertHistories.Count.ToString());
                }
            }
            else
            {
                SetTextControl(labelNgay, "");
                SetTextControl(labelNhom, "");
                SetTextControl(labelMoTa, "");
                SetTextControl(labelGanThe, "");
                SetTextControl(labelThoiGian, "");
                SetTextControl(labelDieuKien, "");
                SetTextControl(labelGiaTri, "");
            }
        }
        private void buttonViewTableLoi_Click(object sender, EventArgs e)
        {
            TableAlert tb = new TableAlert();
            tb.ShowDialog();
        }












        /// <summary>
        /// ///////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await plcAlert.Open();

            ToanCanhTramBom formToanCanh = new ToanCanhTramBom();
            formToanCanh.TopLevel = false;
            panelContentToanCanh.Controls.Add(formToanCanh);
            formToanCanh.Dock = DockStyle.Fill;
            formToanCanh.FormBorderStyle = FormBorderStyle.None;
            formToanCanh.Show();

            //timer new alert
            new Thread(() =>
            {
                timer = new System.Timers.Timer();
                timer.Elapsed += timerGetNewAlert_Tick_1;
                timer.Interval = 1500;
                timer.Start();

            }).Start();

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




        //ToanCanhTramBom DformToanCanh;
        //bool checkLoadedDformToanCanh = false;

        //FormKHThoiGianThuc DformKHThoiGianThuc;
        //bool checkLoadedDformKHThoiGianThuc = false;

        //FormQuanLyLuuTruDuLieu DformQuanLyDuLieu;
        //bool checkLoadedDformQuanLyDuLieu = false;

        //FormQuanLyDSVaoRa DformQuanLyDSVaoRa;
        //bool checkLoadedDformQuanLyDSVaoRa = false;




        //void DashboardLoad()
        //{
        //    if (checkLoadedDformToanCanh == false)
        //    {
        //        DformToanCanh = new ToanCanhTramBom();
        //        DformToanCanh.TopLevel = false;
        //        panelContentToanCanh.Controls.Add(DformToanCanh);
        //        DformToanCanh.Dock = DockStyle.Fill;
        //        DformToanCanh.FormBorderStyle = FormBorderStyle.None;
        //        DformToanCanh.Show();

        //        checkLoadedDformToanCanh = true;
        //    }
        //    if(checkLoadedDformKHThoiGianThuc == false)
        //    {
        //        DformKHThoiGianThuc = new FormKHThoiGianThuc();
        //        DformKHThoiGianThuc.TopLevel = false;
        //        tabPage2.Controls.Add(DformKHThoiGianThuc);
        //        DformKHThoiGianThuc.Dock = DockStyle.Fill;
        //        DformKHThoiGianThuc.FormBorderStyle = FormBorderStyle.None;
        //        DformKHThoiGianThuc.Show();
                
        //        c
        //    }


        //    FormQuanLyLuuTruDuLieu form = new FormQuanLyLuuTruDuLieu();
        //    form.TopLevel = false;
        //    tabPage3.Controls.Add(form);
        //    form.Dock = DockStyle.Fill;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Show();

        //    FormQuanLyDSVaoRa form = new FormQuanLyDSVaoRa();
        //    form.TopLevel = false;
        //    tabPage4.Controls.Add(form);
        //    form.Dock = DockStyle.Fill;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Show();


        //}
    }
}