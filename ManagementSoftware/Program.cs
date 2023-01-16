using ManagementSoftware.Models;
using ManagementSoftware.GUI;
using System.Diagnostics;
using ManagementSoftware.AutoAddData;
using ManagementSoftware.PLC;
using ManagementSoftware.GUI.QuanLyTramBom;
using QuanLyTramBom;
using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;

namespace ManagementSoftware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();


            Application.ThreadException += new ThreadExceptionEventHandler(MyCommonExceptionHandlingMethod);

            static void MyCommonExceptionHandlingMethod(object sender, ThreadExceptionEventArgs t)
            {
                //Exception handling...
            }


            //Syncfusion
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Common.LicenseSyncfusion);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "ConnectStringDB.txt");
            string text = File.ReadAllText(path);
            Common.ConnectionString = text;




            try
            {
                new DataBaseContext().CreateDatabase();
            }
            catch
            {
                MessageBox.Show("Lỗi khởi tạo cơ sở dữ liệu, hãy thử xem lại đường dẫn kết nối của bạn.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //delete data after 2 years
            //new Thread(() =>
            //{
            //    new DeleteAllData().StartTimer(86400000);
            //}).Start();





            new Thread(() =>
            {
                new DataDigital().StartTimer(5000);
            }).Start();

            new Thread(() =>
            {
                new DataAnalog().StartTimer(60000);

            }).Start();








            Application.Run(new Login());

            if (Common.USERSESSION != null)
            {

                Application.Run(new Main());

            }
        }
    }
}