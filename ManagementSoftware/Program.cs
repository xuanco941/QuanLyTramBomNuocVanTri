using ManagementSoftware.Models;
using ManagementSoftware.GUI;
using System.Diagnostics;
using ManagementSoftware.AutoAddData;
using System.Security.Cryptography.X509Certificates;

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

            CommonAutoAddData.dataAlert.StartAutoSave(2000);
            CommonAutoAddData.dataAnalog.StartAutoSave(60000);
            CommonAutoAddData.dataDigital.StartAutoSave(60000);


            Application.Run(new Login());

            if (Common.USERSESSION != null)
            {
                Application.Run(new Main());
            }
        }
    }
}