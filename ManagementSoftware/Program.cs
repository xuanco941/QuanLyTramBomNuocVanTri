using ManagementSoftware.Models;
using ManagementSoftware.GUI;
using System.Diagnostics;
using ManagementSoftware.AutoAddData;
using ManagementSoftware.PLC;

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
            PLCMain.plc.Open(); // open plc

            //new DataAlert().StartTimer(2000);
            //new DataAnalog().StartTimer(2000);
            //new DataDigital().StartTimer(2000);


            Application.Run(new FormTest());

            if (Common.USERSESSION != null)
            {
                Application.Run(new Main());
            }
        }
    }
}