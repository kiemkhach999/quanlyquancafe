using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class CategoryDAO : CategoryInterface
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance {
            get
            {
                if(instance==null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
            set => instance = value; 
        }
        public CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> lCategory = new List<Category>();

            string query = "SELECT * FROM Category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                lCategory.Add(category);
            }

            return lCategory;
        }
        public Category GetCategoryById(int id)
        {
            Category category = null;
            string query = "SELECT * FROM Category WHERE id = "+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                 category = new Category(item);
            }
            return category;
        }
        bool CategoryInterface.Add(string name)
        {
            string query = string.Format("INSERT dbo.Category (displayname)VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool CategoryInterface.Edit(string name, int id)
        {
            string query = string.Format("UPDATE dbo.Category SET displayname = N'{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool CategoryInterface.Delete(int id)
        {
            FoodDAO.Instance.DeleteFoodByIdCategory(id);
            string query = string.Format("DELETE dbo.Category WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
