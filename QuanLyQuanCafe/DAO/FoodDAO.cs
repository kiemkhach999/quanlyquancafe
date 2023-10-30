using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO : FoodInterface
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return instance;
            }
            set => instance = value;
        }
        public FoodDAO() { }
        public List<Food> GetFoodListByIdCategory(int id)
        {
            List<Food> lFood = new List<Food>();
            string query = "SELECT * FROM Food WHERE idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                lFood.Add(food);
            }
            
            return lFood;
        }
        
        public List<Food> GetListFood()
        {
            List<Food> foods = new List<Food>();
            string query = "SELECT * FROM Food ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                foods.Add(food);
            }
            return foods;
        }
        
        public void DeleteFoodByIdCategory(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Food WHERE idCategory = " + id);
        }
        bool FoodInterface.Add(string name, int id , float price)
        {
            string query = string.Format("INSERT dbo.Food (displayname, idCategory, price)VALUES (N'{0}',{1},{2})",name,id,price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool FoodInterface.Edit(string name, int id, float price, int idFood)
        {
            string query = string.Format("UPDATE dbo.Food SET displayname = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool FoodInterface.Delete(int id)
        {
            BillInforDAO.Instance.DeleteBillInforByIdFood(id);
            string query = string.Format("DELETE dbo.Food WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        List<Food> FoodInterface.Find(string name)
        {
            List<Food> foods = new List<Food>();
            string query = string.Format("SELECT * FROM Food WHERE displayname like N'%{0}%'",name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                foods.Add(food);
            }
            return foods;
        }
    }
}
