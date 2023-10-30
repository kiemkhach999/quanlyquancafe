using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new BillDetailDAO();
                return instance;
            }
            set => instance = value; 
        }
        public BillDetailDAO() { }

        //Lấy hóa đơn theo mỗi lần click vào bàn
        public List<BillDetail> GetListBillDetailByTable(int id)
        {
            List<BillDetail> lbillDetail = new List<BillDetail>();

            string query = "SELECT f.displayname, bi.count, f.price, f.price*bi.count AS totalprize  FROM dbo.BillInfor AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                BillDetail billDetail = new BillDetail(item);
                lbillDetail.Add(billDetail);
            }    
            return lbillDetail;
        }
    }
}
