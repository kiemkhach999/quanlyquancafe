using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        public int ID
        {
            get => iD;
            set => iD = value;
        }
        

        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        

        private int status;
        public int Status { get => status; set => status = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["datecheckin"];
            var DateCheckOutTemp = row["datecheckout"];
            if(DateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)DateCheckOutTemp;
            }    
            this.Status = (int)row["status"];
        }
    }
}
