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
    public partial class AccountProfile : Form
    {
        private Account _LoginAccount;

        public Account LoginAccount
        {
            get => _LoginAccount;
            set
            {
                _LoginAccount = value;
                LoadThongTinAccount(LoginAccount);
            }
        }
        public AccountProfile(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
        }
        void LoadThongTinAccount(Account acc)
        {
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
            if (acc.Type == 0)
            {
                txtTypeAccount.Text = "Admin";
            }
            else
                txtTypeAccount.Text = "Nhân viên";
        }
    }
}
