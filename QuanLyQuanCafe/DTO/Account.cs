using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        private string _UserName;

        public string UserName { get => _UserName; set => _UserName = value; }

        private string _DisplayName;

        public string DisplayName { get => _DisplayName; set => _DisplayName = value; }

        private string _PassWord;

        public string PassWord { get => _PassWord; set => _PassWord = value; }

        private int _Type;

        public int Type { get => _Type; set => _Type = value; }

        public Account(string username, string displayname, string password, int type)
        {
            this.UserName = username;
            this.DisplayName = displayname;
            this.PassWord = password;
            this.Type = type;
        }
        public Account(DataRow rows)
        {
            this.UserName = rows["username"].ToString();
            this.DisplayName = rows["displayname"].ToString();
            this.PassWord = rows["password"].ToString();
            this.Type = (int)rows["type"];
        }
    }
}
