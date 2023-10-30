using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            set => instance = value; 
        }
        public BillDAO() { }
        //lấy idbill từ bàn ăn chưa được thanh toán
        public int getUncheckIdBillByIdTable(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0 ");
            if(data.Rows.Count>0)
            {
                //lấy Row đầu tiên
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void AddBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddBill @idTable",new object[]{id});
        }
        public int GetMaxId()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

        public void checkOut(int id, int discount, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET datecheckout = GETDATE(), status = 1, discount = "+ discount + ", totalprice = " + totalPrice +" WHERE id = " +id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetListBillByDate(DateTime dateIn, DateTime dateOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @dateIn , @dateOut", new object[] { dateIn, dateOut });
        }
        public DataTable GetListBillPageByDate(DateTime dateIn, DateTime dateOut,int page)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetPageBillByDate @dateIn , @dateOut , @page", new object[] { dateIn, dateOut, page });
        }
        public int GetNumBillByDate(DateTime dateIn, DateTime dateOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBill @dateIn , @dateOut", new object[] { dateIn, dateOut });
        }
    }
}
