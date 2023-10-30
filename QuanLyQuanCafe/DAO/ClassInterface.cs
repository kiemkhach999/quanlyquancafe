using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public interface FoodInterface
    {
        bool Add(string name, int id , float price);
        bool Edit(string name, int id, float price, int idFood);
        bool Delete(int id);
        List<Food> Find(string name);
    }
    public interface CategoryInterface
    {
        bool Add(string name);
        bool Edit(string name, int id);
        bool Delete(int id);
    }
    public interface TableInterface
    {
        bool Add(string name,string status);
        bool Edit(string name,string status,int id);
        bool Delete(int id);
    }
    public interface AccountInterface
    {
        bool Add(string uname, string dname, int type);
        bool Edit(string uname, string dname, int type);
        bool Delete(string uname);
    }
    public interface ChangePassInterface
    {
        bool Update(string uname, string password);
    }
}
