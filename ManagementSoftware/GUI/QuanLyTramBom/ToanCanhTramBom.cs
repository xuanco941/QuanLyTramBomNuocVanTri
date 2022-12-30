using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
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
    public partial class ToanCanhTramBom : Form
    {
        PLCAnalog plcAnalog;
        PLCDigital plcDigital;

        AnalogCommon analogCommon;
        DigitalCommon digitalCommon;
        public ToanCanhTramBom()
        {
            InitializeComponent();
            plcAnalog = new PLCAnalog();
            plcDigital = new PLCDigital();
            analogCommon = new AnalogCommon();
            digitalCommon = new DigitalCommon();
        }
        async Task LoadTextAnalog(Label btn, Analog a)
        {
            Analog? analog = await plcAnalog.GetAnAnalog(a);
            if (IsHandleCreated)
            {
                BeginInvoke(() =>
                {
                    if (analog != null)
                    {
                        string str = String.Format("{0:0.00}", analog.GiaTriDong);
                        if(a.DiaChiPLC=="D10000" || a.DiaChiPLC == "D10004" || a.DiaChiPLC =="D10002" || a.DiaChiPLC == "D10006")
                        {
                            str = str +"  "+ a.DonVi;
                        }
                        btn.Text = str;
                    }
                    else
                    {
                        btn.Text = "N/A";
                    }
                });
                return;
            }
        }
        async void AutoUpdateAnalog()
        {
            //analog
            await LoadTextAnalog(D10000, analogCommon.D10000);
            await LoadTextAnalog(D10002, analogCommon.D10002);
            await LoadTextAnalog(D10004, analogCommon.D10004);
            await LoadTextAnalog(D10006, analogCommon.D10006);
            await LoadTextAnalog(D10008, analogCommon.D10008);
            await LoadTextAnalog(D10010, analogCommon.D10010);
            await LoadTextAnalog(D10022, analogCommon.D10022);
            await LoadTextAnalog(D10024, analogCommon.D10024);
            await LoadTextAnalog(D10036, analogCommon.D10036);
            await LoadTextAnalog(D10038, analogCommon.D10038);
            await LoadTextAnalog(D10050, analogCommon.D10050);
            await LoadTextAnalog(D10052, analogCommon.D10052);
            await LoadTextAnalog(D10064, analogCommon.D10064);
            await LoadTextAnalog(D10066, analogCommon.D10066);
        }
        async void AutoUpdateDigital()
        {
            //digital
            CheckColorBangTaiThang(await plcDigital.GetADigital(digitalCommon.M10065), await plcDigital.GetADigital(digitalCommon.M10066), await plcDigital.GetADigital(digitalCommon.M10067), await plcDigital.GetADigital(digitalCommon.M10064));
            CheckColorBangTaiXien(await plcDigital.GetADigital(digitalCommon.M10069), await plcDigital.GetADigital(digitalCommon.M10070), await plcDigital.GetADigital(digitalCommon.M10071), await plcDigital.GetADigital(digitalCommon.M10068));

            CheckColorBomThoat1(await plcDigital.GetADigital(digitalCommon.M10077));
            CheckColorBomThoat2(await plcDigital.GetADigital(digitalCommon.M10079));

            CheckColorTrangThaiBom2(await plcDigital.GetADigital(digitalCommon.M10144), await plcDigital.GetADigital(digitalCommon.M10145), await plcDigital.GetADigital(digitalCommon.M10167));
            CheckColorTrangThaiBom3(await plcDigital.GetADigital(digitalCommon.M10193), await plcDigital.GetADigital(digitalCommon.M10194), await plcDigital.GetADigital(digitalCommon.M10216));
            CheckColorTrangThaiBom4(await plcDigital.GetADigital(digitalCommon.M10242), await plcDigital.GetADigital(digitalCommon.M10243), await plcDigital.GetADigital(digitalCommon.M10265));
            CheckColorBomMoi1(await plcDigital.GetADigital(digitalCommon.M10059));
            CheckColorBomMoi2(await plcDigital.GetADigital(digitalCommon.M10061));
            CheckTinHieuMayBom(await plcDigital.GetADigital(digitalCommon.M10097), await plcDigital.GetADigital(digitalCommon.M10146), await plcDigital.GetADigital(digitalCommon.M10195), await plcDigital.GetADigital(digitalCommon.M10244));


            CheckColorPheuSo1(await plcDigital.GetADigital(digitalCommon.M10042), await plcDigital.GetADigital(digitalCommon.M10041), await plcDigital.GetADigital(digitalCommon.M10039), await plcDigital.GetADigital(digitalCommon.M10040), await plcDigital.GetADigital(digitalCommon.M10038));
            CheckColorPheuSo2(await plcDigital.GetADigital(digitalCommon.M10051), await plcDigital.GetADigital(digitalCommon.M10050), await plcDigital.GetADigital(digitalCommon.M10048), await plcDigital.GetADigital(digitalCommon.M10049), await plcDigital.GetADigital(digitalCommon.M10047));
            CheckColorVan1(await plcDigital.GetADigital(digitalCommon.M10125), await plcDigital.GetADigital(digitalCommon.M10124), await plcDigital.GetADigital(digitalCommon.M10122), await plcDigital.GetADigital(digitalCommon.M10123));
            CheckColorVan2(await plcDigital.GetADigital(digitalCommon.M10174), await plcDigital.GetADigital(digitalCommon.M10173), await plcDigital.GetADigital(digitalCommon.M10171), await plcDigital.GetADigital(digitalCommon.M10172));
            CheckColorVan3(await plcDigital.GetADigital(digitalCommon.M10223), await plcDigital.GetADigital(digitalCommon.M10222), await plcDigital.GetADigital(digitalCommon.M10220), await plcDigital.GetADigital(digitalCommon.M10221));
            CheckColorVan4(await plcDigital.GetADigital(digitalCommon.M10272), await plcDigital.GetADigital(digitalCommon.M10271), await plcDigital.GetADigital(digitalCommon.M10269), await plcDigital.GetADigital(digitalCommon.M10270));
            CheckColorTrangThaiBom1(await plcDigital.GetADigital(digitalCommon.M10095), await plcDigital.GetADigital(digitalCommon.M10096), await plcDigital.GetADigital(digitalCommon.M10118));


            CheckColorCaoRac1(await plcDigital.GetADigital(digitalCommon.M10137), await plcDigital.GetADigital(digitalCommon.M10138), await plcDigital.GetADigital(digitalCommon.M10139));

            CheckColorCaoRac2(await plcDigital.GetADigital(digitalCommon.M10186), await plcDigital.GetADigital(digitalCommon.M10187), await plcDigital.GetADigital(digitalCommon.M10188));
            CheckColorCaoRac3(await plcDigital.GetADigital(digitalCommon.M10235), await plcDigital.GetADigital(digitalCommon.M10236), await plcDigital.GetADigital(digitalCommon.M10237));
            CheckColorCaoRac4(await plcDigital.GetADigital(digitalCommon.M10284), await plcDigital.GetADigital(digitalCommon.M10285), await plcDigital.GetADigital(digitalCommon.M10286));
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                AutoUpdateAnalog();
            }).Start();

            AutoUpdateDigital();
        }
        private async void ToanCanhTramBom_Load(object sender, EventArgs e)
        {
            timer1.Start();
            await plcAnalog.Open();
            await plcDigital.Open();
        }

        private async void ToanCanhTramBom_FormClosing(object sender, FormClosingEventArgs e)
        {
            await plcAnalog.Close();
            await plcDigital.Close();
            CloseForm();
        }













        //tin hieu may bom

        //Check
        void CheckTinHieuMayBom(Digital? M10097, Digital? M10146, Digital? M10195, Digital? M10244)
        {
            LoadTinHieuMayBom1(M10097);
            LoadTinHieuMayBom2(M10146);
            LoadTinHieuMayBom3(M10195);
            LoadTinHieuMayBom4(M10244);


        }

        void LoadTinHieuMayBom1(Digital? M10097)
        {
            if (M10097 != null)
            {
                if (M10097.TrangThai)
                {
                    TinHieuMayBom1.Image = Resources.BomChinh1Do;
                }
                else
                {
                    TinHieuMayBom1.Image = Resources.BomChinh1Xanh;
                }
            }
            else
            {
                TinHieuMayBom1.Image = Resources.BomChinh1Xanh;
            }
        }
        void LoadTinHieuMayBom2(Digital? M10146)
        {
            if (M10146 != null)
            {
                if (M10146.TrangThai)
                {
                    TinHieuMayBom2.Image = Resources.BomChinh2Do;
                }
                else
                {
                    TinHieuMayBom2.Image = Resources.BomChinh2Xanh;
                }
            }
            else
            {
                TinHieuMayBom2.Image = Resources.BomChinh2Xanh;
            }
        }
        void LoadTinHieuMayBom3(Digital? M10195)
        {
            if (M10195 != null)
            {
                if (M10195.TrangThai)
                {
                    TinHieuMayBom3.Image = Resources.BomChinh3Do;
                }
                else
                {
                    TinHieuMayBom3.Image = Resources.BomChinh3Xanh;
                }
            }
            else
            {
                TinHieuMayBom3.Image = Resources.BomChinh3Xanh;
            }
        }
        void LoadTinHieuMayBom4(Digital? M10244)
        {
            if (M10244 != null)
            {
                if (M10244.TrangThai)
                {
                    TinHieuMayBom4.Image = Resources.BomChinh4Do;
                }
                else
                {
                    TinHieuMayBom4.Image = Resources.BomChinh4Xanh;
                }
            }
            else
            {
                TinHieuMayBom4.Image = Resources.BomChinh4Xanh;
            }
        }
















        //
        //Check trạng thái bơm
        void LabelTrangThaiBom(Label lb1, Label lb2, Digital? digital)
        {
            if (digital != null)
            {
                if (digital.TrangThai)
                {
                    lb1.BackColor = Color.Red;
                    lb2.BackColor = Color.Silver;
                }
                else
                {
                    lb1.BackColor = Color.Silver;
                    lb2.BackColor = Color.Red;
                }
            }
            else
            {
                lb1.BackColor = Color.Silver;
                lb2.BackColor = Color.Silver;
            }
        }
        void CheckColorTrangThaiBom1(Digital? M10095, Digital? M10096, Digital? M10118)
        {
            LabelTrangThaiBom(TuXa1, TaiCho1, M10095);
            LabelTrangThaiBom(PDKTT1, PDien1, M10096);
            if (M10118 != null && M10118.TrangThai == true)
            {
                SanSang1.BackColor = Color.Red;
            }
            else
            {
                SanSang1.BackColor = Color.Silver;
            }

        }
        void CheckColorTrangThaiBom2(Digital? M10144, Digital? M10145, Digital? M10167)
        {
            LabelTrangThaiBom(TuXa2, TaiCho2, M10144);
            LabelTrangThaiBom(PDKTT2, PDien2, M10145);
            if (M10167 != null && M10167.TrangThai == true)
            {
                SanSang2.BackColor = Color.Red;
            }
            else
            {
                SanSang2.BackColor = Color.Silver;
            }

        }
        void CheckColorTrangThaiBom3(Digital? M10193, Digital? M10194, Digital? M10216)
        {
            LabelTrangThaiBom(TuXa3, TaiCho3, M10193);
            LabelTrangThaiBom(PDKTT3, PDien3, M10194);
            if (M10216 != null && M10216.TrangThai == true)
            {
                SanSang3.BackColor = Color.Red;
            }
            else
            {
                SanSang3.BackColor = Color.Silver;
            }

        }
        void CheckColorTrangThaiBom4(Digital? M10242, Digital? M10243, Digital? M10265)
        {
            LabelTrangThaiBom(TuXa4, TaiCho4, M10242);
            LabelTrangThaiBom(PDKTT4, PDien4, M10243);
            if (M10265 != null && M10265.TrangThai == true)
            {
                SanSang4.BackColor = Color.Red;
            }
            else
            {
                SanSang4.BackColor = Color.Silver;
            }

        }


        void CheckColorBomMoi1(Digital? M10059)
        {
            if (M10059 != null)
            {
                //xanh
                if (M10059.TrangThai == false)
                {
                    BomMoi1.Image = Resources.BomMoiXanh;
                }
                //đỏ
                else
                {
                    BomMoi1.Image = Resources.BomMoi1Do;
                }
            }
            else
            {
                BomMoi1.Image = Resources.BomMoiXanh;
            }

        }
        void CheckColorBomMoi2(Digital? M10061)
        {
            if (M10061 != null)
            {
                //xanh
                if (M10061.TrangThai == false)
                {
                    BomMoi2.Image = Resources.BomMoi2Xanh;
                }
                //đỏ
                else
                {
                    BomMoi2.Image = Resources.BomMoi2Do;
                }
            }
            else
            {
                BomMoi2.Image = Resources.BomMoi2Xanh;
            }

        }









        //Bơm thoát
        void CheckColorBomThoat1(Digital? M10077)
        {
            if (M10077 != null)
            {
                //xanh
                if (M10077.TrangThai)
                {
                    BomThoat1.Image = Resources.BomThoat1Xanh;
                }
                //đỏ
                else
                {
                    BomThoat1.Image = Resources.BomThoat1Do;
                }
            }
            else
            {
                BomThoat1.Image = Resources.BomThoat1Xanh;
            }

        }
        void CheckColorBomThoat2(Digital? M10079)
        {
            if (M10079 != null)
            {
                //xanh
                if (M10079.TrangThai)
                {
                    BomThoat2.Image = Resources.BomThoat2Xanh;
                }
                //đỏ
                else
                {
                    BomThoat2.Image = Resources.BomThoat2Do;
                }
            }
            else
            {
                BomThoat2.Image = Resources.BomThoat2Xanh;
            }

        }


















        //NHẤP NHÁY



        //timer digital nhấp nháy
        System.Timers.Timer TimerCheckColorPheuSo1M10039; // đỏ tím
        System.Timers.Timer TimerCheckColorPheuSo1M10040; // xanh tím
        System.Timers.Timer TimerCheckColorPheuSo1M10038; // vàng tím
        System.Timers.Timer TimerCheckColorPheuSo1M10038va40; // vàng đỏ
        System.Timers.Timer TimerCheckColorPheuSo1M10038va39; // vàng xanh
        bool nhapNhayPheuSo1;

        System.Timers.Timer TimerCheckColorPheuSo2M10048; // đỏ tím
        System.Timers.Timer TimerCheckColorPheuSo2M10049; //xanh tím
        System.Timers.Timer TimerCheckColorPheuSo2M10047; // vàng tím
        System.Timers.Timer TimerCheckColorPheuSo2M10047va10048; //vàng đỏ
        System.Timers.Timer TimerCheckColorPheuSo2M10047va10049; //vàng xanh
        bool nhapNhayPheuSo2;

        System.Timers.Timer TimerCheckColorCaoRacSo1VangXanh; // vàng xanh
        System.Timers.Timer TimerCheckColorCaoRacSo1VangDo; //vàng đỏ
        bool nhapNhayCaoRacSo1;

        System.Timers.Timer TimerCheckColorCaoRacSo2VangXanh; // vàng xanh
        System.Timers.Timer TimerCheckColorCaoRacSo2VangDo; //vàng đỏ
        bool nhapNhayCaoRacSo2;

        System.Timers.Timer TimerCheckColorCaoRacSo3VangXanh; // vàng xanh
        System.Timers.Timer TimerCheckColorCaoRacSo3VangDo; //vàng đỏ
        bool nhapNhayCaoRacSo3;

        System.Timers.Timer TimerCheckColorCaoRacSo4VangXanh; // vàng xanh
        System.Timers.Timer TimerCheckColorCaoRacSo4VangDo; //vàng đỏ
        bool nhapNhayCaoRacSo4;


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


        System.Timers.Timer TimerBTDocDo; //đỏ xanh
        System.Timers.Timer TimerBTDocVang; //vàng xanh
        bool nhapNhayBTDoc;


        System.Timers.Timer TimerBTXienDo; //đỏ xanh
        System.Timers.Timer TimerBTXienVang; //vàng xanh
        bool nhapNhayBTXien;



        public void CloseForm()
        {
            CLearTimer(TimerCheckColorPheuSo1M10039);
            CLearTimer(TimerCheckColorPheuSo1M10040);
            CLearTimer(TimerCheckColorPheuSo1M10038);
            CLearTimer(TimerCheckColorPheuSo1M10038va39);
            CLearTimer(TimerCheckColorPheuSo1M10038va40);


            CLearTimer(TimerCheckColorPheuSo2M10048);
            CLearTimer(TimerCheckColorPheuSo2M10049);
            CLearTimer(TimerCheckColorPheuSo2M10047);
            CLearTimer(TimerCheckColorPheuSo2M10047va10048);
            CLearTimer(TimerCheckColorPheuSo2M10047va10049);


            CLearTimer(TimerCheckColorCaoRacSo1VangXanh);
            CLearTimer(TimerCheckColorCaoRacSo1VangDo);

            CLearTimer(TimerCheckColorCaoRacSo2VangXanh);
            CLearTimer(TimerCheckColorCaoRacSo2VangDo);

            CLearTimer(TimerCheckColorCaoRacSo3VangXanh);
            CLearTimer(TimerCheckColorCaoRacSo3VangDo);

            CLearTimer(TimerCheckColorCaoRacSo4VangXanh);
            CLearTimer(TimerCheckColorCaoRacSo4VangDo);

            CLearTimer(TimerTinHieuVan1M10122);
            CLearTimer(TimerTinHieuVan1M10123);

            CLearTimer(TimerTinHieuVan2M10171);
            CLearTimer(TimerTinHieuVan2M10172);

            CLearTimer(TimerTinHieuVan3M10220);
            CLearTimer(TimerTinHieuVan3M10221);

            CLearTimer(TimerTinHieuVan4M10270);
            CLearTimer(TimerTinHieuVan4M10271);

            CLearTimer(TimerBTDocDo);
            CLearTimer(TimerBTDocVang);

            CLearTimer(TimerBTXienDo);
            CLearTimer(TimerBTXienVang);

            timer1.Stop();
            timer1.Dispose();

        }


        int intervalNhapNhay = 800; //ms

        void CLearTimer(System.Timers.Timer timer)
        {
            if (timer != null && timer.Enabled == true)
            {
                timer.Stop();
                timer.Dispose();
            }
        }










        //đỏ - xanh
        private void Timer_Tick_CheckColorBTDocDo(object sender, EventArgs e)
        {
            if (nhapNhayBTDoc)
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangDo;
                nhapNhayBTDoc = false;
            }
            else
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangXanh;
                nhapNhayBTDoc = true;
            }
        }


        //vàng - xanh
        private void Timer_Tick_CheckColorBTDocVang(object sender, EventArgs e)
        {
            if (nhapNhayBTDoc)
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangVang;
            }
            else
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangXanh;
                nhapNhayBTDoc = true;
            }
        }




        //băng tải thẳng
        void CheckColorBangTaiThang(Digital? M10065, Digital? M10066, Digital? M10067, Digital? M10064)
        {
            // nhap nhay vang bang tai thang
            if ((M10064 != null && M10064.TrangThai) && (M10067 != null && M10067.TrangThai))
            {
                CLearTimer(TimerBTDocDo);
                if (TimerBTDocVang == null || TimerBTDocVang.Enabled == false)
                {
                    pictureBoxBangTaiThang.Image = Resources.BangTaiThangVang;
                    TimerBTDocVang = new System.Timers.Timer();
                    TimerBTDocVang.Interval = intervalNhapNhay;
                    TimerBTDocVang.Elapsed += Timer_Tick_CheckColorBTDocVang;
                    TimerBTDocVang.Start();
                }
            }
            // nhap nhay do
            else if ((M10066 != null && M10066.TrangThai) && (M10065 != null && M10065.TrangThai))
            {
                CLearTimer(TimerBTDocVang);
                if (TimerBTDocDo == null || TimerBTDocDo.Enabled == false)
                {
                    pictureBoxBangTaiThang.Image = Resources.BangTaiThangDo;
                    TimerBTDocDo = new System.Timers.Timer();
                    TimerBTDocDo.Interval = intervalNhapNhay;
                    TimerBTDocDo.Elapsed += Timer_Tick_CheckColorBTDocDo;
                    TimerBTDocDo.Start();
                }
            }
            else
            {
                CLearTimer(TimerBTDocVang);
                CLearTimer(TimerBTDocDo);
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangXanh;
            }

        }

















        //băng tải xiên

        //đỏ - xanh
        private void Timer_Tick_CheckColorBTXienDo(object sender, EventArgs e)
        {
            if (nhapNhayBTXien)
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienDo;
                nhapNhayBTXien = false;
            }
            else
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienXanh;
                nhapNhayBTXien = true;
            }
        }


        //vàng - xanh
        private void Timer_Tick_CheckColorBTXienVang(object sender, EventArgs e)
        {
            if (nhapNhayBTXien)
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienVang;
                nhapNhayBTXien = false;
            }
            else
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienXanh;
                nhapNhayBTXien = true;
            }
        }
        void CheckColorBangTaiXien(Digital? M10069, Digital? M10070, Digital? M10071, Digital? M10068)
        {

            //nhap nhay vang xanh
            if ((M10071 != null && M10071.TrangThai) && (M10068 != null && M10068.TrangThai))
            {
                CLearTimer(TimerBTXienDo);
                if (TimerBTXienVang == null || TimerBTXienVang.Enabled == false)
                {
                    pictureBoxBangTaiXien.Image = Resources.BangTaiXienVang;
                    TimerBTXienVang = new System.Timers.Timer();
                    TimerBTXienVang.Interval = intervalNhapNhay;
                    TimerBTXienVang.Elapsed += Timer_Tick_CheckColorBTXienVang;
                    TimerBTXienVang.Start();
                }
            }
            //chi mau đỏ
            else if ((M10069 != null && M10069.TrangThai) && (M10070 != null && M10070.TrangThai))
            {
                CLearTimer(TimerBTXienVang);
                if (TimerBTXienVang == null || TimerBTXienVang.Enabled == false)
                {
                    pictureBoxBangTaiXien.Image = Resources.BangTaiXienDo;
                    TimerBTXienDo = new System.Timers.Timer();
                    TimerBTXienDo.Interval = intervalNhapNhay;
                    TimerBTXienDo.Elapsed += Timer_Tick_CheckColorBTXienDo;
                    TimerBTXienDo.Start();
                }
            }
            else //mau xanh
            {
                CLearTimer(TimerBTXienVang);
                CLearTimer(TimerBTXienDo);
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienXanh;

            }

        }









        //phễu
        // PHỄU SÔ 1

        //đỏ - tím - 10039
        private void Timer_Tick_CheckColorPheuSo1M10039(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenDo;
                nhapNhayPheuSo1 = false;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
                nhapNhayPheuSo1 = true;
            }
        }
        //xanh tím 10040
        private void Timer_Tick_CheckColorPheuSo1M10040(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenXanh;
                nhapNhayPheuSo1 = false;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
                nhapNhayPheuSo1 = true;
            }
        }
        //vàng tím 10038
        private void Timer_Tick_CheckColorPheuSo1M10038(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenVang;
                nhapNhayPheuSo1 = false;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
                nhapNhayPheuSo1 = true;
            }
        }
        //vàng đỏ 10038 - 10040
        private void Timer_Tick_CheckColorPheuSo1M10038va10040(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenVang;
                nhapNhayPheuSo1 = false;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenDo;
                nhapNhayPheuSo1 = true;
            }
        }
        //vàng xanh 10038 - 10039
        private void Timer_Tick_CheckColorPheuSo1M10038va10039(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenVang;
                nhapNhayPheuSo1 = false;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenXanh;
                nhapNhayPheuSo1 = true;
            }
        }
        void CheckColorPheuSo1(Digital? M10042, Digital? M10041, Digital? M10039, Digital? M10040, Digital? M10038)
        {
            //xanh
            if (M10042 != null && M10042.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10038va39);
                CLearTimer(TimerCheckColorPheuSo1M10038va40);
                pictureBoxPheu1.Image = Resources.PheuTrenXanh;
            }
            //đỏ
            else if (M10041 != null && M10041.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10038va39);
                CLearTimer(TimerCheckColorPheuSo1M10038va40);
                pictureBoxPheu1.Image = Resources.PheuTrenDo;
            }
            //đen
            else if (((M10041!=null && M10041.TrangThai==true) && (M10040 != null && M10040.TrangThai == true))
                || ((M10041 != null && M10041.TrangThai == true) && (M10039 != null && M10039.TrangThai == true))
                || ((M10042 != null && M10042.TrangThai == true) && (M10039 != null && M10039.TrangThai == true))
                || ((M10042 != null && M10042.TrangThai == true) && (M10040 != null && M10040.TrangThai == true)))
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10038va39);
                CLearTimer(TimerCheckColorPheuSo1M10038va40);
                pictureBoxPheu1.Image = Resources.PheuTrenDen;
            }
            //đỏ tím
            else if (M10039 != null && M10039.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10040);

                if (TimerCheckColorPheuSo1M10039 == null || TimerCheckColorPheuSo1M10039.Enabled == false)
                {
                    pictureBoxPheu1.Image = Resources.PheuTrenTim;
                    TimerCheckColorPheuSo1M10039 = new System.Timers.Timer();
                    TimerCheckColorPheuSo1M10039.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo1M10039.Elapsed += Timer_Tick_CheckColorPheuSo1M10039;
                    TimerCheckColorPheuSo1M10039.Start();
                }
            }
            //xanh tím
            else if (M10040 != null && M10040.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10038va39);
                CLearTimer(TimerCheckColorPheuSo1M10038va40);
                if (TimerCheckColorPheuSo1M10040 == null || TimerCheckColorPheuSo1M10040.Enabled == false)
                {
                    pictureBoxPheu1.Image = Resources.Pheu1Tim;
                    TimerCheckColorPheuSo1M10040 = new System.Timers.Timer();
                    TimerCheckColorPheuSo1M10040.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo1M10040.Elapsed += Timer_Tick_CheckColorPheuSo1M10040;
                    TimerCheckColorPheuSo1M10040.Start();
                }
            }
            //vàng tím
            else if (M10038 != null && M10038.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10038va39);
                CLearTimer(TimerCheckColorPheuSo1M10038va40);
                if (TimerCheckColorPheuSo1M10038 == null || TimerCheckColorPheuSo1M10038.Enabled == false)
                {
                    pictureBoxPheu1.Image = Resources.Pheu1Tim;
                    TimerCheckColorPheuSo1M10038 = new System.Timers.Timer();
                    TimerCheckColorPheuSo1M10038.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo1M10038.Elapsed += Timer_Tick_CheckColorPheuSo1M10038;
                    TimerCheckColorPheuSo1M10038.Start();
                }
            }
            //vàng đỏ
            else if ((M10038 != null && M10038.TrangThai == true)&& (M10040 != null && M10040.TrangThai == true))
            {
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10038va39);
                if (TimerCheckColorPheuSo1M10038va40 == null || TimerCheckColorPheuSo1M10038va40.Enabled == false)
                {
                    pictureBoxPheu1.Image = Resources.Pheu1Tim;
                    TimerCheckColorPheuSo1M10038va40 = new System.Timers.Timer();
                    TimerCheckColorPheuSo1M10038va40.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo1M10038va40.Elapsed += Timer_Tick_CheckColorPheuSo1M10038va10040;
                    TimerCheckColorPheuSo1M10038va40.Start();
                }
            }
            //vàng xanh
            else if ((M10038 != null && M10038.TrangThai == true) && (M10039 != null && M10039.TrangThai == true))
            {
                CLearTimer(TimerCheckColorPheuSo1M10038va40);
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10039);
                if (TimerCheckColorPheuSo1M10038va39 == null || TimerCheckColorPheuSo1M10038va39.Enabled == false)
                {
                    pictureBoxPheu1.Image = Resources.Pheu1Tim;
                    TimerCheckColorPheuSo1M10038va39 = new System.Timers.Timer();
                    TimerCheckColorPheuSo1M10038va39.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo1M10038va39.Elapsed += Timer_Tick_CheckColorPheuSo1M10038va10039;
                    TimerCheckColorPheuSo1M10038va39.Start();
                }
            }
            // tím
            else
            {
                CLearTimer(TimerCheckColorPheuSo1M10039);
                CLearTimer(TimerCheckColorPheuSo1M10040);
                CLearTimer(TimerCheckColorPheuSo1M10038);
                CLearTimer(TimerCheckColorPheuSo1M10038va39);
                CLearTimer(TimerCheckColorPheuSo1M10038va40);
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
            }
        }














        //Phễu số 2


        //đỏ - tím
        private void Timer_Tick_CheckColorPheuSo2M10048(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
                nhapNhayPheuSo2 = false;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiDo;
                nhapNhayPheuSo2 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorPheuSo2M10049(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
                nhapNhayPheuSo2 = false;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiXanh;
                nhapNhayPheuSo2 = true;
            }
        }
        //vàng tím
        private void Timer_Tick_CheckColorPheuSo2M10047(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
                nhapNhayPheuSo2 = false;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiVang;
                nhapNhayPheuSo2 = true;
            }
        }
        //vàng đỏ
        private void Timer_Tick_CheckColorPheuSo2M10047va10048(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiDo;
                nhapNhayPheuSo2 = false;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiVang;
                nhapNhayPheuSo2 = true;
            }
        }
        //vàng xanh
        private void Timer_Tick_CheckColorPheuSo2M10047va10049(object sender, EventArgs e)
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiXanh;
                nhapNhayPheuSo2 = false;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiVang;
                nhapNhayPheuSo2 = true;
            }
        }

        void CheckColorPheuSo2(Digital? M10051, Digital? M10050, Digital? M10048, Digital? M10049, Digital? M10047)
        {
            //xanh
            if (M10051 != null && M10051.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049);
                pictureBoxPheu2.Image = Resources.PheuDuoiXanh;
            }
            //đỏ
            else if (M10050 != null && M10050.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049);
                pictureBoxPheu2.Image = Resources.PheuDuoiDo;
            }
            //đen
            else if (((M10050 != null && M10050.TrangThai == true) && (M10049 != null && M10049.TrangThai == true))
                || ((M10050 != null && M10050.TrangThai == true) && (M10048 != null && M10048.TrangThai == true))
                || ((M10051 != null && M10051.TrangThai == true) && (M10049 != null && M10049.TrangThai == true))
                || ((M10051 != null && M10051.TrangThai == true) && (M10048 != null && M10048.TrangThai == true)))
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049);
                pictureBoxPheu2.Image = Resources.PheuDuoiDen;
            }
            //đỏ tím
            else if (M10048 != null && M10048.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049);
                if (TimerCheckColorPheuSo2M10048 == null || TimerCheckColorPheuSo2M10048.Enabled == false)
                {
                    pictureBoxPheu2.Image = Resources.PheuDuoiTim;
                    TimerCheckColorPheuSo2M10048 = new System.Timers.Timer();
                    TimerCheckColorPheuSo2M10048.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo2M10048.Elapsed += Timer_Tick_CheckColorPheuSo2M10048;
                    TimerCheckColorPheuSo2M10048.Start();
                }
            }
            //xanh tím
            else if (M10049 != null && M10049.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049);
                if (TimerCheckColorPheuSo2M10049 == null || TimerCheckColorPheuSo2M10049.Enabled == false)
                {
                    pictureBoxPheu2.Image = Resources.PheuDuoiTim;
                    TimerCheckColorPheuSo2M10049 = new System.Timers.Timer();
                    TimerCheckColorPheuSo2M10049.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo2M10049.Elapsed += Timer_Tick_CheckColorPheuSo2M10049;
                    TimerCheckColorPheuSo2M10049.Start();
                }
            }
            //vàng tím
            else if (M10047 != null && M10047.TrangThai == true)
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049);
                if (TimerCheckColorPheuSo2M10047 == null || TimerCheckColorPheuSo2M10047.Enabled == false)
                {
                    pictureBoxPheu2.Image = Resources.PheuDuoiTim;
                    TimerCheckColorPheuSo2M10047 = new System.Timers.Timer();
                    TimerCheckColorPheuSo2M10047.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo2M10047.Elapsed += Timer_Tick_CheckColorPheuSo2M10047;
                    TimerCheckColorPheuSo2M10047.Start();
                }
            }
            //vàng đỏ
            else if ((M10047 != null && M10047.TrangThai == true) && (M10048 != null && M10048.TrangThai == true))
            {
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049);
                if (TimerCheckColorPheuSo2M10047va10048 == null || TimerCheckColorPheuSo2M10047va10048.Enabled == false)
                {
                    pictureBoxPheu2.Image = Resources.PheuDuoiDo;
                    TimerCheckColorPheuSo2M10047va10048 = new System.Timers.Timer();
                    TimerCheckColorPheuSo2M10047va10048.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo2M10047va10048.Elapsed += Timer_Tick_CheckColorPheuSo2M10047va10048;
                    TimerCheckColorPheuSo2M10047va10048.Start();
                }
            }
            //vàng xanh
            else if ((M10047 != null && M10047.TrangThai == true) && (M10049 != null && M10049.TrangThai == true))
            {
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                if (TimerCheckColorPheuSo2M10047va10049 == null || TimerCheckColorPheuSo2M10047va10049.Enabled == false)
                {
                    pictureBoxPheu2.Image = Resources.PheuDuoiDo;
                    TimerCheckColorPheuSo2M10047va10049 = new System.Timers.Timer();
                    TimerCheckColorPheuSo2M10047va10049.Interval = intervalNhapNhay;
                    TimerCheckColorPheuSo2M10047va10049.Elapsed += Timer_Tick_CheckColorPheuSo2M10047va10049;
                    TimerCheckColorPheuSo2M10047va10049.Start();
                }
            }
            //tím
            else
            {
                CLearTimer(TimerCheckColorPheuSo2M10048);
                CLearTimer(TimerCheckColorPheuSo2M10049);
                CLearTimer(TimerCheckColorPheuSo2M10047);
                CLearTimer(TimerCheckColorPheuSo2M10047va10048);
                CLearTimer(TimerCheckColorPheuSo2M10047va10049); ;
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
            }
        }














        //Cào Rác
        //1
        //vàng xanh
        private void Timer_Tick_CheckColorCaoRac1VangXanh(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo1)
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Vang;
                nhapNhayCaoRacSo1 = false;
            }
            else
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Xanh;
                nhapNhayCaoRacSo1 = true;
            }
        }
        //vàng đỏ
        private void Timer_Tick_CheckColorCaoRac1VangDo(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo1)
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Vang;
                nhapNhayCaoRacSo1 = false;
            }
            else
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Do;
                nhapNhayCaoRacSo1 = true;
            }
        }
        void CheckColorCaoRac1(Digital? M10137, Digital? M10138, Digital? M10139)
        {
            //đỏ
            if ((M10137 != null && M10137.TrangThai == true) || (M10138 != null && M10138.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo1VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo1VangDo);
                pictureBoxCaoRac1.Image = Resources.CaoRac1Do;
            }
            //vàng xanh
            else if (M10139 != null && M10139.TrangThai == true)
            {
                CLearTimer(TimerCheckColorCaoRacSo1VangDo);
                if (TimerCheckColorCaoRacSo1VangXanh == null || TimerCheckColorCaoRacSo1VangXanh.Enabled == false)
                {
                    pictureBoxCaoRac1.Image = Resources.CaoRac1Vang;
                    TimerCheckColorCaoRacSo1VangXanh = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo1VangXanh.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo1VangXanh.Elapsed += Timer_Tick_CheckColorCaoRac1VangXanh;
                    TimerCheckColorCaoRacSo1VangXanh.Start();
                }
            }
            //vàng đỏ
            else if ((M10137 != null && M10137.TrangThai == true) && (M10139 != null && M10139.TrangThai == true)
                || (M10138 != null && M10138.TrangThai == true) && (M10139 != null && M10139.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo1VangXanh);
                if (TimerCheckColorCaoRacSo1VangDo == null || TimerCheckColorCaoRacSo1VangDo.Enabled == false)
                {
                    pictureBoxCaoRac1.Image = Resources.CaoRac1Vang;
                    TimerCheckColorCaoRacSo1VangDo = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo1VangDo.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo1VangDo.Elapsed += Timer_Tick_CheckColorCaoRac1VangDo;
                    TimerCheckColorCaoRacSo1VangDo.Start();
                }
            }
            else
            {
                CLearTimer(TimerCheckColorCaoRacSo1VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo1VangXanh);
                pictureBoxCaoRac1.Image = Resources.CaoRac1Xanh;

            }
        }






        //2
        //vàng xanh
        private void Timer_Tick_CheckColorCaoRac2VangXanh(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo2)
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Vang;
                nhapNhayCaoRacSo2 = false;
            }
            else
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Xanh;
                nhapNhayCaoRacSo2 = true;
            }
        }
        //vàng đỏ
        private void Timer_Tick_CheckColorCaoRac2VangDo(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo2)
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Vang;
                nhapNhayCaoRacSo2 = false;
            }
            else
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Do;
                nhapNhayCaoRacSo2 = true;
            }
        }
        void CheckColorCaoRac2(Digital? M10186, Digital? M10187, Digital? M10188)
        {
            //đỏ
            if ((M10186 != null && M10186.TrangThai == true) || (M10187 != null && M10187.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo2VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo2VangDo);
                pictureBoxCaoRac2.Image = Resources.CaoRac2Do;
            }
            //vàng xanh
            else if (M10188 != null && M10188.TrangThai == true)
            {
                CLearTimer(TimerCheckColorCaoRacSo2VangDo);
                if (TimerCheckColorCaoRacSo2VangXanh == null || TimerCheckColorCaoRacSo2VangXanh.Enabled == false)
                {
                    pictureBoxCaoRac2.Image = Resources.CaoRac2Vang;
                    TimerCheckColorCaoRacSo2VangXanh = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo2VangXanh.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo2VangXanh.Elapsed += Timer_Tick_CheckColorCaoRac2VangXanh;
                    TimerCheckColorCaoRacSo2VangXanh.Start();
                }
            }
            //vàng đỏ
            else if ((M10186 != null && M10186.TrangThai == true) && (M10188 != null && M10188.TrangThai == true)
                || (M10187 != null && M10187.TrangThai == true) && (M10188 != null && M10188.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo2VangXanh);
                if (TimerCheckColorCaoRacSo2VangDo == null || TimerCheckColorCaoRacSo2VangDo.Enabled == false)
                {
                    pictureBoxCaoRac2.Image = Resources.CaoRac2Vang;
                    TimerCheckColorCaoRacSo2VangDo = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo2VangDo.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo2VangDo.Elapsed += Timer_Tick_CheckColorCaoRac2VangDo;
                    TimerCheckColorCaoRacSo2VangDo.Start();
                }
            }
            else
            {
                CLearTimer(TimerCheckColorCaoRacSo2VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo2VangXanh);
                pictureBoxCaoRac2.Image = Resources.CaoRac2Xanh;

            }
        }







        //3
        //vàng xanh
        private void Timer_Tick_CheckColorCaoRac3VangXanh(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo3)
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Vang;
                nhapNhayCaoRacSo3 = false;
            }
            else
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Xanh;
                nhapNhayCaoRacSo3 = true;
            }
        }
        //vàng đỏ
        private void Timer_Tick_CheckColorCaoRac3VangDo(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo3)
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Vang;
                nhapNhayCaoRacSo3 = false;
            }
            else
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Do;
                nhapNhayCaoRacSo3 = true;
            }
        }
        void CheckColorCaoRac3(Digital? M10235, Digital? M10236, Digital? M10237)
        {
            //đỏ
            if ((M10235 != null && M10235.TrangThai == true) || (M10236 != null && M10236.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo3VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo3VangDo);
                pictureBoxCaoRac3.Image = Resources.CaoRac3Do;
            }
            //vàng xanh
            else if (M10237 != null && M10237.TrangThai == true)
            {
                CLearTimer(TimerCheckColorCaoRacSo3VangDo);
                if (TimerCheckColorCaoRacSo3VangXanh == null || TimerCheckColorCaoRacSo3VangXanh.Enabled == false)
                {
                    pictureBoxCaoRac3.Image = Resources.CaoRac3Vang;
                    TimerCheckColorCaoRacSo3VangXanh = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo3VangXanh.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo3VangXanh.Elapsed += Timer_Tick_CheckColorCaoRac3VangXanh;
                    TimerCheckColorCaoRacSo3VangXanh.Start();
                }
            }
            //vàng đỏ
            else if ((M10235 != null && M10235.TrangThai == true) && (M10237 != null && M10237.TrangThai == true)
                || (M10236 != null && M10236.TrangThai == true) && (M10237 != null && M10237.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo3VangXanh);
                if (TimerCheckColorCaoRacSo3VangDo == null || TimerCheckColorCaoRacSo3VangDo.Enabled == false)
                {
                    pictureBoxCaoRac3.Image = Resources.CaoRac3Vang;
                    TimerCheckColorCaoRacSo3VangDo = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo3VangDo.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo3VangDo.Elapsed += Timer_Tick_CheckColorCaoRac3VangDo;
                    TimerCheckColorCaoRacSo3VangDo.Start();
                }
            }
            else
            {
                CLearTimer(TimerCheckColorCaoRacSo3VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo3VangXanh);
                pictureBoxCaoRac3.Image = Resources.CaoRac3Xanh;

            }
        }










        //4
        //vàng xanh
        private void Timer_Tick_CheckColorCaoRac4VangXanh(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo4)
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Vang;
                nhapNhayCaoRacSo4 = false;
            }
            else
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Xanh;
                nhapNhayCaoRacSo4 = true;
            }
        }
        //vàng đỏ
        private void Timer_Tick_CheckColorCaoRac4VangDo(object sender, EventArgs e)
        {
            if (nhapNhayCaoRacSo4)
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Vang;
                nhapNhayCaoRacSo4 = false;
            }
            else
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Do;
                nhapNhayCaoRacSo4 = true;
            }
        }
        void CheckColorCaoRac4(Digital? M10284, Digital? M10285, Digital? M10286)
        {
            //đỏ
            if ((M10284 != null && M10284.TrangThai == true) || (M10285 != null && M10285.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo4VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo4VangDo);
                pictureBoxCaoRac4.Image = Resources.CaoRac4Do;
            }
            //vàng xanh
            else if (M10286 != null && M10286.TrangThai == true)
            {
                CLearTimer(TimerCheckColorCaoRacSo4VangDo);
                if (TimerCheckColorCaoRacSo4VangXanh == null || TimerCheckColorCaoRacSo4VangXanh.Enabled == false)
                {
                    pictureBoxCaoRac4.Image = Resources.CaoRac4Vang;
                    TimerCheckColorCaoRacSo4VangXanh = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo4VangXanh.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo4VangXanh.Elapsed += Timer_Tick_CheckColorCaoRac4VangXanh;
                    TimerCheckColorCaoRacSo4VangXanh.Start();
                }
            }
            //vàng đỏ
            else if ((M10284 != null && M10284.TrangThai == true) && (M10286 != null && M10286.TrangThai == true)
                || (M10285 != null && M10285.TrangThai == true) && (M10286 != null && M10286.TrangThai == true))
            {
                CLearTimer(TimerCheckColorCaoRacSo4VangXanh);
                if (TimerCheckColorCaoRacSo4VangDo == null || TimerCheckColorCaoRacSo4VangDo.Enabled == false)
                {
                    pictureBoxCaoRac4.Image = Resources.CaoRac4Vang;
                    TimerCheckColorCaoRacSo4VangDo = new System.Timers.Timer();
                    TimerCheckColorCaoRacSo4VangDo.Interval = intervalNhapNhay;
                    TimerCheckColorCaoRacSo4VangDo.Elapsed += Timer_Tick_CheckColorCaoRac4VangDo;
                    TimerCheckColorCaoRacSo4VangDo.Start();
                }
            }
            else
            {
                CLearTimer(TimerCheckColorCaoRacSo4VangXanh);
                CLearTimer(TimerCheckColorCaoRacSo4VangXanh);
                pictureBoxCaoRac4.Image = Resources.CaoRac4Xanh;

            }
        }













        // Van



        // Tín hiệu van 1

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan1M10122(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan1)
            {
                pictureBoxVan1.Image = Resources.VanDo;
                nhapNhayTinHieuVan1 = false;
            }
            else
            {
                pictureBoxVan1.Image = Resources.VanTim;
                nhapNhayTinHieuVan1 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan1M10123(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan1)
            {
                pictureBoxVan1.Image = Resources.VanXanh;
                nhapNhayTinHieuVan1 = false;
            }
            else
            {
                pictureBoxVan1.Image = Resources.VanTim;
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
                pictureBoxVan1.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10124 != null && M10124.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan1M10122);
                CLearTimer(TimerTinHieuVan1M10123);
                pictureBoxVan1.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10122 != null && M10122.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan1M10123);
                if (TimerTinHieuVan1M10122 == null || TimerTinHieuVan1M10122.Enabled == false)
                {
                    pictureBoxVan1.Image = Resources.VanTim;
                    TimerTinHieuVan1M10122 = new System.Timers.Timer();
                    TimerTinHieuVan1M10122.Interval = intervalNhapNhay;
                    TimerTinHieuVan1M10122.Elapsed += Timer_Tick_CheckColorTinHieuVan1M10122;
                    TimerTinHieuVan1M10122.Start();
                }
            }
            //xanh tím
            else if (M10123 != null && M10123.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan1M10122);
                if (TimerTinHieuVan1M10123 == null || TimerTinHieuVan1M10123.Enabled == false)
                {
                    pictureBoxVan1.Image = Resources.VanTim;
                    TimerTinHieuVan1M10123 = new System.Timers.Timer();
                    TimerTinHieuVan1M10123.Interval = intervalNhapNhay;
                    TimerTinHieuVan1M10123.Elapsed += Timer_Tick_CheckColorTinHieuVan1M10123;
                    TimerTinHieuVan1M10123.Start();
                }
            }
            //tím
            else
            {
                CLearTimer(TimerTinHieuVan1M10122);
                CLearTimer(TimerTinHieuVan1M10123);
                pictureBoxVan1.Image = Resources.VanTim;
            }
        }
















        // Tín hiệu van 2

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan2M10171(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan2)
            {
                pictureBoxVan2.Image = Resources.VanDo;
                nhapNhayTinHieuVan2 = false;
            }
            else
            {
                pictureBoxVan2.Image = Resources.VanTim;
                nhapNhayTinHieuVan2 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan2M10172(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan2)
            {
                pictureBoxVan2.Image = Resources.VanXanh;
                nhapNhayTinHieuVan2 = false;
            }
            else
            {
                pictureBoxVan2.Image = Resources.VanTim;
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
                pictureBoxVan2.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10173 != null && M10173.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan2M10171);
                CLearTimer(TimerTinHieuVan2M10172);
                pictureBoxVan2.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10171 != null && M10171.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan2M10172);
                if (TimerTinHieuVan2M10171 == null || TimerTinHieuVan2M10171.Enabled == false)
                {
                    pictureBoxVan2.Image = Resources.VanTim;
                    TimerTinHieuVan2M10171 = new System.Timers.Timer();
                    TimerTinHieuVan2M10171.Interval = intervalNhapNhay;
                    TimerTinHieuVan2M10171.Elapsed += Timer_Tick_CheckColorTinHieuVan2M10171;
                    TimerTinHieuVan2M10171.Start();
                }
            }
            //xanh tím
            else if (M10172 != null && M10172.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan2M10171);
                if (TimerTinHieuVan2M10172 == null || TimerTinHieuVan2M10172.Enabled == false)
                {
                    pictureBoxVan2.Image = Resources.VanTim;
                    TimerTinHieuVan2M10172 = new System.Timers.Timer();
                    TimerTinHieuVan2M10172.Interval = intervalNhapNhay;
                    TimerTinHieuVan2M10172.Elapsed += Timer_Tick_CheckColorTinHieuVan2M10172;
                    TimerTinHieuVan2M10172.Start();
                }
            }
            //tím
            else
            {
                CLearTimer(TimerTinHieuVan2M10171);
                CLearTimer(TimerTinHieuVan2M10172);
                pictureBoxVan2.Image = Resources.VanTim;
            }
        }









        // Tín hiệu van 3

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan3M10220(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan3)
            {
                pictureBoxVan3.Image = Resources.VanTim;
                nhapNhayTinHieuVan3 = false;
            }
            else
            {
                pictureBoxVan3.Image = Resources.VanDo;
                nhapNhayTinHieuVan3 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan3M10221(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan3)
            {
                pictureBoxVan3.Image = Resources.VanTim;
                nhapNhayTinHieuVan3 = false;
            }
            else
            {
                pictureBoxVan3.Image = Resources.VanXanh;
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
                pictureBoxVan3.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10222 != null && M10222.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan3M10220);
                CLearTimer(TimerTinHieuVan3M10221);
                pictureBoxVan3.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10220 != null && M10220.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan3M10221);
                if (TimerTinHieuVan3M10220 == null || TimerTinHieuVan3M10220.Enabled == false)
                {
                    pictureBoxVan3.Image = Resources.VanTim;
                    TimerTinHieuVan3M10220 = new System.Timers.Timer();
                    TimerTinHieuVan3M10220.Interval = intervalNhapNhay;
                    TimerTinHieuVan3M10220.Elapsed += Timer_Tick_CheckColorTinHieuVan3M10220;
                    TimerTinHieuVan3M10220.Start();
                }
            }
            //xanh tím
            else if (M10221 != null && M10221.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan3M10220);
                if (TimerTinHieuVan3M10221 == null || TimerTinHieuVan3M10221.Enabled == false)
                {
                    pictureBoxVan3.Image = Resources.VanTim;
                    TimerTinHieuVan3M10221 = new System.Timers.Timer();
                    TimerTinHieuVan3M10221.Interval = intervalNhapNhay;
                    TimerTinHieuVan3M10221.Elapsed += Timer_Tick_CheckColorTinHieuVan3M10221;
                    TimerTinHieuVan3M10221.Start();
                }
            }
            //tím
            else
            {
                CLearTimer(TimerTinHieuVan3M10220);
                CLearTimer(TimerTinHieuVan3M10221);
                pictureBoxVan3.Image = Resources.VanTim;
            }
        }












        // Tín hiệu van 4

        //đỏ - tím
        private void Timer_Tick_CheckColorTinHieuVan4M10270(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan4)
            {
                pictureBoxVan4.Image = Resources.VanTim;
                nhapNhayTinHieuVan4 = false;
            }
            else
            {
                pictureBoxVan4.Image = Resources.VanDo;
                nhapNhayTinHieuVan4 = true;
            }
        }
        //xanh tím
        private void Timer_Tick_CheckColorTinHieuVan4M10271(object sender, EventArgs e)
        {
            if (nhapNhayTinHieuVan4)
            {
                pictureBoxVan4.Image = Resources.VanTim;
                nhapNhayTinHieuVan4 = false;
            }
            else
            {
                pictureBoxVan4.Image = Resources.VanXanh;
                nhapNhayTinHieuVan4 = true;
            }
        }

        void CheckColorVan4(Digital? M10272, Digital? M10271, Digital? M10269, Digital? M10270)
        {
            //xanh
            if (M10272 != null && M10272.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10270);
                CLearTimer(TimerTinHieuVan4M10271);
                pictureBoxVan4.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10271 != null && M10271.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10270);
                CLearTimer(TimerTinHieuVan4M10271);
                pictureBoxVan4.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10269 != null && M10269.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10271);
                if (TimerTinHieuVan4M10270 == null || TimerTinHieuVan4M10270.Enabled == false)
                {
                    pictureBoxVan4.Image = Resources.VanTim;
                    TimerTinHieuVan4M10270 = new System.Timers.Timer();
                    TimerTinHieuVan4M10270.Interval = intervalNhapNhay;
                    TimerTinHieuVan4M10270.Elapsed += Timer_Tick_CheckColorTinHieuVan4M10270;
                    TimerTinHieuVan4M10270.Start();
                }
            }
            //xanh tím
            else if (M10270 != null && M10270.TrangThai == true)
            {
                CLearTimer(TimerTinHieuVan4M10270);
                if (TimerTinHieuVan4M10271 == null || TimerTinHieuVan4M10271.Enabled == false)
                {
                    pictureBoxVan4.Image = Resources.VanTim;
                    TimerTinHieuVan4M10271 = new System.Timers.Timer();
                    TimerTinHieuVan4M10271.Interval = intervalNhapNhay;
                    TimerTinHieuVan4M10271.Elapsed += Timer_Tick_CheckColorTinHieuVan4M10271;
                    TimerTinHieuVan4M10271.Start();
                }
            }
            //tím
            else
            {
                CLearTimer(TimerTinHieuVan4M10270);
                CLearTimer(TimerTinHieuVan4M10271);
                pictureBoxVan4.Image = Resources.VanTim;
            }
        }

    }
}
