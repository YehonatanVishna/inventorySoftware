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
        private string name;
        public Borrow() { }
        private Borrow(int id) {
            this.ItemId = id;
        }
        //public Borrow(storageUniversal.BorowwDb.Borrow borrow) {
        //    itemId = borrow.ItemId;
        //    borrowedBy = borrow.BorrowedBy;
        //    when = borrow.When;
        //    quantity = borrow.Quantity;
        //    borrowingId = borrow.BorrowingId;
        //}
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
        public int ItemId { get { return  itemId; } set { this.itemId = value; } }
        public string BorrowedBy { get => borrowedBy; set => borrowedBy = value; }
        public DateTime When { get => when; set => when = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public float BorrowingId { get => borrowingId; set => borrowingId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }

        public async Task<string> SetName(int id)
        {
            var b = new BorowwDb.BorowwingsDBSoapClient();
            name = await b.getNameAsync(id);
            return name;
        }

    }
}
