using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.QuanLyTramBom
{
    public partial class ToanCanhMayBom : Form
    {
        PLCSMain plcMain;
        public ToanCanhMayBom()
        {
            InitializeComponent();

            plcMain = new PLCSMain();
        }

        async Task LoadTextAnalog(Button btn, Analog a)
        {
            Analog? analog = await plcMain.GetAnAnalog(a);
            if (analog != null)
            {
                btn.Text = analog.GiaTriDong.ToString();
            }
            else
            {
                btn.Text = "N/A";
            }
        }

        async void AutoUpdate()
        {
            while (await plcMain.Open() == 0)
            {
                //analog
                await LoadTextAnalog(D10000, AnalogCommon.D10000);
                await LoadTextAnalog(D10002, AnalogCommon.D10002);
                await LoadTextAnalog(D10004, AnalogCommon.D10004);
                await LoadTextAnalog(D10006, AnalogCommon.D10006);
                await LoadTextAnalog(D10008, AnalogCommon.D10008);
                await LoadTextAnalog(D10010, AnalogCommon.D10010);
                await LoadTextAnalog(D10022, AnalogCommon.D10022);
                await LoadTextAnalog(D10024, AnalogCommon.D10024);
                await LoadTextAnalog(D10036, AnalogCommon.D10036);
                await LoadTextAnalog(D10038, AnalogCommon.D10038);
                await LoadTextAnalog(D10046, AnalogCommon.D10046);
                await LoadTextAnalog(D10048, AnalogCommon.D10048);
                await LoadTextAnalog(D10056, AnalogCommon.D10056);
                await LoadTextAnalog(D10058, AnalogCommon.D10058);



                //digital
                CheckColorBangTaiThang(await plcMain.GetADigital(DigitalCommon.M10065), await plcMain.GetADigital(DigitalCommon.M10066), await plcMain.GetADigital(DigitalCommon.M10067), await plcMain.GetADigital(DigitalCommon.M10064));
                CheckColorBangTaiXien(await plcMain.GetADigital(DigitalCommon.M10069), await plcMain.GetADigital(DigitalCommon.M10070), await plcMain.GetADigital(DigitalCommon.M10071), await plcMain.GetADigital(DigitalCommon.M10068));
                CheckColorBomMoi1(await plcMain.GetADigital(DigitalCommon.M10059));
                CheckColorBomMoi2(await plcMain.GetADigital(DigitalCommon.M10061));
                CheckColorBomThoat1(await plcMain.GetADigital(DigitalCommon.M10077));
                CheckColorBomThoat2(await plcMain.GetADigital(DigitalCommon.M10079));
                CheckColorPheuSo1(await plcMain.GetADigital(DigitalCommon.M10042), await plcMain.GetADigital(DigitalCommon.M10041), await plcMain.GetADigital(DigitalCommon.M10039), await plcMain.GetADigital(DigitalCommon.M10040));
                CheckColorPheuSo2(await plcMain.GetADigital(DigitalCommon.M10051), await plcMain.GetADigital(DigitalCommon.M10050), await plcMain.GetADigital(DigitalCommon.M10048), await plcMain.GetADigital(DigitalCommon.M10049));
                CheckColorVan1(await plcMain.GetADigital(DigitalCommon.M10125), await plcMain.GetADigital(DigitalCommon.M10124), await plcMain.GetADigital(DigitalCommon.M10122), await plcMain.GetADigital(DigitalCommon.M10123));
                CheckColorVan2(await plcMain.GetADigital(DigitalCommon.M10174), await plcMain.GetADigital(DigitalCommon.M10173), await plcMain.GetADigital(DigitalCommon.M10171), await plcMain.GetADigital(DigitalCommon.M10172));
                CheckColorVan3(await plcMain.GetADigital(DigitalCommon.M10223), await plcMain.GetADigital(DigitalCommon.M10222), await plcMain.GetADigital(DigitalCommon.M10220), await plcMain.GetADigital(DigitalCommon.M10221));
                CheckColorVan4(await plcMain.GetADigital(DigitalCommon.M10273), await plcMain.GetADigital(DigitalCommon.M10272), await plcMain.GetADigital(DigitalCommon.M10270), await plcMain.GetADigital(DigitalCommon.M10271));
                CheckColorTrangThaiBom1(await plcMain.GetADigital(DigitalCommon.M10095), await plcMain.GetADigital(DigitalCommon.M10096), await plcMain.GetADigital(DigitalCommon.M10118));
                CheckColorTrangThaiBom2(await plcMain.GetADigital(DigitalCommon.M10144), await plcMain.GetADigital(DigitalCommon.M10145), await plcMain.GetADigital(DigitalCommon.M10167));
                CheckColorTrangThaiBom3(await plcMain.GetADigital(DigitalCommon.M10193), await plcMain.GetADigital(DigitalCommon.M10194), await plcMain.GetADigital(DigitalCommon.M10216));
                CheckColorTrangThaiBom4(await plcMain.GetADigital(DigitalCommon.M10242), await plcMain.GetADigital(DigitalCommon.M10243), await plcMain.GetADigital(DigitalCommon.M10265));

                await plcMain.Close();
            }
        }












        //Check trạng thái bơm
        void ButtonTrangThaiBom(Button btn1, Button btn2, Digital? digital)
        {
            if (digital != null)
            {
                if (digital.TrangThai)
                {
                    btn1.BackColor = Color.Red;
                    btn2.BackColor = Color.Silver;
                }
                else
                {
                    btn2.BackColor = Color.Red;
                    btn1.BackColor = Color.Silver;
                }
            }
            else
            {
                btn1.BackColor = Color.Silver;
                btn2.BackColor = Color.Red;
            }
        }
        void CheckColorTrangThaiBom1(Digital? M10095, Digital? M10096, Digital? M10118)
        {
            ButtonTrangThaiBom(buttonTuXa1, buttonTaiCho1, M10095);
            ButtonTrangThaiBom(buttonPDKTT1, buttonPDien1, M10096);
            if (M10118 != null && M10118.TrangThai == true)
            {
                buttonSanSang1.BackColor = Color.Red;
            }
            else
            {
                buttonSanSang1.BackColor = Color.Silver;
            }

        }
        void CheckColorTrangThaiBom2(Digital? M10144, Digital? M10145, Digital? M10167)
        {
            ButtonTrangThaiBom(buttonTuXa2, buttonTaiCho2, M10144);
            ButtonTrangThaiBom(buttonPDKTT2, buttonPDien2, M10145);
            if (M10167 != null && M10167.TrangThai == true)
            {
                buttonSanSang2.BackColor = Color.Red;
            }
            else
            {
                buttonSanSang2.BackColor = Color.Silver;
            }

        }
        void CheckColorTrangThaiBom3(Digital? M10193, Digital? M10194, Digital? M10216)
        {
            ButtonTrangThaiBom(buttonTuXa3, buttonTaiCho3, M10193);
            ButtonTrangThaiBom(buttonPDKTT3, buttonPDien3, M10194);
            if (M10216 != null && M10216.TrangThai == true)
            {
                buttonSanSang3.BackColor = Color.Red;
            }
            else
            {
                buttonSanSang3.BackColor = Color.Silver;
            }

        }
        void CheckColorTrangThaiBom4(Digital? M10242, Digital? M10243, Digital? M10265)
        {
            ButtonTrangThaiBom(buttonTuXa4, buttonTaiCho4, M10242);
            ButtonTrangThaiBom(buttonPDKTT4, buttonPDien4, M10243);
            if (M10265 != null && M10265.TrangThai == true)
            {
                buttonSanSang4.BackColor = Color.Red;
            }
            else
            {
                buttonSanSang4.BackColor = Color.Silver;
            }

        }

        //băng tải thẳng
        void CheckColorBangTaiThang(Digital? M10065, Digital? M10066, Digital? M10067, Digital? M10064)
        {
            //vàng
            if (M10064 != null && M10064.TrangThai)
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }
            //xanh
            else if (M10067 != null && M10067.TrangThai)
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }
            //đỏ
            else if ((M10066 != null && M10066.TrangThai) && (M10065 != null && M10065.TrangThai))
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }
            else
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }

        }

        //băng tải xiên
        void CheckColorBangTaiXien(Digital? M10069, Digital? M10070, Digital? M10071, Digital? M10068)
        {
            //vàng
            if (M10068 != null && M10068.TrangThai)
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }
            //xanh
            else if (M10071 != null && M10071.TrangThai)
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }
            //đỏ
            else if ((M10069 != null && M10069.TrangThai) && (M10070 != null && M10070.TrangThai))
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }
            else
            {
                pictureBoxToanCanh.Image = Resources.backpage;
            }

        }
        //bơm mồi
        void CheckColorBomMoi1(Digital? M10059)
        {
            if (M10059 != null)
            {
                //xanh
                if (M10059.TrangThai)
                {
                    pictureBoxBomMoi1.Image = Resources.backpage;
                }
                //đỏ
                else if (M10059.TrangThai)
                {
                    pictureBoxBomMoi1.Image = Resources.backpage;
                }
            }
            else
            {
                pictureBoxBomMoi1.Image = Resources.backpage;
            }

        }
        void CheckColorBomMoi2(Digital? M10061)
        {
            if (M10061 != null)
            {
                //xanh
                if (M10061.TrangThai)
                {
                    pictureBoxBomMoi2.Image = Resources.backpage;
                }
                //đỏ
                else if (M10061.TrangThai)
                {
                    pictureBoxBomMoi2.Image = Resources.backpage;
                }
            }
            else
            {
                pictureBoxBomMoi2.Image = Resources.backpage;
            }

        }

        // bom thoat
        void CheckColorBomThoat1(Digital? M10077)
        {
            if (M10077 != null)
            {
                //xanh
                if (M10077.TrangThai)
                {
                    pictureBoxBomThoat1.Image = Resources.backpage;
                }
                //đỏ
                else if (M10077.TrangThai)
                {
                    pictureBoxBomThoat1.Image = Resources.backpage;
                }
            }
            else
            {
                pictureBoxBomThoat1.Image = Resources.backpage;
            }

        }
        void CheckColorBomThoat2(Digital? M10079)
        {
            if (M10079 != null)
            {
                //xanh
                if (M10079.TrangThai)
                {
                    pictureBoxBomThoat2.Image = Resources.backpage;
                }
                //đỏ
                else if (M10079.TrangThai)
                {
                    pictureBoxBomThoat2.Image = Resources.backpage;
                }
            }
            else
            {
                pictureBoxBomThoat2.Image = Resources.backpage;
            }

        }












        //timer digital nhấp nháy
        System.Timers.Timer TimerCheckColorPheuSo1M10039; // đỏ tím
        System.Timers.Timer TimerCheckColorPheuSo1M10040; // xanh
        bool nhapNhayPheuSo1;

        System.Timers.Timer TimerCheckColorPheuSo2M10048; // đỏ tím
        System.Timers.Timer TimerCheckColorPheuSo2M10049; //xanh tím
        bool nhapNhayPheuSo2;

        System.Timers.Timer TimerTinHieuVan1M10122; //đỏ tím
        System.Timers.Timer TimerTinHieuVan1M10123; //xanh tím
        bool nhapNhayTinHieuVan1;

        System.Timers.Timer TimerTinHieuVan2M10171; //đỏ tím
        System.Timers.Timer TimerTinHieuVan2M10172; //xanh tím
        bool nhapNhayTinHieuVan2;

        System.Timers.Timer TimerTinHieuVan3M10220; //đỏ tím
        System.Timers.Timer TimerTinHieuVan3M10221; //xanh tím
        bool nhapNhayTinHieuVan3;

        System.Timers.Timer TimerTinHieuVan4M10270; //đỏ tím
        System.Timers.Timer TimerTinHieuVan4M10271; //xanh tím
        bool nhapNhayTinHieuVan4;


        public void CloseForm()
        {
            CLearTimer(TimerCheckColorPheuSo1M10039);
            CLearTimer(TimerCheckColorPheuSo1M10040);

            CLearTimer(TimerCheckColorPheuSo2M10048);
            CLearTimer(TimerCheckColorPheuSo2M10049);

            CLearTimer(TimerTinHieuVan1M10122);
            CLearTimer(TimerTinHieuVan1M10123);

            CLearTimer(TimerTinHieuVan2M10171);
            CLearTimer(TimerTinHieuVan2M10172);

            CLearTimer(TimerTinHieuVan3M10220);
            CLearTimer(TimerTinHieuVan3M10221);

            CLearTimer(TimerTinHieuVan4M10270);
            CLearTimer(TimerTinHieuVan4M10271);



        }


        int intervalNhapNhay = 900; //ms

        void CLearTimer(System.Timers.Timer timer)
        {
            if (timer != null && timer.Enabled == true)
            {
                timer.Stop();
                timer.Dispose();
            }
        }













        // PHỄU SÔ 1

        //đỏ - tím
        private void Timer_Tick_CheckColorPheuSo1M10039(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheuSo1.Image = Resources.backpage;
                nhapNhayPheuSo1 = false;
            }
            else
            {
                pictureBoxPheuSo1.Image = Resources.backpage;
                nhapNhayPheuSo1 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorPheuSo1M10040(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheuSo1.Image = Resources.backpage;
                nhapNhayPheuSo1 = false;
            }
            else
            {
                pictureBoxPheuSo1.Image = Resources.backpage;
                nhapNhayPheuSo1 = true;
            }
        }

        void CheckColorPheuSo1(Digital? M10042, Digital? M10041, Digital? M10039, Digital? M10040)
        {
            //xanh
            if (M10042 != null && M10042.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                pictureBoxPheuSo1.Image = Resources.backpage;
            }
            //đỏ
            else if (M10041 != null && M10041.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                pictureBoxPheuSo1.Image = Resources.backpage;
            }
            //đỏ tím
            else if (M10039 != null && M10039.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10040);
                if (TimerCheckColorPheuSo1M10039 == null || TimerCheckColorPheuSo1M10039.Enabled == false)
                {
                    pictureBoxPheuSo1.Image = Resources.backpage;
                    TimerCheckColorPheuSo1M10039 = new System.Timers.Timer();
                    TimerCheckColorPheuSo1M10039.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo1M10039.Elapsed += Timer_Tick_CheckColorPheuSo1M10039;
                }
            }
            //xanh tím
            else if (M10040 != null && M10040.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                if (TimerCheckColorPheuSo1M10040 == null || TimerCheckColorPheuSo1M10040.Enabled == false)
                {
                    pictureBoxPheuSo1.Image = Resources.backpage;
                    TimerCheckColorPheuSo1M10040 = new System.Timers.Timer();
                    TimerCheckColorPheuSo1M10040.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo1M10040.Elapsed += Timer_Tick_CheckColorPheuSo1M10040;
                }
            }
            //xám
            else
            {
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10039);
                pictureBoxPheuSo1.Image = Resources.backpage;
            }
        }














        // PHỄU SÔ 2

        //đỏ - tím
        private void Timer_Tick_CheckColorPheuSo2M10048(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheuSo2.Image = Resources.backpage;
                nhapNhayPheuSo2 = false;
            }
            else
            {
                pictureBoxPheuSo2.Image = Resources.backpage;
                nhapNhayPheuSo2 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorPheuSo2M10049(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheuSo2.Image = Resources.backpage;
                nhapNhayPheuSo2 = false;
            }
            else
            {
                pictureBoxPheuSo2.Image = Resources.backpage;
                nhapNhayPheuSo2 = true;
            }
        }

        void CheckColorPheuSo2(Digital? M10051, Digital? M10050, Digital? M10048, Digital? M10049)
        {
            //xanh
            if (M10051 != null && M10051.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                pictureBoxPheuSo2.Image = Resources.backpage;
            }
            //đỏ
            else if (M10050 != null && M10050.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                pictureBoxPheuSo2.Image = Resources.backpage;
            }
            //đỏ tím
            else if (M10048 != null && M10048.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10049);
                if (TimerCheckColorPheuSo2M10048 == null || TimerCheckColorPheuSo2M10048.Enabled == false)
                {
                    pictureBoxPheuSo2.Image = Resources.backpage;
                    TimerCheckColorPheuSo2M10048 = new System.Timers.Timer();
                    TimerCheckColorPheuSo2M10048.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo2M10048.Elapsed += Timer_Tick_CheckColorPheuSo2M10048;
                }
            }
            //xanh tím
            else if (M10049 != null && M10049.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                if (TimerCheckColorPheuSo2M10049 == null || TimerCheckColorPheuSo2M10049.Enabled == false)
                {
                    pictureBoxPheuSo2.Image = Resources.backpage;
                    TimerCheckColorPheuSo2M10049 = new System.Timers.Timer();
                    TimerCheckColorPheuSo2M10049.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo2M10049.Elapsed += Timer_Tick_CheckColorPheuSo2M10049;
                }
            }
            //xám
            else
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                pictureBoxPheuSo2.Image = Resources.backpage;
            }
        }














        // Tín hiệu van 1

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan1M10122(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan1)
            {
                pictureBoxVan1.Image = Resources.backpage;
                nhapNhayTinHieuVan1 = false;
            }
            else
            {
                pictureBoxVan1.Image = Resources.backpage;
                nhapNhayTinHieuVan1 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan1M10123(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan1)
            {
                pictureBoxVan1.Image = Resources.backpage;
                nhapNhayTinHieuVan1 = false;
            }
            else
            {
                pictureBoxVan1.Image = Resources.backpage;
                nhapNhayTinHieuVan1 = true;
            }
        }

        void CheckColorVan1(Digital? M10125, Digital? M10124, Digital? M10122, Digital? M10123)
        {
            //xanh
            if (M10125 != null && M10125.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan1M10122);
                CLearTimer(TimerTinHieuVan1M10123);
                pictureBoxVan1.Image = Resources.backpage;
            }
            //đỏ
            else if (M10124 != null && M10124.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan1M10122);
                CLearTimer(TimerTinHieuVan1M10123);
                pictureBoxVan1.Image = Resources.backpage;
            }
            //đỏ tím
            else if (M10122 != null && M10122.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan1M10123);
                if (TimerTinHieuVan1M10122 == null || TimerTinHieuVan1M10122.Enabled == false)
                {
                    pictureBoxVan1.Image = Resources.backpage;
                    TimerTinHieuVan1M10122 = new System.Timers.Timer();
                    TimerTinHieuVan1M10122.Interval = intervalNhapNhay;
                    TimerTinHieuVan1M10122.Elapsed += Timer_Tick_CheckColorTinHieuVan1M10122;
                }
            }
            //xanh tím
            else if (M10123 != null && M10123.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan1M10122);
                if (TimerTinHieuVan1M10123 == null || TimerTinHieuVan1M10123.Enabled == false)
                {
                    pictureBoxVan1.Image = Resources.backpage;
                    TimerTinHieuVan1M10123 = new System.Timers.Timer();
                    TimerTinHieuVan1M10123.Interval = intervalNhapNhay;
                    TimerTinHieuVan1M10123.Elapsed += Timer_Tick_CheckColorTinHieuVan1M10123;
                }
            }
            //xám
            else
            {
                CLearTimer(TimerTinHieuVan1M10122);
                CLearTimer(TimerTinHieuVan1M10123);
                pictureBoxVan1.Image = Resources.backpage;
            }
        }
















        // Tín hiệu van 2

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan2M10171(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan2)
            {
                pictureBoxVan2.Image = Resources.backpage;
                nhapNhayTinHieuVan2 = false;
            }
            else
            {
                pictureBoxVan2.Image = Resources.backpage;
                nhapNhayTinHieuVan2 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan2M10172(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan2)
            {
                pictureBoxVan2.Image = Resources.backpage;
                nhapNhayTinHieuVan2 = false;
            }
            else
            {
                pictureBoxVan2.Image = Resources.backpage;
                nhapNhayTinHieuVan2 = true;
            }
        }

        void CheckColorVan2(Digital? M10174, Digital? M10173, Digital? M10171, Digital? M10172)
        {
            //xanh
            if (M10174 != null && M10174.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan2M10171);
                CLearTimer(TimerTinHieuVan2M10172);
                pictureBoxVan2.Image = Resources.backpage;
            }
            //đỏ
            else if (M10173 != null && M10173.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan2M10171);
                CLearTimer(TimerTinHieuVan2M10172);
                pictureBoxVan2.Image = Resources.backpage;
            }
            //đỏ tím
            else if (M10171 != null && M10171.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan2M10172);
                if (TimerTinHieuVan2M10171 == null || TimerTinHieuVan2M10171.Enabled == false)
                {
                    pictureBoxVan2.Image = Resources.backpage;
                    TimerTinHieuVan2M10171 = new System.Timers.Timer();
                    TimerTinHieuVan2M10171.Interval = intervalNhapNhay;
                    TimerTinHieuVan2M10171.Elapsed += Timer_Tick_CheckColorTinHieuVan2M10171;
                }
            }
            //xanh tím
            else if (M10172 != null && M10172.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan2M10171);
                if (TimerTinHieuVan2M10172 == null || TimerTinHieuVan2M10172.Enabled == false)
                {
                    pictureBoxVan2.Image = Resources.backpage;
                    TimerTinHieuVan2M10172 = new System.Timers.Timer();
                    TimerTinHieuVan2M10172.Interval = intervalNhapNhay;
                    TimerTinHieuVan2M10172.Elapsed += Timer_Tick_CheckColorTinHieuVan2M10172;
                }
            }
            //xám
            else
            {
                CLearTimer(TimerTinHieuVan2M10171);
                CLearTimer(TimerTinHieuVan2M10172);
                pictureBoxVan2.Image = Resources.backpage;
            }
        }









        // Tín hiệu van 3

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan3M10220(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan3)
            {
                pictureBoxVan3.Image = Resources.backpage;
                nhapNhayTinHieuVan3 = false;
            }
            else
            {
                pictureBoxVan3.Image = Resources.backpage;
                nhapNhayTinHieuVan3 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan3M10221(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan3)
            {
                pictureBoxVan3.Image = Resources.backpage;
                nhapNhayTinHieuVan3 = false;
            }
            else
            {
                pictureBoxVan3.Image = Resources.backpage;
                nhapNhayTinHieuVan3 = true;
            }
        }

        void CheckColorVan3(Digital? M10223, Digital? M10222, Digital? M10220, Digital? M10221)
        {
            //xanh
            if (M10223 != null && M10223.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan3M10220);
                CLearTimer(TimerTinHieuVan3M10221);
                pictureBoxVan3.Image = Resources.backpage;
            }
            //đỏ
            else if (M10222 != null && M10222.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan3M10220);
                CLearTimer(TimerTinHieuVan3M10221);
                pictureBoxVan3.Image = Resources.backpage;
            }
            //đỏ tím
            else if (M10220 != null && M10220.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan3M10221);
                if (TimerTinHieuVan3M10220 == null || TimerTinHieuVan3M10220.Enabled == false)
                {
                    pictureBoxVan3.Image = Resources.backpage;
                    TimerTinHieuVan3M10220 = new System.Timers.Timer();
                    TimerTinHieuVan3M10220.Interval = intervalNhapNhay;
                    TimerTinHieuVan3M10220.Elapsed += Timer_Tick_CheckColorTinHieuVan3M10220;
                }
            }
            //xanh tím
            else if (M10221 != null && M10221.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan3M10220);
                if (TimerTinHieuVan3M10221 == null || TimerTinHieuVan3M10221.Enabled == false)
                {
                    pictureBoxVan3.Image = Resources.backpage;
                    TimerTinHieuVan3M10221 = new System.Timers.Timer();
                    TimerTinHieuVan3M10221.Interval = intervalNhapNhay;
                    TimerTinHieuVan3M10221.Elapsed += Timer_Tick_CheckColorTinHieuVan3M10221;
                }
            }
            //xám
            else
            {
                CLearTimer(TimerTinHieuVan3M10220);
                CLearTimer(TimerTinHieuVan3M10221);
                pictureBoxVan3.Image = Resources.backpage;
            }
        }












        // Tín hiệu van 4

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan4M10270(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan4)
            {
                pictureBoxVan4.Image = Resources.backpage;
                nhapNhayTinHieuVan4 = false;
            }
            else
            {
                pictureBoxVan4.Image = Resources.backpage;
                nhapNhayTinHieuVan4 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan4M10271(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan4)
            {
                pictureBoxVan4.Image = Resources.backpage;
                nhapNhayTinHieuVan4 = false;
            }
            else
            {
                pictureBoxVan4.Image = Resources.backpage;
                nhapNhayTinHieuVan4 = true;
            }
        }

        void CheckColorVan4(Digital? M10273, Digital? M10272, Digital? M10270, Digital? M10271)
        {
            //xanh
            if (M10273 != null && M10273.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10270);
                CLearTimer(TimerTinHieuVan4M10271);
                pictureBoxVan4.Image = Resources.backpage;
            }
            //đỏ
            else if (M10272 != null && M10272.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10270);
                CLearTimer(TimerTinHieuVan4M10271);
                pictureBoxVan4.Image = Resources.backpage;
            }
            //đỏ tím
            else if (M10270 != null && M10270.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10271);
                if (TimerTinHieuVan4M10270 == null || TimerTinHieuVan4M10270.Enabled == false)
                {
                    pictureBoxVan4.Image = Resources.backpage;
                    TimerTinHieuVan4M10270 = new System.Timers.Timer();
                    TimerTinHieuVan4M10270.Interval = intervalNhapNhay;
                    TimerTinHieuVan4M10270.Elapsed += Timer_Tick_CheckColorTinHieuVan4M10270;
                }
            }
            //xanh tím
            else if (M10271 != null && M10271.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10270);
                if (TimerTinHieuVan4M10271 == null || TimerTinHieuVan4M10271.Enabled == false)
                {
                    pictureBoxVan4.Image = Resources.backpage;
                    TimerTinHieuVan4M10271 = new System.Timers.Timer();
                    TimerTinHieuVan4M10271.Interval = intervalNhapNhay;
                    TimerTinHieuVan4M10271.Elapsed += Timer_Tick_CheckColorTinHieuVan4M10271;
                }
            }
            //xám
            else
            {
                CLearTimer(TimerTinHieuVan4M10270);
                CLearTimer(TimerTinHieuVan4M10271);
                pictureBoxVan4.Image = Resources.backpage;
            }
        }







    }
}
