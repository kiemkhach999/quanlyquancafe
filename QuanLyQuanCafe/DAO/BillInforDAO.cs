using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyQuanCafe.DAO
{
   public class BillInforDAO
   {
        private static BillInforDAO instance;

        public static BillInforDAO Instance { 
            get
            {
                if(instance ==null)
                {
                    instance = new BillInforDAO();
                }
                return instance;
            }
            set => instance = value;
        }
        public BillInforDAO() { }
        public List<BillInfor> GetBillInfors(int id)
        {
            List<BillInfor> lbillInfor = new List<BillInfor>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfor WHERE idBill = " + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfor infor = new BillInfor(item);
                lbillInfor.Add(infor);
            }

            return lbillInfor;
        }
        public void DeleteBillInforByIdFood(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.BillInfor WHERE idFood = " + id);
        }
        public void DeleteBillInforByIdCategory(int id)
        {
            List<Food> food = FoodDAO.Instance.GetListFood();
            var listFoodId = from foods in food
                             where foods.IdCategory == id
                             select foods.Id;
            foreach(var item in listFoodId)
            {
                int i = item;
                DataProvider.Instance.ExecuteNonQuery("DELETE dbo.BillInfor WHERE idFood = " + i);
            }    

        }
        public void AddBillInfor(int idBill, int idFood, int count, float totalprize)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddBillInfor @idBill , @idFood , @count , @totalprize", new object[]{idBill,idFood,count,totalprize});
        }
        
   }
}
