using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class ChangePassword : Form
    {
        public Account loginAccount;
        public ChangePassword()
        {
            InitializeComponent();
            LoadUserName();
        }
        void LoadUserName()
        {
            txtUserName1.Text = Admin.selectedUserName;
        }
        void ChangePass(string newpasss, string repass,string username)
        {
            ChangePassInterface changePassInterface = LoginDAO.Instance;
            if (!(newpasss.Equals(repass)))
            {
                MessageBox.Show("Mật khẩu nhập lại sai");
                return;
            }
            if (changePassInterface.Update(username, newpasss))
            {
                MessageBox.Show("Đã đổi mật khẩu thành công");
            }
            else
                MessageBox.Show("Lỗi");
            
        }
        private void btnThoatDoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string newpass = txtNewPassword.Text;
            string repass = txtRepassword.Text;
            string username = txtUserName1.Text;
            ChangePass(newpass, repass, username);
            if(loginAccount!=null && loginAccount.UserName.Equals(username))
            {
                Environment.Exit(1);
            }    
        }
    }
}
