using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO : TableInterface
    {
        public static int TableWidth = 80;
        public static int TableHeight = 80;
        //tạo 1 singleton
        private static TableDAO instance;

        public static TableDAO Instance { 
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
            private set => instance = value; 
        }
        public TableDAO() { }
        public void SwitchTable(int id1, int id2)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2",new object[] { id1, id2});
        }
        public List<Table> LoadTableList()
        {
            //khởi tạo 1 list
            List<Table> tableList = new List<Table>();

            //Thực thi query để lấy dữ liệu từ Database lên
            //tạo 1 datatable
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetFoodTable"); // giờ ta muốn từng row trong datatable thành list trong tableList
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }    
            return tableList;
        }
        public List<Table>LoadTableAfterHidden(int id)
        {
            List<Table> tableList = new List<Table>();
            string query = "SELECT * FROM dbo.Table WHERE id !=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        bool TableInterface.Add(string name,string status)
        {
            string query = string.Format("INSERT dbo.FoodTable (displayname,status)VALUES (N'{0}',N'{1}')", name,status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool TableInterface.Edit(string name, string status,int id)
        {
            string query = string.Format("UPDATE dbo.FoodTable SET displayname = N'{0}', status = N'{1}' WHERE id = {2}", name,status,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        bool TableInterface.Delete(int id)
        {
            
            if(isDelete(id) == 0)
            {
                string query = string.Format("DELETE dbo.FoodTable WHERE id = {0}", id);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }    
            return true;
            
        }
        public int isDelete(int id)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteNonQuery("SELECT COUNT(*) FROM dbo.Bill WHERE idTable = " + id + "AND status = 1");
            }
            catch
            {
                return 0;
            }
        }
    }
}
