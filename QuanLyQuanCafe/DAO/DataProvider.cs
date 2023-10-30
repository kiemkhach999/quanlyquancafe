using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        /// <summary>
        ///  sử dụng singleton design pattern để tạo ra duy nhất 1 instance của class DataProvider
        ///  để sử dụng nhiều lần tránh việc tạo nhiều kết nối khiến chương trình nặng hoặc xung đột kết nối
        /// </summary>
        
        //tạo 1 biến private static
        private static DataProvider instance;

        //Tạo 1 property hoặc method để sử dụng instance
        public static DataProvider Instance 
        { 
            get
            {
                if(instance == null)
                {
                    instance = new DataProvider();
                    
                }
                return DataProvider.instance;
            }
            //đặt private cho set để class bên ngoài không thể truy cập vào làm thay đổi biến
            private set { DataProvider.instance = value; }
        }
        public DataProvider() { }

        private string connectionSTR = "Data Source=DESKTOP-HBRVRVM\\SQLEXPRESS;Initial Catalog = QuanLyQuanCafe;Integrated Security=True";

        

        public DataTable ExecuteQuery (string query, object[] parameter = null)
        {
            //khởi tạo data thuộc DataTable
            DataTable data = new DataTable();
            //tạo connection
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mở kết nối
                connection.Open();
                //thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                //tạo 1 if để có thể truyền n parameter vào trong store procedure
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }    
                    }    
                }    

                //sử dụng SqlAdapter làm trung gian thực hiện câu truy vấn để lấy dữ liệu từ database
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                //Đóng kết nối
                connection.Close();
            }    
            
            return data;
        }
        //trả ra số dòng thành công khi insert, update 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            //khởi tạo data
            int data = 0;
            //tạo connection
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mở kết nối
                connection.Open();
                //thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                //tạo 1 if để có thể truyền n parameter vào trong store procedure
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                //Đóng kết nối
                connection.Close();
            }

            return data;
        }
        //trả về cột đầu tiên của dòng đầu tiên
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            //khởi tạo data
            object data = 0;
            //tạo connection
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mở kết nối
                connection.Open();
                //thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                //tạo 1 if để có thể truyền n parameter vào trong store procedure
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                //Đóng kết nối
                connection.Close();
            }

            return data;
        }
    }
}
