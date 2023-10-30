using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Admin : Form
    {
        //Tạo 1 cái BindingSource để sử dụng cho DataSource -> Hạn chế việc bị mất kết nối Binding dữ liệu
        //Cái này hỗ trợ cho việc Binding dữ liệu
        BindingSource lFood = new BindingSource();
        BindingSource lCategory = new BindingSource();
        BindingSource lTable = new BindingSource();
        BindingSource lAccount = new BindingSource();
        //Khai báo login Account
        public Account loginAccount;

        //Khai báo biến static kiểu string chứa dữ liệu username
        public static string selectedUserName;
        public Admin()
        {
            InitializeComponent();
            dtgvFood.DataSource = lFood;
            dtgvCategory.DataSource = lCategory;
            dtgvFoodTable.DataSource = lTable;
            dtgvAccount.DataSource = lAccount;
            LoadListBillByDate(dpStart.Value, dpEnd.Value,Convert.ToInt32(txtNumPage.Text));
            LoadDateTimePicker();
            //Form thức ăn
            LoadListFood();
            BindingFood();
            LoadCategoryFood(cbCategoryFood);

            //Form Category
            LoadListCategory();
            BindCategory();

            //Form Table
            LoadListTable();
            BindTable();

            //Form Account
            LoadAccount();
            AccountBinding();
        }




        //Method




        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dpStart.Value = new DateTime(today.Year, today.Month, 1);
            dpEnd.Value = dpStart.Value.AddMonths(1).AddDays(-1);
        }

        //form thức ăn
        void LoadListBillByDate(DateTime dateIn, DateTime dateOut,int page)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillPageByDate(dateIn, dateOut,page);
        }

        void LoadListFood()
        {
            lFood.DataSource = FoodDAO.Instance.GetListFood();
        }

        void BindingFood()
        {
            txtIdFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "id",true,DataSourceUpdateMode.Never));
            txtNameFood.DataBindings.Add(new Binding("Text",dtgvFood.DataSource,"displayname", true, DataSourceUpdateMode.Never));
            nmPriceFood.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryFood(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "displayname";
        }

        List<Food> SearchFoodByName(string name)
        {
            FoodInterface foodInterface = FoodDAO.Instance;
            List<Food> foodSearch = foodInterface.Find(name);
            return foodSearch;
        }

        //form Category
        void LoadListCategory()
        {
            lCategory.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void BindCategory()
        {
            txtIdCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtNameCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "displayname", true, DataSourceUpdateMode.Never));
        }

        //Form Table

        void LoadListTable()
        {
            lTable.DataSource = TableDAO.Instance.LoadTableList();
        }
        void LoadListTableAfterHidden(int id)
        {
            lTable.DataSource = TableDAO.Instance.LoadTableAfterHidden(id);
        }
        void BindTable()
        {
            txtIdTable.DataBindings.Add(new Binding("Text", dtgvFoodTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtNameTable.DataBindings.Add(new Binding("Text", dtgvFoodTable.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            txtStatus.DataBindings.Add(new Binding("Text", dtgvFoodTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        //Form Account
        void AccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            nmTypeAccount.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            
            lAccount.DataSource = LoginDAO.Instance.GetListAccount();
        }

        void AddAccount(string uname, string dname, int type)
        {
            AccountInterface accountInterface = LoginDAO.Instance;
            if (accountInterface.Add(uname, dname, type))
            {
                MessageBox.Show("Đã thêm tài khoản " + uname + " thành công");
            }
            else
                MessageBox.Show("Lỗi");
            LoadAccount();
        }

        void EditAccount(string uname, string dname, int type)
        {
            AccountInterface accountInterface = LoginDAO.Instance;
            if (accountInterface.Edit(uname,dname,type))
            {
                MessageBox.Show("Đã cập nhật tài khoản " + uname + " thành công");
            }
            else
                MessageBox.Show("Lỗi");
            LoadAccount();
        }

        void DeleteAccount(string uname)
        {
            AccountInterface accountInterface = LoginDAO.Instance;
            if(loginAccount.UserName.Equals(uname))
            {
                MessageBox.Show("Tài khoản đang được bạn sử dụng");
                return;
            }    
            if (accountInterface.Delete(uname))
            {
                MessageBox.Show("Đã xóa tài khoản " + uname + " thành công");
            }
            else
                MessageBox.Show("Lỗi");
            LoadAccount();
        }







        //Event




        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            selectedUserName = txtUserName.Text;
            changePassword.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dpStart.Value, dpEnd.Value, Convert.ToInt32(txtNumPage.Text));
        }

        private void txtIdFood_TextChanged(object sender, EventArgs e)
        {
            //Lấy idCategory theo mỗi lần id của food thay đổi
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;
                    //Lấy ra dữ liệu Category theo id của Category
                    Category category = CategoryDAO.Instance.GetCategoryById(id);
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCategoryFood.Items)
                    {
                        if (item.Id == category.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbCategoryFood.SelectedIndex = index;

                }
            } 
            catch { }
                
            
        }

        /*Tạo ra các event để khi có sự thay đổi ở form quản lý thì sẽ tự động thay đổi dữ liệu trên form giao diện*/
        
        
        private event EventHandler addFood;
        public event  EventHandler AddFood
        {
            add { addFood += value; }
            remove { addFood -= value; }
        }
        private event EventHandler editFood;
        public event EventHandler EditFood
        {
            add { editFood += value; }
            remove { editFood -= value; }
        }
        private event EventHandler delFood;
        public event EventHandler DelFood
        {
            add { delFood += value; }
            remove { delFood -= value; }
        }
        /*Button của form quản lý đồ uống */
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FoodInterface foodInterface = FoodDAO.Instance;
            string name = txtNameFood.Text;
            int idCate = (cbCategoryFood.SelectedItem as Category).Id;
            float price = (float)nmPriceFood.Value;
            if (foodInterface.Add(name, idCate, price))
            {
                MessageBox.Show("Đã thêm " + name + " thành công");
                LoadListFood();
                if (addFood != null)
                    addFood(this, new EventArgs());
            }
            else
                MessageBox.Show("Lỗi");
            

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            FoodInterface foodInterface = FoodDAO.Instance;
            string name = txtNameFood.Text;
            int idCate = (cbCategoryFood.SelectedItem as Category).Id;
            float price = (float)nmPriceFood.Value;
            int idFood = Convert.ToInt32(txtIdFood.Text);
            if (foodInterface.Edit(name, idCate, price,idFood))
            {
                MessageBox.Show("Đã sửa " + name + " thành công");
                LoadListFood();
                if (editFood!=null)
                    editFood(this, new EventArgs());
            }
            else
                MessageBox.Show("Lỗi");
            
        }

        private void btnDelFood_Click(object sender, EventArgs e)
        {
            FoodInterface foodInterface = FoodDAO.Instance;
            int id = Convert.ToInt32(txtIdFood.Text);
            string name = txtNameFood.Text;
            if (foodInterface.Delete(id))
            {
                MessageBox.Show("Đã xóa " + name + " thành công");
                LoadListFood();
                if (delFood != null)
                    delFood(this, new EventArgs());
            }
            else
                MessageBox.Show("Lỗi");
            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListFood();
            LoadCategoryFood(cbCategoryFood);
        }
        private void btnFindFood_Click(object sender, EventArgs e)
        {
            lFood.DataSource = SearchFoodByName(txtFindFood.Text);
        }





        //Phần category
        private void btnAddCate_Click(object sender, EventArgs e)
        {
            CategoryInterface categoryInterface = CategoryDAO.Instance;
            string name = txtNameCategory.Text;
            if (categoryInterface.Add(name))
            {
                MessageBox.Show("Đã thêm " + name + " thành công");
                LoadListCategory();
            }
            else
                MessageBox.Show("Lỗi");
        }

        private void btnEditCate_Click(object sender, EventArgs e)
        {
            CategoryInterface categoryInterface = CategoryDAO.Instance;
            string name = txtNameCategory.Text;
            int id = Convert.ToInt32(txtIdCategory.Text);
            if (categoryInterface.Edit(name,id))
            {
                MessageBox.Show("Đã sửa " + name + " thành công");
                LoadListCategory();
            }
            else
                MessageBox.Show("Lỗi");
        }

        private void btnDelCate_Click(object sender, EventArgs e)
        {
            CategoryInterface categoryInterface = CategoryDAO.Instance;
            string name = txtNameCategory.Text;
            int id = Convert.ToInt32(txtIdCategory.Text);
            BillInforDAO.Instance.DeleteBillInforByIdCategory(id);
            if (categoryInterface.Delete(id))
            {
                MessageBox.Show("Đã xóa " + name + " thành công");
                
                LoadListCategory();
               
            }
            else
                MessageBox.Show("Lỗi");
        }






        //Phần Table
        private void btnEditTable_Click(object sender, EventArgs e)
        {
            TableInterface tableInterface = TableDAO.Instance;
            string name = txtNameTable.Text;
            string status = txtStatus.Text;
            int id = Convert.ToInt32(txtIdTable.Text);
            if (status == "Trống" || status == "Có người")
            {
                if (tableInterface.Edit(name,status,id))
                {
                    MessageBox.Show("Đã sửa " + name + " thành công");
                    LoadListTable();
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
                MessageBox.Show("Mời nhập lại status");
        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            CategoryInterface tableInterface = CategoryDAO.Instance;
            string name = txtNameTable.Text;
            int id = Convert.ToInt32(txtIdTable.Text);
            if (tableInterface.Delete(id))
            {
                MessageBox.Show("Đã xóa " + name + " thành công");
                LoadListCategory();
                LoadListTableAfterHidden(id);
            }
            else
                MessageBox.Show("Chức năng đang còn phát triển!");
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            TableInterface tableInterface = TableDAO.Instance;
            string name = txtNameTable.Text;
            string status = txtStatus.Text;
            if(status == "Trống" || status == "Có người")
            {
                if (tableInterface.Add(name, status))
                {
                    MessageBox.Show("Đã thêm " + name + " thành công");
                    LoadListTable();
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
                MessageBox.Show("Mời nhập lại status");

        }




        //Phần form Account
        private void btnChangePass_Click_1(object sender, EventArgs e)
        {
            selectedUserName = txtUserName.Text;
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string uname = txtUserName.Text;
            string dname = txtDisplayName.Text;
            int type = (int)nmTypeAccount.Value;
            AddAccount(uname, dname, type);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string uname = txtUserName.Text;
            string dname = txtDisplayName.Text;
            int type = (int)nmTypeAccount.Value;
            EditAccount(uname, dname, type);
        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            string uname = txtUserName.Text;
            DeleteAccount(uname);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txtNumPage.Text = "1";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int numRecord = BillDAO.Instance.GetNumBillByDate(dpStart.Value, dpEnd.Value);
            int lastPage = numRecord / 10;
            if(numRecord%10 != 0)
            {
                lastPage++;
            }
            txtNumPage.Text = lastPage.ToString();
        }

        private void txtNumPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillPageByDate(dpStart.Value, dpEnd.Value, Convert.ToInt32(txtNumPage.Text));
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtNumPage.Text);
            if (page > 1)
                page--;
            txtNumPage.Text = page.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int numRecord = BillDAO.Instance.GetNumBillByDate(dpStart.Value, dpEnd.Value);
            int page = Convert.ToInt32(txtNumPage.Text);
            if (page <= numRecord/10)
                page++;
            txtNumPage.Text = page.ToString();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyQuanCafeBillDate.USP_GetListBillByDateForReport' table. You can move, or remove it, as needed.
            this.USP_GetListBillByDateForReportTableAdapter.Fill(this.QuanLyQuanCafeBillDate.USP_GetListBillByDateForReport, dpStart.Value, dpEnd.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
