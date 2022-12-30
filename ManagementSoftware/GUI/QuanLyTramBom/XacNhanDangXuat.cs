using ManagementSoftware.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.QuanLyTramBom
{
    public partial class XacNhanDangXuat : Form
    {
        public XacNhanDangXuat(string c)
        {
            InitializeComponent();
            this.ActiveControl = textBoxTaiKhoan;

            checkForm = c;
            if(checkForm == "Dashboard")
            {
                label3.Text = "Xác nhận thoát màn hình theo dõi trạm";
            }
        }
        string checkForm;
        public delegate void Callback();
        public Callback callback;

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

            string Username = textBoxTaiKhoan.Texts.Trim();
            string Password = textBoxMatKhau.Texts.Trim();
            if (String.IsNullOrEmpty(Username) == true && String.IsNullOrEmpty(Password) == true)
            {
                MessageBox.Show("Không để trống ô tài khoản và mật khẩu.", "Lỗi Cú Pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Lưu quyền và thông tin của user vào 2 biến USERSESSION và GROUPSESSION
                    if (BUSUser.AuthLogin(Username, Password) == true)
                    {
                        if (checkForm == "Dashboard")
                        {
                            this.Close();
                            callback.Invoke();
                        }
                        else if (checkForm == "Main")
                        {
                            Common.USERSESSION = null;
                            Application.Exit();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
