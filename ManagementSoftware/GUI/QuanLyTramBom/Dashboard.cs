
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;
using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using ManagementSoftware.Properties;
using Syncfusion.Windows.Forms.Tools;
using System.Diagnostics;

namespace QuanLyTramBom
{
    public partial class Dashboard : Form
    {

        PLCAlert plcAlert;

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        public Dashboard()
        {
            InitializeComponent();


            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            GoFullscreen(true);

            plcAlert = new PLCAlert();




            ////clock


            Panel floater = CreateFloatingPanel(panel4);
            floater.BackColor = Color.Transparent;
            Clock clock1 = new Clock();
            clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            clock1.MinimumSize = new Size(65, 65);
            clock1.Size = new System.Drawing.Size(120, 90);
            floater.Location = new Point(1780, 1);
            floater.Size = new Size(120, 60);
            floater.Controls.Add(clock1);


            //printer
            Panel floater2 = CreateFloatingPanel(panel12);
            floater2.BackColor = Color.Transparent;
            PictureBox pic = new PictureBox();
            pic.Cursor = Cursors.Hand;
            pic.Image = Resources._64printer;
            pic.Dock = DockStyle.Fill;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //pic.MinimumSize = new Size(50, 50);
            //pic.Size = new Size(50, 50);
            floater2.Location = new Point(1613, 4);
            floater2.Size = new Size(65, 65);
            floater2.Controls.Add(pic);
            pic.Click += new System.EventHandler(this.btnButton_Click);



            //logout
            Panel floater3 = CreateFloatingPanel(panel13);
            floater3.BackColor = Color.Transparent;
            PictureBox picLogOut = new PictureBox();
            picLogOut.Cursor = Cursors.Hand;
            picLogOut.Image = Resources._65logout;
            picLogOut.Dock = DockStyle.Fill;
            picLogOut.SizeMode = PictureBoxSizeMode.StretchImage;
            //pic.MinimumSize = new Size(50, 50);
            //pic.Size = new Size(50, 50);
            floater3.Location = new Point(1709, 15);
            floater3.Size = new Size(45, 45);
            floater3.Controls.Add(picLogOut);
            picLogOut.Click += new System.EventHandler(this.btnButton_ClickLogOut);


        }


        void btnButton_Click(object sender, EventArgs e)
        {
            FormInBaoCao form = new FormInBaoCao();
            form.ShowDialog();
        }


        void btnButton_ClickLogOut(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn phải xác nhận tài khoản đăng nhập để thoát.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                XacNhanDangXuat form = new XacNhanDangXuat("Dashboard");
                form.callback = new XacNhanDangXuat.Callback(CloseForm);
                form.ShowDialog();
            }

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







        private void buttonBangLoi_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            TableAlert tb = new TableAlert();
            tb.ShowDialog();
            this.Enabled = true;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                foreach (FormKHThoiGianThuc f in tabPage2.Controls)
                {
                    f.Enabled = false;
                    f.Close();
                    f.Dispose();
                }
                foreach (FormQuanLyLuuTruDuLieu f in tabPage3.Controls)
                {
                    f.Enabled = false;
                    f.Close();
                    f.Dispose();

                }

                foreach (FormQuanLyDSVaoRa f in tabPage4.Controls)
                {

                    f.Enabled = false;
                    f.Close();
                    f.Dispose();

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
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

                }
                foreach (FormQuanLyLuuTruDuLieu f in tabPage3.Controls)
                {
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

                }

                foreach (FormQuanLyDSVaoRa f in tabPage4.Controls)
                {
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

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
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

                }
                foreach (FormKHThoiGianThuc f in tabPage2.Controls)
                {
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

                }

                foreach (FormQuanLyDSVaoRa f in tabPage4.Controls)
                {
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

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
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

                }
                foreach (FormKHThoiGianThuc f in tabPage2.Controls)
                {
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

                }

                foreach (FormQuanLyLuuTruDuLieu f in tabPage3.Controls)
                {
                    f.Enabled = false;

                    f.Close();
                    f.Dispose();

                }
                FormQuanLyDSVaoRa form = new FormQuanLyDSVaoRa();
                form.TopLevel = false;
                tabPage4.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
            }
        }























        System.Threading.Timer timer;
        int TIME_INTERVAL_IN_MILLISECONDS = 1500;


        private async void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                this.timer.Change(Timeout.Infinite, Timeout.Infinite);
                timer.Dispose();
                timer = null;
            }
            await plcAlert.Close();
        }

        public void CloseForm()
        {
            this.Close();
            this.Dispose();
        }








        /// <summary>
        /// ///////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private async void Dashboard_Load(object sender, EventArgs e)
        {


            ToanCanhTramBom formToanCanh = new ToanCanhTramBom();
            formToanCanh.TopLevel = false;
            panelContentToanCanh.Controls.Add(formToanCanh);
            formToanCanh.Dock = DockStyle.Fill;
            formToanCanh.FormBorderStyle = FormBorderStyle.None;
            formToanCanh.Show();

            await plcAlert.Open();

            timer = new System.Threading.Timer(Callback, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);

        }


        private async void Callback(Object state)
        {

            Stopwatch watch = new Stopwatch();

            watch.Start();


            // update data
            // Long running operation

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


            if(alertTrue==null || alertTrue.Count < 1)
            {
                UpdateData(null);
            }
            else
            {
                UpdateData(alertHistories);
            }


            if (timer != null)
            {
                timer.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }



        private void UpdateData(List<AlertHistory>? alertHistories)
        {

            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action<List<AlertHistory>>(UpdateData), alertHistories);
                return;
            }


            //update gui

            if (alertHistories != null && alertHistories.Count > 0)
            {
                AlertHistory? alertERR = DALAlertHistory.GetNewestAlertHistory();
                if (alertERR != null)
                {
                    labelNgay.Text = alertERR.ThoiGian.ToString("dd/MM/yyyy");
                    labelNhom.Text = alertERR.Nhom;
                    labelMoTa.Text = alertERR.TinHieu;
                    labelGanThe.Text = alertERR.GanThe;
                    labelThoiGian.Text = alertERR.ThoiGian.ToString("hh:mm:ss");
                    labelDieuKien.Text = alertERR.DieuKien;
                    labelGiaTri.Text = alertHistories.Count.ToString();
                }
                else
                {
                    labelNgay.Text = "";
                    labelNhom.Text = "";
                    labelMoTa.Text = "";
                    labelGanThe.Text = "";
                    labelThoiGian.Text = "";
                    labelDieuKien.Text = "";
                    labelGiaTri.Text = "";
                }
            }
            else
            {
                labelNgay.Text = "";
                labelNhom.Text = "";
                labelMoTa.Text = "";
                labelGanThe.Text = "";
                labelThoiGian.Text = "";
                labelDieuKien.Text = "";
                labelGiaTri.Text = "";
            }


        }



    }
}