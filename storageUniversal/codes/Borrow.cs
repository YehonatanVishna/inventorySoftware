using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storageUniversal.BorowwDb;

namespace storageUniversal.codes
{
    public class Borrow
    {
        private int itemId;
        private string borrowedBy;
        private DateTime when;
        private float quantity;
        private float borrowingId;
        private int userId;
        public Borrow() { }
        public Borrow(storageUniversal.BorowwDb.Borrow borrow) {
            itemId = borrow.ItemId;
            borrowedBy = borrow.BorrowedBy;
            when = borrow.When;
            quantity = borrow.Quantity;
            borrowingId = borrow.BorrowingId;
        }
        //public string ItemName
        //{
        //    get
        //    {
        //        var con = new Connection(BorowwingsDB.constr);
        //        con.openCon();
        //        var ds = con.GetDataSet("item name", "select Name from Inventory where ID = " + this.itemId + ";");
        //        return ds.Tables["item name"].Rows[0]["Name"].ToString();
        //    }
        //}
        public int ItemId { get => ItemId; set => ItemId = value; }
        public string BorrowedBy { get => borrowedBy; set => borrowedBy = value; }
        public DateTime When { get => when; set => when = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public float BorrowingId { get => borrowingId; set => borrowingId = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
