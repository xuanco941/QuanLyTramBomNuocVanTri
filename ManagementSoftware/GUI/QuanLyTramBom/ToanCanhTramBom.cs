using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using ManagementSoftware.Properties;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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



        void LoadTextAnalog(Label btn, Analog? a)
        {

            if (a != null)
            {
                string str = String.Format("{0:0.00}", a.GiaTriDong);
                if (a.DiaChiPLC == "D10000" || a.DiaChiPLC == "D10004" || a.DiaChiPLC == "D10002" || a.DiaChiPLC == "D10006")
                {
                    str = str + "  " + a.DonVi;
                }
                btn.Text = str;
            }
            else
            {
                btn.Text = "N/A";
            }

        }


        System.Threading.Timer timer1;
        System.Threading.Timer timer2;

        int TIME_INTERVAL_IN_MILLISECONDS = 1000;




        private async void Callback1(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();


            // update data
            // Long running operation

            Analog? D10000c = await plcAnalog.GetAnAnalog(analogCommon.D10000);
            Analog? D10002c = await plcAnalog.GetAnAnalog(analogCommon.D10002);
            Analog? D10004c = await plcAnalog.GetAnAnalog(analogCommon.D10004);
            Analog? D10006c = await plcAnalog.GetAnAnalog(analogCommon.D10006);
            Analog? D10008c = await plcAnalog.GetAnAnalog(analogCommon.D10008);
            Analog? D10010c = await plcAnalog.GetAnAnalog(analogCommon.D10010);
            Analog? D10022c = await plcAnalog.GetAnAnalog(analogCommon.D10022);
            Analog? D10024c = await plcAnalog.GetAnAnalog(analogCommon.D10024);
            Analog? D10036c = await plcAnalog.GetAnAnalog(analogCommon.D10036);
            Analog? D10038c = await plcAnalog.GetAnAnalog(analogCommon.D10038);
            Analog? D10050c = await plcAnalog.GetAnAnalog(analogCommon.D10050);
            Analog? D10052c = await plcAnalog.GetAnAnalog(analogCommon.D10052);
            Analog? D10064c = await plcAnalog.GetAnAnalog(analogCommon.D10064);
            Analog? D10066c = await plcAnalog.GetAnAnalog(analogCommon.D10066);




            UpdateDataAnalog(D10000c, D10002c, D10004c, D10006c, D10008c, D10010c, D10022c, D10024c, D10036c, D10038c, D10050c, D10052c, D10064c, D10066c);


            timer1.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
        }




        private void UpdateDataAnalog(Analog? D10000c, Analog? D10002c, Analog? D10004c, Analog? D10006c, Analog? D10008c, Analog? D10010c, Analog? D10022c,
            Analog? D10024c, Analog? D10036c, Analog? D10038c, Analog? D10050c, Analog? D10052c, Analog? D10064c, Analog? D10066c)
        {

            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action<Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?, Analog?>(UpdateDataAnalog), D10000c, D10002c, D10004c, D10006c, D10008c, D10010c, D10022c, D10024c, D10036c, D10038c, D10050c, D10052c, D10064c, D10066c);
                return;
            }


            //update gui

            LoadTextAnalog(D10000, D10000c);
            LoadTextAnalog(D10002, D10002c);
            LoadTextAnalog(D10004, D10004c);
            LoadTextAnalog(D10006, D10006c);
            LoadTextAnalog(D10008, D10008c);
            LoadTextAnalog(D10010, D10010c);
            LoadTextAnalog(D10022, D10022c);
            LoadTextAnalog(D10024, D10024c);
            LoadTextAnalog(D10036, D10036c);
            LoadTextAnalog(D10038, D10038c);
            LoadTextAnalog(D10050, D10050c);
            LoadTextAnalog(D10052, D10052c);
            LoadTextAnalog(D10064, D10064c);
            LoadTextAnalog(D10066, D10066c);
        }



        public ToanCanhTramBom()
        {
            InitializeComponent();
            plcAnalog = new PLCAnalog();
            plcDigital = new PLCDigital();


            analogCommon = new AnalogCommon();
            digitalCommon = new DigitalCommon();

        }


        void CloseTimer()
        {
            if (timer1 != null)
            {
                this.timer1.Change(Timeout.Infinite, Timeout.Infinite);
            }
            if (timer2 != null)
            {
                this.timer2.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }


        private async void ToanCanhTramBom_FormClosing(object sender, FormClosingEventArgs e)
        {

            await plcAnalog.Close();
            await plcDigital.Close();


            CloseTimer();
        }


        private async void ToanCanhTramBom_Load(object sender, EventArgs e)
        {
            if (await plcAnalog.Open() == 0)
            {
                timer1 = new System.Threading.Timer(Callback1, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);
            }
            if (await plcDigital.Open() == 0)
            {
                timer2 = new System.Threading.Timer(Callback2, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);
            }

        }













        // DIGITAL -----------------------------------------------------------------------------------

        private async void Callback2(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();


            // update data
            // Long running operation







            //BangTaiThang

            Digital? M10065 = await plcDigital.GetADigital(digitalCommon.M10065);
            Digital? M10066 = await plcDigital.GetADigital(digitalCommon.M10066);
            Digital? M10067 = await plcDigital.GetADigital(digitalCommon.M10067);
            Digital? M10064 = await plcDigital.GetADigital(digitalCommon.M10064);

            //BangTaiXien 

            Digital? M10069 = await plcDigital.GetADigital(digitalCommon.M10069);
            Digital? M10070 = await plcDigital.GetADigital(digitalCommon.M10070);
            Digital? M10071 = await plcDigital.GetADigital(digitalCommon.M10071);
            Digital? M10068 = await plcDigital.GetADigital(digitalCommon.M10068);

            //BomThoat1 
            Digital? M10077 = await plcDigital.GetADigital(digitalCommon.M10077);

            //BomThoat2
            Digital? M10079 = await plcDigital.GetADigital(digitalCommon.M10079);

            //TrangThaiBom2 
            Digital? M10144 = await plcDigital.GetADigital(digitalCommon.M10144);
            Digital? M10145 = await plcDigital.GetADigital(digitalCommon.M10145);
            Digital? M10167 = await plcDigital.GetADigital(digitalCommon.M10167);

            //TrangThaiBom3
            Digital? M10193 = await plcDigital.GetADigital(digitalCommon.M10193);
            Digital? M10194 = await plcDigital.GetADigital(digitalCommon.M10194);
            Digital? M10216 = await plcDigital.GetADigital(digitalCommon.M10216);

            //TrangThaiBom4
            Digital? M10242 = await plcDigital.GetADigital(digitalCommon.M10242);
            Digital? M10243 = await plcDigital.GetADigital(digitalCommon.M10243);
            Digital? M10265 = await plcDigital.GetADigital(digitalCommon.M10265);

            //BomMoi1
            Digital? M10059 = await plcDigital.GetADigital(digitalCommon.M10059);

            //BomMoi2
            Digital? M10061 = await plcDigital.GetADigital(digitalCommon.M10061);

            //PheuSo1
            Digital? M10042 = await plcDigital.GetADigital(digitalCommon.M10042);
            Digital? M10041 = await plcDigital.GetADigital(digitalCommon.M10041);
            Digital? M10039 = await plcDigital.GetADigital(digitalCommon.M10039);
            Digital? M10040 = await plcDigital.GetADigital(digitalCommon.M10040);
            Digital? M10038 = await plcDigital.GetADigital(digitalCommon.M10038);

            //PheuSo2
            Digital? M10051 = await plcDigital.GetADigital(digitalCommon.M10051);
            Digital? M10050 = await plcDigital.GetADigital(digitalCommon.M10050);
            Digital? M10048 = await plcDigital.GetADigital(digitalCommon.M10048);
            Digital? M10049 = await plcDigital.GetADigital(digitalCommon.M10049);
            Digital? M10047 = await plcDigital.GetADigital(digitalCommon.M10047);

            //Van1
            Digital? M10125 = await plcDigital.GetADigital(digitalCommon.M10125);
            Digital? M10124 = await plcDigital.GetADigital(digitalCommon.M10124);
            Digital? M10122 = await plcDigital.GetADigital(digitalCommon.M10122);
            Digital? M10123 = await plcDigital.GetADigital(digitalCommon.M10123);

            //Van2
            Digital? M10174 = await plcDigital.GetADigital(digitalCommon.M10174);
            Digital? M10173 = await plcDigital.GetADigital(digitalCommon.M10173);
            Digital? M10171 = await plcDigital.GetADigital(digitalCommon.M10171);
            Digital? M10172 = await plcDigital.GetADigital(digitalCommon.M10172);

            //Van3
            Digital? M10223 = await plcDigital.GetADigital(digitalCommon.M10223);
            Digital? M10222 = await plcDigital.GetADigital(digitalCommon.M10222);
            Digital? M10220 = await plcDigital.GetADigital(digitalCommon.M10220);
            Digital? M10221 = await plcDigital.GetADigital(digitalCommon.M10221);

            //Van4
            Digital? M10272 = await plcDigital.GetADigital(digitalCommon.M10272);
            Digital? M10271 = await plcDigital.GetADigital(digitalCommon.M10271);
            Digital? M10269 = await plcDigital.GetADigital(digitalCommon.M10269);
            Digital? M10270 = await plcDigital.GetADigital(digitalCommon.M10270);

            // TrangThaiBom1
            Digital? M10095 = await plcDigital.GetADigital(digitalCommon.M10095);
            Digital? M10096 = await plcDigital.GetADigital(digitalCommon.M10096);
            Digital? M10118 = await plcDigital.GetADigital(digitalCommon.M10118);

            //tin hieu may bom
            Digital? M10097 = await plcDigital.GetADigital(digitalCommon.M10097);
            Digital? M10146 = await plcDigital.GetADigital(digitalCommon.M10146);
            Digital? M10195 = await plcDigital.GetADigital(digitalCommon.M10195);
            Digital? M10244 = await plcDigital.GetADigital(digitalCommon.M10244);



            //CaoRac1
            Digital? M10137 = await plcDigital.GetADigital(digitalCommon.M10137);
            Digital? M10138 = await plcDigital.GetADigital(digitalCommon.M10138);
            Digital? M10139 = await plcDigital.GetADigital(digitalCommon.M10139);

            //CaoRac2
            Digital? M10186 = await plcDigital.GetADigital(digitalCommon.M10186);
            Digital? M10187 = await plcDigital.GetADigital(digitalCommon.M10187);
            Digital? M10188 = await plcDigital.GetADigital(digitalCommon.M10188);

            //CaoRac3
            Digital? M10235 = await plcDigital.GetADigital(digitalCommon.M10235);
            Digital? M10236 = await plcDigital.GetADigital(digitalCommon.M10236);
            Digital? M10237 = await plcDigital.GetADigital(digitalCommon.M10237);

            //CaoRac4
            Digital? M10284 = await plcDigital.GetADigital(digitalCommon.M10284);
            Digital? M10285 = await plcDigital.GetADigital(digitalCommon.M10285);
            Digital? M10286 = await plcDigital.GetADigital(digitalCommon.M10286);




            UpdateDataDigital(M10065, M10066, M10067, M10064, M10069, M10070, M10071, M10068, M10077, M10079, M10144, M10145, M10167, M10193, M10194, M10216, M10243, M10265, M10242, M10059, M10061, M10042, M10041, M10039, M10040, M10038, M10051, M10050, M10048, M10049, M10047, M10125, M10124, M10122, M10123, M10174, M10173, M10171, M10172,
  M10223, M10222, M10220, M10221, M10272, M10271, M10269, M10270, M10095, M10096, M10118, M10137, M10138, M10139, M10186, M10187, M10188, M10235, M10236, M10237, M10284, M10285, M10286, M10097, M10146, M10195, M10244);


            timer2.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
        }


        public delegate void Del(Digital? M10065c, Digital? M10066c, Digital? M10067c, Digital? M10064c, Digital? M10069c, Digital? M10070c, Digital? M10071c, Digital? M10068c,
            Digital? M10077c, Digital? M10079c, Digital? M10144c, Digital? M10145c, Digital? M10167c, Digital? M10193c, Digital? M10194c, Digital? M10216c,
            Digital? M10243c, Digital? M10265c, Digital? M10242c, Digital? M10059c, Digital? M10061c, Digital? M10042c, Digital? M10041c, Digital? M10039c, Digital? M10040c,
            Digital? M10038c, Digital? M10051c, Digital? M10050c, Digital? M10048c, Digital? M10049c, Digital? M10047c, Digital? M10125c, Digital? M10124c, Digital? M10122c,
            Digital? M10123c, Digital? M10174c, Digital? M10173c, Digital? M10171c, Digital? M10172c, Digital? M10223c, Digital? M10222c, Digital? M10220c, Digital? M10221c,
            Digital? M10272c, Digital? M10271c, Digital? M10269c, Digital? M10270c, Digital? M10095c, Digital? M10096c, Digital? M10118c, Digital? M10137c, Digital? M10138c,
            Digital? M10139c, Digital? M10186c, Digital? M10187c, Digital? M10188c, Digital? M10235c, Digital? M10236c, Digital? M10237c, Digital? M10284c, Digital? M10285c,
            Digital? M10286c, Digital? M10097c, Digital? M10146c, Digital? M10195c, Digital? M10244c);

        private void UpdateDataDigital(Digital? M10065c, Digital? M10066c, Digital? M10067c, Digital? M10064c, Digital? M10069c, Digital? M10070c, Digital? M10071c, Digital? M10068c,
            Digital? M10077c, Digital? M10079c, Digital? M10144c, Digital? M10145c, Digital? M10167c, Digital? M10193c, Digital? M10194c, Digital? M10216c,
            Digital? M10243c, Digital? M10265c, Digital? M10242c, Digital? M10059c, Digital? M10061c, Digital? M10042c, Digital? M10041c, Digital? M10039c, Digital? M10040c,
            Digital? M10038c, Digital? M10051c, Digital? M10050c, Digital? M10048c, Digital? M10049c, Digital? M10047c, Digital? M10125c, Digital? M10124c, Digital? M10122c,
            Digital? M10123c, Digital? M10174c, Digital? M10173c, Digital? M10171c, Digital? M10172c, Digital? M10223c, Digital? M10222c, Digital? M10220c, Digital? M10221c,
            Digital? M10272c, Digital? M10271c, Digital? M10269c, Digital? M10270c, Digital? M10095c, Digital? M10096c, Digital? M10118c, Digital? M10137c, Digital? M10138c,
            Digital? M10139c, Digital? M10186c, Digital? M10187c, Digital? M10188c, Digital? M10235c, Digital? M10236c, Digital? M10237c, Digital? M10284c, Digital? M10285c,
            Digital? M10286c, Digital? M10097c, Digital? M10146c, Digital? M10195c, Digital? M10244c)
        {
            //          if (IsHandleCreated && InvokeRequired)
            //          {
            //              BeginInvoke(new System.Action<Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?,
            //          Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?,
            //          Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?,
            //          Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?,
            //          Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?,
            //          Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?,
            //          Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?, Digital?,
            //          Digital?, Digital?, Digital?, Digital?, Digital?>(UpdateDataDigital), M10065c, M10066c, M10067c, M10064c, M10069c, M10070c, M10071c, M10068c, M10077c, M10079c, M10144c, M10145c, M10167c, M10193c, M10194c, M10216c, M10243c, M10265c, M10242c, M10059c, M10061c, M10042c, M10041c, M10039c, M10040c, M10038c, M10051c, M10050c, M10048c, M10049c, M10047c, M10125c, M10124c, M10122c, M10123c, M10174c, M10173c, M10171c, M10172c,
            //M10223c, M10222c, M10220c, M10221c, M10272c, M10271c, M10269c, M10270c, M10095c, M10096c, M10118c, M10137c, M10138c, M10139c, M10186c, M10187c, M10188c, M10235c, M10236c, M10237c, M10284c, M10285c, M10286c, M10097c, M10146c, M10195c, M10244c);
            //              return;
            //          }

            if (IsHandleCreated && InvokeRequired)
            {
                Del del = UpdateDataDigital;
                BeginInvoke(del, M10065c, M10066c, M10067c, M10064c, M10069c, M10070c, M10071c, M10068c, M10077c, M10079c, M10144c, M10145c, M10167c, M10193c, M10194c, M10216c, M10243c, M10265c, M10242c, M10059c, M10061c, M10042c, M10041c, M10039c, M10040c, M10038c, M10051c, M10050c, M10048c, M10049c, M10047c, M10125c, M10124c, M10122c, M10123c, M10174c, M10173c, M10171c, M10172c,
  M10223c, M10222c, M10220c, M10221c, M10272c, M10271c, M10269c, M10270c, M10095c, M10096c, M10118c, M10137c, M10138c, M10139c, M10186c, M10187c, M10188c, M10235c, M10236c, M10237c, M10284c, M10285c, M10286c, M10097c, M10146c, M10195c, M10244c);
                return;
            }










            CheckColorBangTaiThang(M10065c, M10066c, M10067c, M10064c);


            CheckColorBangTaiXien(M10069c, M10070c, M10071c, M10068c);


            CheckColorBomThoat1(M10077c);
            CheckColorBomThoat2(M10079c);

            CheckColorTrangThaiBom1(M10095c, M10096c, M10118c);
            CheckColorTrangThaiBom2(M10144c, M10145c, M10167c);


            CheckColorTrangThaiBom3(M10193c, M10194c, M10216c);
            CheckColorTrangThaiBom4(M10242c, M10243c, M10265c);
            CheckColorBomMoi1(M10059c);
            CheckColorBomMoi2(M10061c);
            CheckTinHieuMayBom(M10097c, M10146c, M10195c, M10244c);


            CheckColorPheuSo1(M10042c, M10041c, M10039c, M10040c, M10038c);
            CheckColorPheuSo2(M10051c, M10050c, M10048c, M10049c, M10047c);
            CheckColorVan1(M10125c, M10124c, M10122c, M10123c);
            CheckColorVan2(M10174c, M10173c, M10171c, M10172c);
            CheckColorVan3(M10223c, M10222c, M10220c, M10221c);
            CheckColorVan4(M10272c, M10271c, M10269c, M10270c);


            CheckColorCaoRac1(M10137c, M10138c, M10139c);

            CheckColorCaoRac2(M10186c, M10187c, M10188c);
            CheckColorCaoRac3(M10235c, M10236c, M10237c);
            CheckColorCaoRac4(M10284c, M10285c, M10286c);
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
                if (M10077.TrangThai == false)
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
                if (M10079.TrangThai == false)
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




        bool nhapNhayPheuSo1 = false;

        bool nhapNhayPheuSo2 = false;

        bool nhapNhayCaoRacSo1 = false;

        bool nhapNhayCaoRacSo2 = false;

        bool nhapNhayCaoRacSo3 = false;

        bool nhapNhayCaoRacSo4 = false;

        bool nhapNhayTinHieuVan1 = false;

        bool nhapNhayTinHieuVan2 = false;

        bool nhapNhayTinHieuVan3 = false;

        bool nhapNhayTinHieuVan4 = false;

        bool nhapNhayBTDoc = false;

        bool nhapNhayBTXien = false;



        //đỏ - xanh
        void BangTaiDocDoXanh()
        {
            if (nhapNhayBTDoc)
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangDo;
            }
            else
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangXanh;
            }
            nhapNhayBTDoc = !nhapNhayBTDoc;
        }


        //vàng - xanh
        private void BangTaiDocVangXanh()
        {
            if (nhapNhayBTDoc)
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangVang;
            }
            else
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangXanh;
            }
            nhapNhayBTDoc = !nhapNhayBTDoc;

        }




        //băng tải thẳng
        void CheckColorBangTaiThang(Digital? M10065, Digital? M10066, Digital? M10067, Digital? M10064)
        {
            // nhap nhay vang bang tai thang
            if ((M10064 != null && M10064.TrangThai) && (M10067 != null && M10067.TrangThai))
            {
                BangTaiDocVangXanh();
            }
            // nhap nhay do
            else if ((M10066 != null && M10066.TrangThai) && (M10065 != null && M10065.TrangThai))
            {
                BangTaiDocDoXanh();
            }
            else
            {
                pictureBoxBangTaiThang.Image = Resources.BangTaiThangXanh;
            }

        }

















        //băng tải xiên

        //đỏ - xanh
        private void BTXienDoXanh()
        {
            if (nhapNhayBTXien)
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienDo;
            }
            else
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienXanh;
            }
            nhapNhayBTXien = !nhapNhayBTXien;
        }


        //vàng - xanh
        private void BTXienVangXanh()
        {
            if (nhapNhayBTXien)
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienVang;
            }
            else
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienXanh;
            }
            nhapNhayBTXien = !nhapNhayBTXien;
        }
        void CheckColorBangTaiXien(Digital? M10069, Digital? M10070, Digital? M10071, Digital? M10068)
        {

            //nhap nhay vang xanh
            if ((M10071 != null && M10071.TrangThai) && (M10068 != null && M10068.TrangThai))
            {
                BTXienVangXanh();
            }
            //chi mau đỏ
            else if ((M10069 != null && M10069.TrangThai) && (M10070 != null && M10070.TrangThai))
            {
                BTXienDoXanh();
            }
            else //mau xanh
            {
                pictureBoxBangTaiXien.Image = Resources.BangTaiXienXanh;

            }

        }









        //phễu
        // PHỄU SÔ 1

        //đỏ - tím - 10039
        private void PheuSo1DoTim()
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenDo;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
            }
            nhapNhayPheuSo1 = !nhapNhayPheuSo1;
        }
        //xanh tím 10040
        private void PheuSo1XanhTim()
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenXanh;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
            }
            nhapNhayPheuSo1 = !nhapNhayPheuSo1;

        }
        //vàng tím 10038
        private void PheuSo1VangTim()
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenVang;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
            }
            nhapNhayPheuSo1 = !nhapNhayPheuSo1;
        }
        //vàng đỏ 10038 - 10040
        private void PheuSo1VangDo()
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenVang;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenDo;
            }
            nhapNhayPheuSo1 = !nhapNhayPheuSo1;
        }
        //vàng xanh 10038 - 10039
        private void PheuSo1VangXanh()
        {
            if (nhapNhayPheuSo1)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenVang;
            }
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenXanh;
            }
            nhapNhayPheuSo1 = !nhapNhayPheuSo1;
        }
        void CheckColorPheuSo1(Digital? M10042, Digital? M10041, Digital? M10039, Digital? M10040, Digital? M10038)
        {
            //xanh
            if (M10042 != null && M10042.TrangThai == true)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenXanh;
            }
            //đỏ
            else if (M10041 != null && M10041.TrangThai == true)
            {
                pictureBoxPheu1.Image = Resources.PheuTrenDo;
            }
            //đen
            else if (((M10041 != null && M10041.TrangThai == true) && (M10040 != null && M10040.TrangThai == true))
                || ((M10041 != null && M10041.TrangThai == true) && (M10039 != null && M10039.TrangThai == true))
                || ((M10042 != null && M10042.TrangThai == true) && (M10039 != null && M10039.TrangThai == true))
                || ((M10042 != null && M10042.TrangThai == true) && (M10040 != null && M10040.TrangThai == true)))
            {
                pictureBoxPheu1.Image = Resources.PheuTrenDen;
            }
            //đỏ tím
            else if (M10039 != null && M10039.TrangThai == true)
            {
                PheuSo1DoTim();
            }
            //xanh tím
            else if (M10040 != null && M10040.TrangThai == true)
            {
                PheuSo1XanhTim();
            }
            //vàng tím
            else if (M10038 != null && M10038.TrangThai == true)
            {
                PheuSo1VangTim();
            }
            //vàng đỏ
            else if ((M10038 != null && M10038.TrangThai == true) && (M10040 != null && M10040.TrangThai == true))
            {
                PheuSo1VangDo();
            }
            //vàng xanh
            else if ((M10038 != null && M10038.TrangThai == true) && (M10039 != null && M10039.TrangThai == true))
            {
                PheuSo1VangXanh();
            }
            // tím
            else
            {
                pictureBoxPheu1.Image = Resources.PheuTrenTim;
            }
        }














        //Phễu số 2


        //đỏ - tím
        private void PheuSo2DoTim()
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiDo;
            }
            nhapNhayPheuSo2 = !nhapNhayPheuSo2;
        }
        //xanh tím
        private void PheuSo2XanhTim()
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiXanh;
            }
            nhapNhayPheuSo2 = !nhapNhayPheuSo2;
        }
        //vàng tím
        private void PheuSo2VangTim()
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiVang;
            }
            nhapNhayPheuSo2 = !nhapNhayPheuSo2;
        }
        //vàng đỏ
        private void PheuSo2VangDo()
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiDo;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiVang;
            }
            nhapNhayPheuSo2 = !nhapNhayPheuSo2;

        }
        //vàng xanh
        private void PheuSo2VangXanh()
        {
            if (nhapNhayPheuSo2)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiXanh;
            }
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiVang;
            }
            nhapNhayPheuSo2 = !nhapNhayPheuSo2;
        }

        void CheckColorPheuSo2(Digital? M10051, Digital? M10050, Digital? M10048, Digital? M10049, Digital? M10047)
        {
            //xanh
            if (M10051 != null && M10051.TrangThai == true)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiXanh;
            }
            //đỏ
            else if (M10050 != null && M10050.TrangThai == true)
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiDo;
            }
            //đen
            else if (((M10050 != null && M10050.TrangThai == true) && (M10049 != null && M10049.TrangThai == true))
                || ((M10050 != null && M10050.TrangThai == true) && (M10048 != null && M10048.TrangThai == true))
                || ((M10051 != null && M10051.TrangThai == true) && (M10049 != null && M10049.TrangThai == true))
                || ((M10051 != null && M10051.TrangThai == true) && (M10048 != null && M10048.TrangThai == true)))
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiDen;
            }
            //đỏ tím
            else if (M10048 != null && M10048.TrangThai == true)
            {
                PheuSo2DoTim();
            }
            //xanh tím
            else if (M10049 != null && M10049.TrangThai == true)
            {
                PheuSo2XanhTim();
            }
            //vàng tím
            else if (M10047 != null && M10047.TrangThai == true)
            {
                PheuSo2VangTim();
            }
            //vàng đỏ
            else if ((M10047 != null && M10047.TrangThai == true) && (M10048 != null && M10048.TrangThai == true))
            {
                PheuSo2VangDo();
            }
            //vàng xanh
            else if ((M10047 != null && M10047.TrangThai == true) && (M10049 != null && M10049.TrangThai == true))
            {
                PheuSo2VangXanh();
            }
            //tím
            else
            {
                pictureBoxPheu2.Image = Resources.PheuDuoiTim;
            }
        }














        //Cào Rác
        //1
        //vàng xanh
        private void CaoRac1VangXanh()
        {
            if (nhapNhayCaoRacSo1)
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Vang;
            }
            else
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Xanh;
            }
            nhapNhayCaoRacSo1 = !nhapNhayCaoRacSo1;
        }
        //vàng đỏ
        private void CaoRac1VangDo()
        {
            if (nhapNhayCaoRacSo1)
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Vang;
            }
            else
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Do;
            }
            nhapNhayCaoRacSo1 = !nhapNhayCaoRacSo1;

        }
        void CheckColorCaoRac1(Digital? M10137, Digital? M10138, Digital? M10139)
        {
            //đỏ
            if ((M10137 != null && M10137.TrangThai == true) || (M10138 != null && M10138.TrangThai == true))
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Do;
            }
            //vàng xanh
            else if (M10139 != null && M10139.TrangThai == true)
            {
                CaoRac1VangXanh();
            }
            //vàng đỏ
            else if ((M10137 != null && M10137.TrangThai == true) && (M10139 != null && M10139.TrangThai == true)
                || (M10138 != null && M10138.TrangThai == true) && (M10139 != null && M10139.TrangThai == true))
            {
                CaoRac1VangDo();
            }
            else
            {
                pictureBoxCaoRac1.Image = Resources.CaoRac1Xanh;

            }
        }






        //2
        //vàng xanh
        private void CaoRacSo2VangXanh()
        {
            if (nhapNhayCaoRacSo2)
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Vang;
            }
            else
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Xanh;
            }
            nhapNhayCaoRacSo2 = !nhapNhayCaoRacSo2;
        }
        //vàng đỏ
        private void CaoRacSo2VangDo()
        {
            if (nhapNhayCaoRacSo2)
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Vang;
            }
            else
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Do;
            }
            nhapNhayCaoRacSo2 = !nhapNhayCaoRacSo2;

        }
        void CheckColorCaoRac2(Digital? M10186, Digital? M10187, Digital? M10188)
        {
            //đỏ
            if ((M10186 != null && M10186.TrangThai == true) || (M10187 != null && M10187.TrangThai == true))
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Do;
            }
            //vàng xanh
            else if (M10188 != null && M10188.TrangThai == true)
            {
                CaoRacSo2VangXanh();
            }
            //vàng đỏ
            else if ((M10186 != null && M10186.TrangThai == true) && (M10188 != null && M10188.TrangThai == true)
                || (M10187 != null && M10187.TrangThai == true) && (M10188 != null && M10188.TrangThai == true))
            {
                CaoRacSo2VangDo();
            }

            else
            {
                pictureBoxCaoRac2.Image = Resources.CaoRac2Xanh;

            }
        }







        //3
        //vàng xanh
        private void CaoRacSo3VangXanh()
        {
            if (nhapNhayCaoRacSo3)
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Vang;
            }
            else
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Xanh;
            }
            nhapNhayCaoRacSo3 = !nhapNhayCaoRacSo3;
        }
        //vàng đỏ
        private void CaoRacSo3VangDo()
        {
            if (nhapNhayCaoRacSo3)
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Vang;
            }
            else
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Do;
            }
            nhapNhayCaoRacSo3 = !nhapNhayCaoRacSo3;
        }
        void CheckColorCaoRac3(Digital? M10235, Digital? M10236, Digital? M10237)
        {
            //đỏ
            if ((M10235 != null && M10235.TrangThai == true) || (M10236 != null && M10236.TrangThai == true))
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Do;
            }
            //vàng xanh
            else if (M10237 != null && M10237.TrangThai == true)
            {
                CaoRacSo3VangXanh();
            }
            //vàng đỏ
            else if ((M10235 != null && M10235.TrangThai == true) && (M10237 != null && M10237.TrangThai == true)
                || (M10236 != null && M10236.TrangThai == true) && (M10237 != null && M10237.TrangThai == true))
            {
                CaoRacSo3VangDo();
            }
            else
            {
                pictureBoxCaoRac3.Image = Resources.CaoRac3Xanh;

            }
        }










        //4
        //vàng xanh
        private void CaoRacSo4VangXanh()
        {
            if (nhapNhayCaoRacSo4)
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Vang;
            }
            else
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Xanh;
            }
            nhapNhayCaoRacSo4 = !nhapNhayCaoRacSo4;
        }
        //vàng đỏ
        private void CaoRacSo4VangDo()
        {
            if (nhapNhayCaoRacSo4)
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Vang;
            }
            else
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Do;
            }
            nhapNhayCaoRacSo4 = !nhapNhayCaoRacSo4;

        }
        void CheckColorCaoRac4(Digital? M10284, Digital? M10285, Digital? M10286)
        {
            //đỏ
            if ((M10284 != null && M10284.TrangThai == true) || (M10285 != null && M10285.TrangThai == true))
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Do;
            }
            //vàng xanh
            else if (M10286 != null && M10286.TrangThai == true)
            {
                CaoRacSo4VangXanh();
            }
            //vàng đỏ
            else if ((M10284 != null && M10284.TrangThai == true) && (M10286 != null && M10286.TrangThai == true)
                || (M10285 != null && M10285.TrangThai == true) && (M10286 != null && M10286.TrangThai == true))
            {
                CaoRacSo4VangDo();
            }
            else
            {
                pictureBoxCaoRac4.Image = Resources.CaoRac4Xanh;

            }
        }













        // Van



        // Tín hiệu van 1

        //đỏ - tím
        private void Van1DoTim()
        {
            if (nhapNhayTinHieuVan1)
            {
                pictureBoxVan1.Image = Resources.VanDo;
            }
            else
            {
                pictureBoxVan1.Image = Resources.VanTim;
            }
            nhapNhayTinHieuVan1 = !nhapNhayTinHieuVan1;
        }
        //xanh tím
        private void Van1XanhTim()
        {
            if (nhapNhayTinHieuVan1)
            {
                pictureBoxVan1.Image = Resources.VanXanh;
            }
            else
            {
                pictureBoxVan1.Image = Resources.VanTim;
            }
            nhapNhayTinHieuVan1 = !nhapNhayTinHieuVan1;

        }

        void CheckColorVan1(Digital? M10125, Digital? M10124, Digital? M10122, Digital? M10123)
        {
            //xanh
            if (M10125 != null && M10125.TrangThai == true)
            {
                pictureBoxVan1.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10124 != null && M10124.TrangThai == true)
            {

                pictureBoxVan1.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10122 != null && M10122.TrangThai == true)
            {
                Van1DoTim();
            }
            //xanh tím
            else if (M10123 != null && M10123.TrangThai == true)
            {
                Van1XanhTim();
            }
            //tím
            else
            {
                pictureBoxVan1.Image = Resources.VanTim;
            }
        }
















        // Tín hiệu van 2

        //đỏ - tím
        private void Van2DoTim()
        {
            if (nhapNhayTinHieuVan2)
            {
                pictureBoxVan2.Image = Resources.VanDo;
            }
            else
            {
                pictureBoxVan2.Image = Resources.VanTim;
            }
            nhapNhayTinHieuVan2 = !nhapNhayTinHieuVan2;
        }
        //xanh tím
        private void Van2XanhTim()
        {
            if (nhapNhayTinHieuVan2)
            {
                pictureBoxVan2.Image = Resources.VanXanh;
            }
            else
            {
                pictureBoxVan2.Image = Resources.VanTim;
            }
            nhapNhayTinHieuVan2 = !nhapNhayTinHieuVan2;

        }

        void CheckColorVan2(Digital? M10174, Digital? M10173, Digital? M10171, Digital? M10172)
        {
            //xanh
            if (M10174 != null && M10174.TrangThai == true)
            {
                pictureBoxVan2.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10173 != null && M10173.TrangThai == true)
            {
                pictureBoxVan2.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10171 != null && M10171.TrangThai == true)
            {
                Van2DoTim();
            }
            //xanh tím
            else if (M10172 != null && M10172.TrangThai == true)
            {
                Van2XanhTim();
            }
            //tím
            else
            {
                pictureBoxVan2.Image = Resources.VanTim;
            }
        }









        // Tín hiệu van 3

        //đỏ - tím
        private void Van3DoTim()
        {
            if (nhapNhayTinHieuVan3)
            {
                pictureBoxVan3.Image = Resources.VanTim;
            }
            else
            {
                pictureBoxVan3.Image = Resources.VanDo;
            }
            nhapNhayTinHieuVan3 = !nhapNhayTinHieuVan3;
        }
        //xanh tím
        private void Van3XanhTim()
        {
            if (nhapNhayTinHieuVan3)
            {
                pictureBoxVan3.Image = Resources.VanTim;
            }
            else
            {
                pictureBoxVan3.Image = Resources.VanXanh;
            }
            nhapNhayTinHieuVan3 = !nhapNhayTinHieuVan3;
        }

        void CheckColorVan3(Digital? M10223, Digital? M10222, Digital? M10220, Digital? M10221)
        {
            //xanh
            if (M10223 != null && M10223.TrangThai == true)
            {
                pictureBoxVan3.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10222 != null && M10222.TrangThai == true)
            {
                pictureBoxVan3.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10220 != null && M10220.TrangThai == true)
            {
                Van3DoTim();
            }
            //xanh tím
            else if (M10221 != null && M10221.TrangThai == true)
            {
                Van3XanhTim();
            }
            //tím
            else
            {
                pictureBoxVan3.Image = Resources.VanTim;
            }
        }












        // Tín hiệu van 4

        //đỏ - tím
        private void Van4DoTim()
        {
            if (nhapNhayTinHieuVan4)
            {
                pictureBoxVan4.Image = Resources.VanTim;
            }
            else
            {
                pictureBoxVan4.Image = Resources.VanDo;
            }
            nhapNhayTinHieuVan4 = !nhapNhayTinHieuVan4;

        }
        //xanh tím
        private void Van4XanhTim()
        {
            if (nhapNhayTinHieuVan4)
            {
                pictureBoxVan4.Image = Resources.VanTim;
            }
            else
            {
                pictureBoxVan4.Image = Resources.VanXanh;
            }
            nhapNhayTinHieuVan4 = !nhapNhayTinHieuVan4;

        }

        void CheckColorVan4(Digital? M10272, Digital? M10271, Digital? M10269, Digital? M10270)
        {
            //xanh
            if (M10272 != null && M10272.TrangThai == true)
            {
                pictureBoxVan4.Image = Resources.VanXanh;
            }
            //đỏ
            else if (M10271 != null && M10271.TrangThai == true)
            {
                pictureBoxVan4.Image = Resources.VanDo;
            }
            //đỏ tím
            else if (M10269 != null && M10269.TrangThai == true)
            {
                Van4DoTim();
            }
            //xanh tím
            else if (M10270 != null && M10270.TrangThai == true)
            {
                Van4XanhTim();
            }
            //tím
            else
            {
                pictureBoxVan4.Image = Resources.VanTim;
            }
        }


    }
}
