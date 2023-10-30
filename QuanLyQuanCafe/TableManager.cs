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
    public partial class TableManager : Form
    {
        //Khai báo LoginAccount để chứa cái thông tin account được đăng nhập
        private Account _LoginAccount;

        public Account LoginAccount { get => _LoginAccount;
            set {
                _LoginAccount = value;
                TypeAccount(LoginAccount.Type);
            } }

        public TableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
        }
        //Method
        void TypeAccount(int type)
        {
            stripAdmin.Enabled = type == 0;
            stripInfor.Text += " (" +LoginAccount.DisplayName + ")";
        }
        void LoadTable()
        {
            flowTable.Controls.Clear();
            List<Table> tables = TableDAO.Instance.LoadTableList();
            //Dùng button để hiển thị bàn trống hay là có người
            foreach (Table item in tables)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.DisplayName + Environment.NewLine + item.Status;

                btn.Click += btn_Click;

                //lưu luôn table bằng cách dùng tag của btn
                //khi đó mỗi button sẽ chứa dữ liệu của mỗi table khi được click
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flowTable.Controls.Add(btn);
            }
        }
        //load Category lên combobox
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "displayname";
        }

        //Load food lên combobox theo idCategory
        void LoadFoodByCategory(int id)
        {
            List<Food> listFoodByCategory = FoodDAO.Instance.GetFoodListByIdCategory(id);
            cbFoodByIdCategory.DataSource = listFoodByCategory;
            cbFoodByIdCategory.DisplayMember = "displayname";
        }
        void showBill(int id)
        {
            //Lấy billInfor theo Idtable - tức mỗi lần nhấp vào bàn ăn có người thì nó 
            //sẽ show lên Bill chưa được thanh toán
            // quy trình lấy listBillInfor:  idBill => idTable
            lsvBill.Items.Clear();
            float totalPrize = 0;
            List<BillDetail> listBillInfor = BillDetailDAO.Instance.GetListBillDetailByTable(id);
            foreach (BillDetail item in listBillInfor)
            {
                ListViewItem listView = new ListViewItem(item.FoodName.ToString());
                listView.SubItems.Add(item.Count.ToString());
                listView.SubItems.Add(item.Price.ToString());
                listView.SubItems.Add(item.TotalPrize.ToString());
                totalPrize += item.TotalPrize;
                lsvBill.Items.Add(listView);
            }
            txtThanhTien.Text = totalPrize.ToString();
        }
        float finalPrice(int discount, float thanhTien)
        {
            return thanhTien - ((thanhTien / 100) * discount);
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "displayname";
        }
        //Events


        void btn_Click(object sender, EventArgs e) // Lấy idbillinfor
        {

            //lấy Id của table từ item được gán vào tag
            int idTable = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;// lưu bàn ăn vào tag của listview mỗi lần click vào bàn ăn
            showBill(idTable);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile accountProfile = new AccountProfile(LoginAccount);
            accountProfile.Show();
        }

        private void stripAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.loginAccount = LoginAccount; // truyền thông tin account đã đăng nhập sang bên form admin
            ChangePassword change = new ChangePassword();
            change.loginAccount = LoginAccount;
            admin.ShowDialog();
            admin.AddFood += Admin_AddFood;
            admin.EditFood += Admin_EditFood;
            admin.DelFood += Admin_DelFood;
        }


        //Mỗi khi update , add, delete thì sẽ tác động đến form table manager
        private void Admin_DelFood(object sender, EventArgs e)
        {
            LoadFoodByCategory((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                showBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void Admin_EditFood(object sender, EventArgs e)
        {
            LoadFoodByCategory((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                showBill((lsvBill.Tag as Table).ID);
        }

        private void Admin_AddFood(object sender, EventArgs e)
        {
            LoadFoodByCategory((cbCategory.SelectedItem as Category).Id);
            if(lsvBill.Tag != null)
                showBill((lsvBill.Tag as Table).ID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            //ép kiểu sender để biến nó trở thành 1 control/object để xử lý event 
            //ở đây ta khởi tạo 1 instance cb kiểu Combobox rồi gán nó với
            //sender đã được ép kiểu Combobox 
            ComboBox cb = sender as ComboBox;
            //xử lý event selectedindexchanged
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category; // ép kiểu SelectedItem về category
            id = selected.Id;
            LoadFoodByCategory(id);

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = (Table)lsvBill.Tag;

            if(table == null)
            {
                MessageBox.Show("Chưa chọn bàn");
                return;
            }    
            //Lấy idBill của cái bàn ăn mình vừa click
            int billId = BillDAO.Instance.getUncheckIdBillByIdTable(table.ID);
            int foodId = (cbFoodByIdCategory.SelectedItem as Food).Id;
            int count = (int)nmFoodCount.Value;
            float totalPrize = (float)Convert.ToDouble(txtThanhTien.Text);
            
            //TH1:bàn ăn chưa có bill nào
            if(billId == -1)
            {
                //tạo bill mới
                BillDAO.Instance.AddBill(table.ID);
                //tạo billinfor
                BillInforDAO.Instance.AddBillInfor(BillDAO.Instance.GetMaxId(), foodId,count,totalPrize);
            }
            //TH2: bàn ăn có bill
            else
            {
                BillInforDAO.Instance.AddBillInfor(billId, foodId, count, totalPrize);
            }
            showBill(table.ID);
            LoadTable();
            nmFoodCount.Value = 1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //Gan du lieu ban an vao tag cua lsvBill
            Table table = lsvBill.Tag as Table;
            //lay id bill cua ban an chua thanh toan
            int idBillUncheck = BillDAO.Instance.getUncheckIdBillByIdTable(table.ID);
            int discount = (int)nmGiamGia.Value;
            float finalPrice = (float)Convert.ToDouble(txtThanhTien.Text);
            if (MessageBox.Show("Chấp nhận thanh toán cho bàn " +table.DisplayName+ " ?", "Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.checkOut(idBillUncheck,discount,finalPrice);
                showBill(table.ID);
                LoadTable();
                nmGiamGia.Value = 0;
            }
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int discount = (int)nmGiamGia.Value;
            float totalPrice = (float)Convert.ToDouble(txtThanhTien.Text);
            if (MessageBox.Show(string.Format("Chấp nhận giảm giá {0}% cho bàn {1} ?",discount,table.DisplayName), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                txtThanhTien.Text = finalPrice(discount, totalPrice).ToString();
                
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Chuyển từ bàn {0} sang bàn {1} ?", (lsvBill.Tag as Table).DisplayName, (cbSwitchTable.SelectedItem as Table).DisplayName), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFoodByCategory((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                showBill((lsvBill.Tag as Table).ID);
            LoadTable();
            LoadCategory();
            
        }
    }
}
