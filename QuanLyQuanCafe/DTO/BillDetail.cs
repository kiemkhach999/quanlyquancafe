using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillDetail
    {
        private string _FoodName;

        public string FoodName { get => _FoodName; set => _FoodName = value; }

        private int _Count;
        public int Count { get => _Count; set => _Count = value; }

        private float _Price;
        public float Price { get => _Price; set => _Price = value; }

        private float _TotalPrize;
        public float TotalPrize { get => _TotalPrize; set => _TotalPrize = value; }

        public BillDetail(string foodName, int count, float price, float totalprize)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrize = totalprize;
        }
        public BillDetail(DataRow rows)
        {
            this.FoodName = rows["displayname"].ToString();
            this.Count = (int)rows["count"];
            this.Price = (float)Convert.ToDouble(rows["price"].ToString());
            this.TotalPrize = (float)Convert.ToDouble(rows["totalprize"].ToString());
        }
    }
}
