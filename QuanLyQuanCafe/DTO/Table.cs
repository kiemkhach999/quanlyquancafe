using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        private int iD;

        public int ID { get => iD; set => iD = value; }

        private string displayName;

        public string DisplayName { get => displayName; set => displayName = value; }

        private string status;

        public string Status { get => status; set => status = value; }

        public Table(int id, string displayname, string status)
        {
            this.ID = id;
            this.DisplayName = displayname;
            this.Status = status;
        }

        //tạo 1 hàm dựng để xử lý row từ Datatable sau khi thực hiện query bên TableDAO
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DisplayName = row["displayname"].ToString();
            this.Status = row["status"].ToString();
        }

    }
}
