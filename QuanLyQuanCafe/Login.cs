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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string isUserName = txtUserName.Text;
            string isPassWord = txtPassWord.Text;

           if (isLogin(isUserName,isPassWord))
            {
                Account loginAccount = LoginDAO.Instance.GetListAccountByUserName(isUserName);
                 
                TableManager tableManager = new TableManager(loginAccount);
                this.Hide();
                tableManager.ShowDialog();
                this.Show();
            }
           else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool isLogin(string isUserName, string isPassWord)
        {

            return LoginDAO.Instance.isLogin(isUserName, isPassWord);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
