using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfor
    {
        private int iD;

        public int ID { get => iD; set => iD = value; }

        private int idBill;

        public int IdBill { get => idBill; set => idBill = value; }

        private int idFood;

        public int IdFood { get => idFood; set => idFood = value; }

        private int count;

        public int Count { get => count; set => count = value; }

        private float totalprize;
        public float Totalprize { get => totalprize; set => totalprize = value; }

        public BillInfor(int id, int idbill, int idfood, int count, float totalprize)
        {
            this.ID = id;
            this.IdBill = idbill;
            this.IdFood = idfood;
            this.Count = count;
            this.Totalprize = totalprize;
        }
        public BillInfor(DataRow rows)
        {
            this.ID = (int)rows["id"];
            this.IdBill = (int)rows["idBill"];
            this.IdFood = (int)rows["idFood"];
            this.Count = (int)rows["count"];
            this.Totalprize = (float)rows["totalprize"];
        }
    }
}
