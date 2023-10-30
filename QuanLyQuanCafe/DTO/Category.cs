using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Category
    {
        private int _Id;

        public int Id { get => _Id; set => _Id = value; }
        public string DisplayName { get => displayName; set => displayName = value; }

        private string displayName;

        public Category(int id, string displayname)
        {
            this.Id = id;
            this.DisplayName = displayname;
        }
        public Category(DataRow rows)
        {
            this.Id = (int)rows["id"];
            this.DisplayName = (string)rows["displayname"];
        }
    }
}
