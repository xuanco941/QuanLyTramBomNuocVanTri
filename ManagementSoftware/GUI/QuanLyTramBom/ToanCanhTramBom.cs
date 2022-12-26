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
            //CheckColorBangTaiThang(await plcDigital.GetADigital(digitalCommon.M10065), await plcDigital.GetADigital(digitalCommon.M10066), await plcDigital.GetADigital(digitalCommon.M10067), await plcDigital.GetADigital(digitalCommon.M10064));
            //CheckColorBangTaiXien(await plcDigital.GetADigital(digitalCommon.M10069), await plcDigital.GetADigital(digitalCommon.M10070), await plcDigital.GetADigital(digitalCommon.M10071), await plcDigital.GetADigital(digitalCommon.M10068));

            CheckColorBomThoat1(await plcDigital.GetADigital(digitalCommon.M10077));
            CheckColorBomThoat2(await plcDigital.GetADigital(digitalCommon.M10079));
            //CheckColorPheuSo1(await plcDigital.GetADigital(digitalCommon.M10042), await plcDigital.GetADigital(digitalCommon.M10041), await plcDigital.GetADigital(digitalCommon.M10039), await plcDigital.GetADigital(digitalCommon.M10040));
            //CheckColorPheuSo2(await plcDigital.GetADigital(digitalCommon.M10051), await plcDigital.GetADigital(digitalCommon.M10050), await plcDigital.GetADigital(digitalCommon.M10048), await plcDigital.GetADigital(digitalCommon.M10049));
            //CheckColorVan1(await plcDigital.GetADigital(digitalCommon.M10125), await plcDigital.GetADigital(digitalCommon.M10124), await plcDigital.GetADigital(digitalCommon.M10122), await plcDigital.GetADigital(digitalCommon.M10123));
            //CheckColorVan2(await plcDigital.GetADigital(digitalCommon.M10174), await plcDigital.GetADigital(digitalCommon.M10173), await plcDigital.GetADigital(digitalCommon.M10171), await plcDigital.GetADigital(digitalCommon.M10172));
            //CheckColorVan3(await plcDigital.GetADigital(digitalCommon.M10223), await plcDigital.GetADigital(digitalCommon.M10222), await plcDigital.GetADigital(digitalCommon.M10220), await plcDigital.GetADigital(digitalCommon.M10221));
            //CheckColorVan4(await plcDigital.GetADigital(digitalCommon.M10272), await plcDigital.GetADigital(digitalCommon.M10271), await plcDigital.GetADigital(digitalCommon.M10270), await plcDigital.GetADigital(digitalCommon.M10269));
            //CheckColorTrangThaiBom1(await plcDigital.GetADigital(digitalCommon.M10095), await plcDigital.GetADigital(digitalCommon.M10096), await plcDigital.GetADigital(digitalCommon.M10118));
            CheckColorTrangThaiBom2(await plcDigital.GetADigital(digitalCommon.M10144), await plcDigital.GetADigital(digitalCommon.M10145), await plcDigital.GetADigital(digitalCommon.M10167));
            CheckColorTrangThaiBom3(await plcDigital.GetADigital(digitalCommon.M10193), await plcDigital.GetADigital(digitalCommon.M10194), await plcDigital.GetADigital(digitalCommon.M10216));
            CheckColorTrangThaiBom4(await plcDigital.GetADigital(digitalCommon.M10242), await plcDigital.GetADigital(digitalCommon.M10243), await plcDigital.GetADigital(digitalCommon.M10265));
            CheckColorBomMoi1(await plcDigital.GetADigital(digitalCommon.M10059));
            CheckColorBomMoi2(await plcDigital.GetADigital(digitalCommon.M10061));
            CheckTinHieuMayBom(await plcDigital.GetADigital(digitalCommon.M10097), await plcDigital.GetADigital(digitalCommon.M10146), await plcDigital.GetADigital(digitalCommon.M10195), await plcDigital.GetADigital(digitalCommon.M10244));

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
                    lb2.BackColor = Color.Red;
                    lb1.BackColor = Color.Silver;
                }
            }
            else
            {
                lb1.BackColor = Color.Silver;
                lb2.BackColor = Color.Red;
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
                if (M10059.TrangThai)
                {
                    BomMoi1.Image = Resources.BomMoiXanh;
                }
                //đỏ
                else if (M10059.TrangThai)
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
                if (M10061.TrangThai)
                {
                    BomMoi2.Image = Resources.BomMoi2Xanh;
                }
                //đỏ
                else if (M10061.TrangThai)
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
                else if (M10077.TrangThai)
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
                else if (M10079.TrangThai)
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










        ////đỏ - xanh
        //private void Timer_Tick_CheckColorBTDocDo(object sender, EventArgs e)
        //{
        //    if (nhapNhayBTDoc)
        //    {
        //        pictureBoxBangTaiDoc.Image = Resources.BTDocDo;
        //        nhapNhayBTDoc = false;
        //    }
        //    else
        //    {
        //        pictureBoxBangTaiDoc.Image = Resources.BTDocXanh;
        //        nhapNhayBTDoc = true;
        //    }
        //}


        ////vàng - xanh
        //private void Timer_Tick_CheckColorBTDocVang(object sender, EventArgs e)
        //{
        //    if (nhapNhayBTDoc)
        //    {
        //        pictureBoxBangTaiDoc.Image = Resources.BTDocVang;
        //        nhapNhayBTDoc = false;
        //    }
        //    else
        //    {
        //        pictureBoxBangTaiDoc.Image = Resources.BTDocXanh;
        //        nhapNhayBTDoc = true;
        //    }
        //}




        ////băng tải thẳng
        //void CheckColorBangTaiThang(Digital? M10065, Digital? M10066, Digital? M10067, Digital? M10064)
        //{
        //    // nhap nhay vang bang tai thang
        //    if ((M10064 != null && M10064.TrangThai) && (M10067 != null && M10067.TrangThai))
        //    {
        //        CLearTimer(TimerBTDocDo);
        //        if (TimerBTDocVang == null || TimerBTDocVang.Enabled == false)
        //        {
        //            pictureBoxBangTaiDoc.Image = Resources.BTDocVang;
        //            TimerBTDocVang = new System.Timers.Timer();
        //            TimerBTDocVang.Interval = intervalNhapNhay;
        //            TimerBTDocVang.Elapsed += Timer_Tick_CheckColorBTDocVang;
        //            TimerBTDocVang.Start();
        //        }
        //    }
        //    // nhap nhay do
        //    else if ((M10066 != null && M10066.TrangThai) && (M10065 != null && M10065.TrangThai))
        //    {
        //        CLearTimer(TimerBTDocVang);
        //        if (TimerBTDocDo == null || TimerBTDocDo.Enabled == false)
        //        {
        //            pictureBoxBangTaiDoc.Image = Resources.BTDocDo;
        //            TimerBTDocDo = new System.Timers.Timer();
        //            TimerBTDocDo.Interval = intervalNhapNhay;
        //            TimerBTDocDo.Elapsed += Timer_Tick_CheckColorBTDocDo;
        //            TimerBTDocDo.Start();
        //        }
        //    }
        //    else
        //    {
        //        pictureBoxBangTaiDoc.Image = Resources.BTDocXanh;
        //    }

        //}

    }
}
