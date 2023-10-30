using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class LoginDAO : AccountInterface,ChangePassInterface
    {
        //tạo 1 singleton
        private static LoginDAO instance;
        public static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public LoginDAO() { }
        public bool isLogin(string isUserName, string isPassWord)
        {
            //string query = "SELECT * FROM dbo.Account WHERE username = N'" + isUserName + "' AND password = N'" + isPassWord +"'";
            string query = "USP_Login @userName , @passWord";
            DataTable rs = DataProvider.Instance.ExecuteQuery(query, new object[] {isUserName,isPassWord});
            return rs.Rows.Count > 0;
        }
        public Account GetListAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE username = '" + username + "'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            string query = "SELECT username , displayname, type from dbo.Account";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        bool AccountInterface.Add(string uname, string dname, int type)
        {
            string query = string.Format("INSERT dbo.Account (username, displayname, type)VALUES (N'{0}',N'{1}',{2})", uname, dname, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool AccountInterface.Edit(string uname, string dname, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET displayname = N'{0}', type ={1} WHERE username = N'{2}'", dname, type, uname);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool AccountInterface.Delete(string uname)
        {
            string query = string.Format("DELETE dbo.Account WHERE username = N'{0}'",uname);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool ChangePassInterface.Update(string uname, string password)
        {
            string query = string.Format("UPDATE dbo.Account SET password = N'{0}' WHERE username = N'{1}'", password, uname);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
