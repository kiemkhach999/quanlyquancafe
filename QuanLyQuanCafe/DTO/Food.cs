using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Food
    {
        private int _Id;

        public int Id { get => _Id; set => _Id = value; }

        private string _DisplayName;

        public string DisplayName { get => _DisplayName; set => _DisplayName = value; }

        private int _IdCategory;

        public int IdCategory { get => _IdCategory; set => _IdCategory = value; }

        private float _Price;

        public float Price { get => _Price; set => _Price = value; }

        public Food(int id, string displayname, int idCategory, float price)
        {
            this.Id = id;
            this.DisplayName = displayname;
            this.IdCategory = idCategory;
            this.Price = price;
        }
        public Food(DataRow rows)
        {
            this.Id = (int)rows["id"];
            this.DisplayName = (string)rows["displayname"];
            this.IdCategory =(int)rows["idCategory"];
            this.Price = (float)Convert.ToDouble(rows["price"].ToString());
        }
       
    }
}
